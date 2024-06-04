﻿using Nesne_2_OGRENCI_TAKIP_1.Models;
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
    public partial class FrmLesson : Form
    {
        public FrmLesson()
        {
            InitializeComponent();
        }
        AppDbContext db = new AppDbContext();
        private void FrmLesson_Load(object sender, EventArgs e)
        {
            GetLessonList();
        }

        void GetLessonList()
        {
            dgLesson.Rows.Clear();
            var lessons = db.Lessons.ToList();
            foreach (var lesson in lessons)
            {
                dgLesson.Rows.Add(lesson.Id, lesson.Code, lesson.Name, lesson.Credit);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "" || txtCredit.Text == "")
            {
                MessageBox.Show("Boş alan bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (db.Lessons.Count(c => c.Code == txtCode.Text) > 0)
            {
                MessageBox.Show("Ders kodu zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var lesson = new Lesson();
            lesson.Code = txtCode.Text;
            lesson.Name = txtName.Text;
            lesson.Credit = Convert.ToInt32(txtCredit.Text);
            lesson.Created = DateTime.Now;
            lesson.Updated = DateTime.Now;

            db.Lessons.Add(lesson);
            db.SaveChanges();
            MessageBox.Show("Ders Ekleme Başarılı", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetLessonList();
            btnClear.PerformClick();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtCode.Text == "" || txtName.Text == "" || txtCredit.Text == "")
            {
                MessageBox.Show("Lütfen Kayıt Seçin ve Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var lesson = db.Lessons.Where(s => s.Id == id).SingleOrDefault();
            if (lesson == null)
            {
                MessageBox.Show("Kayıt Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lesson.Code = txtCode.Text;
            lesson.Name = txtName.Text;
            lesson.Credit = Convert.ToInt32(txtCredit.Text);
            lesson.Updated = DateTime.Now;

            db.Lessons.Update(lesson);
            db.SaveChanges();
            MessageBox.Show("Ders Güncelleme Başarılı", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetLessonList();
            btnClear.PerformClick();
        }

        private void dgLesson_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgLesson.CurrentRow.Cells[0].Value.ToString();
            txtCode.Text = dgLesson.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dgLesson.CurrentRow.Cells[2].Value.ToString();
            txtCredit.Text = dgLesson.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Lütfen Ders Kaydı Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var id = Convert.ToInt32(txtId.Text);
            var lesson = db.Lessons.Where(s => s.Id == id).SingleOrDefault();
            if (lesson == null)
            {
                MessageBox.Show("Ders Kaydı Bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Lessons.Remove(lesson);
            db.SaveChanges();
            MessageBox.Show("Ders Kaydı Silindi", "Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetLessonList();
            btnClear.PerformClick();
        }
    }
}