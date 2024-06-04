namespace Nesne_2_OGRENCI_TAKIP_1
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            panel1 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            btnExit = new Button();
            btnRegister = new Button();
            btnLesson = new Button();
            btnStudent = new Button();
            label2 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            panel9 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1702, 125);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DeepSkyBlue;
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1678, 101);
            panel4.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Tan;
            panel7.Controls.Add(label1);
            panel7.Location = new Point(12, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(1654, 77);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gill Sans Ultra Bold", 30F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1654, 77);
            label1.TabIndex = 0;
            label1.Text = "Ögrenci Takip Programı";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 808);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DeepSkyBlue;
            panel5.Controls.Add(panel8);
            panel5.Location = new Point(12, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 785);
            panel5.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Tan;
            panel8.Controls.Add(btnExit);
            panel8.Controls.Add(btnRegister);
            panel8.Controls.Add(btnLesson);
            panel8.Controls.Add(btnStudent);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(12, 12);
            panel8.Name = "panel8";
            panel8.Size = new Size(207, 761);
            panel8.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Crimson;
            btnExit.Location = new Point(12, 697);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(184, 49);
            btnExit.TabIndex = 4;
            btnExit.Text = "Çıkış";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.DarkGreen;
            btnRegister.Location = new Point(12, 264);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(184, 49);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLesson
            // 
            btnLesson.BackColor = Color.Transparent;
            btnLesson.FlatStyle = FlatStyle.Flat;
            btnLesson.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLesson.ForeColor = Color.DarkGreen;
            btnLesson.Location = new Point(12, 174);
            btnLesson.Name = "btnLesson";
            btnLesson.Size = new Size(184, 49);
            btnLesson.TabIndex = 2;
            btnLesson.Text = "Dersler";
            btnLesson.UseVisualStyleBackColor = false;
            btnLesson.Click += btnLesson_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Transparent;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.DarkGreen;
            btnStudent.Location = new Point(12, 84);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(184, 49);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Ögrenciler";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 15F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(184, 34);
            label2.TabIndex = 0;
            label2.Text = "Seçenekler";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Tan;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(255, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(1447, 808);
            panel3.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DeepSkyBlue;
            panel6.Controls.Add(panel9);
            panel6.Location = new Point(12, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(1423, 785);
            panel6.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Navy;
            panel9.Location = new Point(12, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(1399, 761);
            panel9.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 4.20000029F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(1373, 797);
            label3.Name = "label3";
            label3.Size = new Size(74, 11);
            label3.TabIndex = 2;
            label3.Text = "Ömer Can DOĞDU";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1702, 933);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Takip Programı";
            Load += FrmMain_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel7;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private Label label1;
        private Panel panel8;
        private Panel panel9;
        private Button btnExit;
        private Button btnRegister;
        private Button btnLesson;
        private Button btnStudent;
        private Label label2;
        private Label label3;
    }
}
