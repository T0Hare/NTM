namespace NTM_V4
{
    partial class QuizPage
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
            this.components = new System.ComponentModel.Container();
            this.QuestionBox = new System.Windows.Forms.PictureBox();
            this.QuizNameLBL = new System.Windows.Forms.Label();
            this.TimeLeftLBL = new System.Windows.Forms.Label();
            this.CheckBUT = new System.Windows.Forms.Button();
            this.CustomQbox = new System.Windows.Forms.TextBox();
            this.No1LBL = new System.Windows.Forms.Label();
            this.No2LBL = new System.Windows.Forms.Label();
            this.No3LBL = new System.Windows.Forms.Label();
            this.No4LBL = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Timecountdown = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RightWrongDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.QuestionBox.Location = new System.Drawing.Point(12, 54);
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.Size = new System.Drawing.Size(519, 368);
            this.QuestionBox.TabIndex = 0;
            this.QuestionBox.TabStop = false;
            // 
            // QuizNameLBL
            // 
            this.QuizNameLBL.AutoSize = true;
            this.QuizNameLBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuizNameLBL.Location = new System.Drawing.Point(12, 9);
            this.QuizNameLBL.Name = "QuizNameLBL";
            this.QuizNameLBL.Size = new System.Drawing.Size(120, 33);
            this.QuizNameLBL.TabIndex = 1;
            this.QuizNameLBL.Text = "_ _ _";
            // 
            // TimeLeftLBL
            // 
            this.TimeLeftLBL.AutoSize = true;
            this.TimeLeftLBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftLBL.Location = new System.Drawing.Point(537, 389);
            this.TimeLeftLBL.Name = "TimeLeftLBL";
            this.TimeLeftLBL.Size = new System.Drawing.Size(246, 33);
            this.TimeLeftLBL.TabIndex = 2;
            this.TimeLeftLBL.Text = "Time Left :";
            // 
            // CheckBUT
            // 
            this.CheckBUT.BackColor = System.Drawing.Color.Navy;
            this.CheckBUT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CheckBUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBUT.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.CheckBUT.ForeColor = System.Drawing.Color.White;
            this.CheckBUT.Location = new System.Drawing.Point(537, 428);
            this.CheckBUT.Name = "CheckBUT";
            this.CheckBUT.Size = new System.Drawing.Size(116, 97);
            this.CheckBUT.TabIndex = 56;
            this.CheckBUT.Text = "Check";
            this.CheckBUT.UseVisualStyleBackColor = false;
            this.CheckBUT.Click += new System.EventHandler(this.CheckBUT_Click);
            // 
            // CustomQbox
            // 
            this.CustomQbox.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CustomQbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomQbox.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomQbox.ForeColor = System.Drawing.Color.White;
            this.CustomQbox.Location = new System.Drawing.Point(12, 428);
            this.CustomQbox.Multiline = true;
            this.CustomQbox.Name = "CustomQbox";
            this.CustomQbox.Size = new System.Drawing.Size(519, 97);
            this.CustomQbox.TabIndex = 77;
            this.CustomQbox.Visible = false;
            // 
            // No1LBL
            // 
            this.No1LBL.AutoSize = true;
            this.No1LBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No1LBL.Location = new System.Drawing.Point(537, 54);
            this.No1LBL.Name = "No1LBL";
            this.No1LBL.Size = new System.Drawing.Size(36, 33);
            this.No1LBL.TabIndex = 78;
            this.No1LBL.Text = "1";
            this.No1LBL.Visible = false;
            // 
            // No2LBL
            // 
            this.No2LBL.AutoSize = true;
            this.No2LBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No2LBL.Location = new System.Drawing.Point(537, 103);
            this.No2LBL.Name = "No2LBL";
            this.No2LBL.Size = new System.Drawing.Size(36, 33);
            this.No2LBL.TabIndex = 79;
            this.No2LBL.Text = "2";
            this.No2LBL.Visible = false;
            // 
            // No3LBL
            // 
            this.No3LBL.AutoSize = true;
            this.No3LBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No3LBL.Location = new System.Drawing.Point(537, 152);
            this.No3LBL.Name = "No3LBL";
            this.No3LBL.Size = new System.Drawing.Size(36, 33);
            this.No3LBL.TabIndex = 80;
            this.No3LBL.Text = "3";
            this.No3LBL.Visible = false;
            // 
            // No4LBL
            // 
            this.No4LBL.AutoSize = true;
            this.No4LBL.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No4LBL.Location = new System.Drawing.Point(537, 201);
            this.No4LBL.Name = "No4LBL";
            this.No4LBL.Size = new System.Drawing.Size(36, 33);
            this.No4LBL.TabIndex = 81;
            this.No4LBL.Text = "4";
            this.No4LBL.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(570, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(346, 43);
            this.listBox1.TabIndex = 82;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(570, 103);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(346, 43);
            this.listBox2.TabIndex = 83;
            this.listBox2.Visible = false;
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(570, 152);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(346, 43);
            this.listBox3.TabIndex = 84;
            this.listBox3.Visible = false;
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(570, 201);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(346, 43);
            this.listBox4.TabIndex = 85;
            this.listBox4.Visible = false;
            // 
            // Timecountdown
            // 
            this.Timecountdown.AutoSize = true;
            this.Timecountdown.Font = new System.Drawing.Font("Lucida Console", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timecountdown.Location = new System.Drawing.Point(789, 389);
            this.Timecountdown.Name = "Timecountdown";
            this.Timecountdown.Size = new System.Drawing.Size(36, 33);
            this.Timecountdown.TabIndex = 86;
            this.Timecountdown.Text = "-";
            // 
            // RightWrongDisplay
            // 
            this.RightWrongDisplay.AutoSize = true;
            this.RightWrongDisplay.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightWrongDisplay.Location = new System.Drawing.Point(12, 528);
            this.RightWrongDisplay.Name = "RightWrongDisplay";
            this.RightWrongDisplay.Size = new System.Drawing.Size(19, 16);
            this.RightWrongDisplay.TabIndex = 87;
            this.RightWrongDisplay.Text = "-";
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(928, 578);
            this.Controls.Add(this.RightWrongDisplay);
            this.Controls.Add(this.Timecountdown);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.No4LBL);
            this.Controls.Add(this.No3LBL);
            this.Controls.Add(this.No2LBL);
            this.Controls.Add(this.No1LBL);
            this.Controls.Add(this.CustomQbox);
            this.Controls.Add(this.CheckBUT);
            this.Controls.Add(this.TimeLeftLBL);
            this.Controls.Add(this.QuizNameLBL);
            this.Controls.Add(this.QuestionBox);
            this.Name = "QuizPage";
            this.Text = "QuizPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizPage_FormClosed);
            this.Load += new System.EventHandler(this.QuizPage_Load);
            this.Shown += new System.EventHandler(this.QuizPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox QuestionBox;
        private System.Windows.Forms.Label QuizNameLBL;
        private System.Windows.Forms.Label TimeLeftLBL;
        private System.Windows.Forms.Button CheckBUT;
        private System.Windows.Forms.TextBox CustomQbox;
        private System.Windows.Forms.Label No1LBL;
        private System.Windows.Forms.Label No2LBL;
        private System.Windows.Forms.Label No3LBL;
        private System.Windows.Forms.Label No4LBL;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label Timecountdown;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label RightWrongDisplay;
    }
}