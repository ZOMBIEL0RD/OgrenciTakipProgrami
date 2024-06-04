﻿using Microsoft.EntityFrameworkCore;
using Nesne_2_OGRENCI_TAKIP_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_2_OGRENCI_TAKIP_1.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        AppDbContext db = new AppDbContext();
        private void FrmRegister_Load(object sender, EventArgs e)
        {
            GetLessonList("");
            GetStudentList("");
        }

        void GetLessonList(string st)
        {
            dgLesson.Rows.Clear();
            var lessons = db.Lessons.Where(s => s.Name.Contains(st)).ToList();
            foreach (var lesson in lessons)
            {
                dgLesson.Rows.Add(lesson.Id, lesson.Code, lesson.Name, lesson.Credit);
            }
        }
        void GetStudentList(string st)
        {
            var students = db.Students.Where(s => s.Name.Contains(st)).ToList();
            dgStudent.Rows.Clear();
            foreach (var student in students)
            {
                dgStudent.Rows.Add(student.Id, student.Number, student.Name, student.Email, student.Phone);
            }
        }

        private void txtSearchLesson_TextChanged(object sender, EventArgs e)
        {
            GetLessonList(txtSearchLesson.Text);
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            GetStudentList(txtSearchStudent.Text);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int lessonId = Convert.ToInt32(dgLesson.CurrentRow.Cells[0].Value.ToString());
            int studentId = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value.ToString());

            string lessonName = dgLesson.CurrentRow.Cells[2].Value.ToString();
            string studentName = dgStudent.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show(studentName + " adlı öğrenci için " + lessonName + " ders kaydını onaylıyor musunuz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            if (db.Registers.Count(c => c.StudentId == studentId && c.LessonId == lessonId) > 0)
            {
                MessageBox.Show(studentName + " adlı öğrenci " + lessonName + " dersine zaten kayıtlı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var register = new Register();
            register.LessonId = lessonId;
            register.StudentId = studentId;
            register.Created = DateTime.Now;
            register.Updated = DateTime.Now;
            db.Registers.Add(register);
            db.SaveChanges();
            MessageBox.Show("Ders Kaydı Başarılı", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var lessonId = Convert.ToInt32(dgLesson.CurrentRow.Cells[0].Value.ToString());
            var registers = db.Registers.Where(s => s.LessonId == lessonId).ToList();

            dgLessonStudent.Rows.Clear();
            foreach (var register in registers)
            {
                dgLessonStudent.Rows.Add(register.Id, register.Student.Number, register.Student.Name, register.Student.Email, register.Student.Phone);
            }

        }

        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var studentId = Convert.ToInt32(dgStudent.CurrentRow.Cells[0].Value.ToString());
            var registers = db.Registers.Where(s => s.StudentId == studentId).ToList();
            dgStudentLesson.Rows.Clear();
            foreach (var register in registers)
            {
                dgStudentLesson.Rows.Add(register.Id, register.Lesson.Code, register.Lesson.Name, register.Lesson.Credit);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(dgLessonStudent.CurrentRow.Cells[0].Value.ToString());
            var studentName = dgLessonStudent.CurrentRow.Cells[2].Value.ToString();
            var lessonName = dgLesson.CurrentRow.Cells[2].Value.ToString();

            if (MessageBox.Show(studentName + " adlı öğrencinin " + lessonName + " ders kaydı silinecektir, onaylıyor musunuz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            var register = db.Registers.Where(s => s.Id == id).SingleOrDefault();
            if (register != null)
            {
                db.Registers.Remove(register);
                db.SaveChanges();
            }
            MessageBox.Show("Ders Kaydı Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
