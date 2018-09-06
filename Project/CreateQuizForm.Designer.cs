namespace NTM_V4
{
    partial class CreateQuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecCodeLbl = new System.Windows.Forms.Label();
            this.CreateQuizIntroLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.RecBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecCodeLbl
            // 
            this.RecCodeLbl.AutoSize = true;
            this.RecCodeLbl.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.RecCodeLbl.Location = new System.Drawing.Point(13, 366);
            this.RecCodeLbl.Name = "RecCodeLbl";
            this.RecCodeLbl.Size = new System.Drawing.Size(177, 20);
            this.RecCodeLbl.TabIndex = 2;
            this.RecCodeLbl.Text = "Your code is :";
            // 
            // CreateQuizIntroLBL
            // 
            this.CreateQuizIntroLBL.AutoSize = true;
            this.CreateQuizIntroLBL.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateQuizIntroLBL.Location = new System.Drawing.Point(12, 9);
            this.CreateQuizIntroLBL.Name = "CreateQuizIntroLBL";
            this.CreateQuizIntroLBL.Size = new System.Drawing.Size(233, 27);
            this.CreateQuizIntroLBL.TabIndex = 4;
            this.CreateQuizIntroLBL.Text = "Create a quiz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter your intro name";
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.UsernameLBL.Location = new System.Drawing.Point(196, 366);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(69, 20);
            this.UsernameLBL.TabIndex = 12;
            this.UsernameLBL.Text = "- - -";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(17, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 55);
            this.textBox1.TabIndex = 13;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.checkBox1.Location = new System.Drawing.Point(17, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(172, 24);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Multi Choice";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.checkBox2.Location = new System.Drawing.Point(17, 149);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(196, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Written Answer";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label2.Location = new System.Drawing.Point(305, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "- - -";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // RecBut
            // 
            this.RecBut.BackColor = System.Drawing.Color.Teal;
            this.RecBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecBut.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.RecBut.ForeColor = System.Drawing.Color.White;
            this.RecBut.Location = new System.Drawing.Point(17, 199);
            this.RecBut.Name = "RecBut";
            this.RecBut.Size = new System.Drawing.Size(118, 34);
            this.RecBut.TabIndex = 17;
            this.RecBut.Text = "Browse";
            this.RecBut.UseVisualStyleBackColor = false;
            this.RecBut.Click += new System.EventHandler(this.RecBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter your images in a folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label4.Location = new System.Drawing.Point(228, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "- - -";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label5.Location = new System.Drawing.Point(141, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Path :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.label6.Location = new System.Drawing.Point(13, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(357, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "How many questions are there?\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(17, 270);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 41);
            this.textBox2.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 34);
            this.button1.TabIndex = 23;
            this.button1.Text = "Create your quiz!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(782, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RecBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateQuizIntroLBL);
            this.Controls.Add(this.RecCodeLbl);
            this.Name = "CreateQuizForm";
            this.Text = "CreateQuizForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateQuizForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateQuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecCodeLbl;
        private System.Windows.Forms.Label CreateQuizIntroLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button RecBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}