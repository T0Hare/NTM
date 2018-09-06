namespace NTM_V4
{
    partial class Form1
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
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.PassLBL = new System.Windows.Forms.Label();
            this.ChemRevIntroLBL = new System.Windows.Forms.Label();
            this.Userbox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.LogInBut = new System.Windows.Forms.Button();
            this.LogResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RetreivePassBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.UserNameLBL.Location = new System.Drawing.Point(12, 36);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(105, 20);
            this.UserNameLBL.TabIndex = 0;
            this.UserNameLBL.Text = "Username";
            // 
            // PassLBL
            // 
            this.PassLBL.AutoSize = true;
            this.PassLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.PassLBL.Location = new System.Drawing.Point(12, 108);
            this.PassLBL.Name = "PassLBL";
            this.PassLBL.Size = new System.Drawing.Size(105, 20);
            this.PassLBL.TabIndex = 1;
            this.PassLBL.Text = "Password";
            // 
            // ChemRevIntroLBL
            // 
            this.ChemRevIntroLBL.AutoSize = true;
            this.ChemRevIntroLBL.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChemRevIntroLBL.Location = new System.Drawing.Point(86, 9);
            this.ChemRevIntroLBL.Name = "ChemRevIntroLBL";
            this.ChemRevIntroLBL.Size = new System.Drawing.Size(199, 27);
            this.ChemRevIntroLBL.TabIndex = 3;
            this.ChemRevIntroLBL.Text = "Chem revise";
            // 
            // Userbox
            // 
            this.Userbox.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.Userbox.Location = new System.Drawing.Point(16, 59);
            this.Userbox.Multiline = true;
            this.Userbox.Name = "Userbox";
            this.Userbox.Size = new System.Drawing.Size(343, 46);
            this.Userbox.TabIndex = 4;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(16, 131);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(343, 20);
            this.PassBox.TabIndex = 6;
            this.PassBox.UseSystemPasswordChar = true;
            this.PassBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LogInBut
            // 
            this.LogInBut.BackColor = System.Drawing.Color.Teal;
            this.LogInBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.LogInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBut.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.LogInBut.ForeColor = System.Drawing.Color.White;
            this.LogInBut.Location = new System.Drawing.Point(12, 157);
            this.LogInBut.Name = "LogInBut";
            this.LogInBut.Size = new System.Drawing.Size(118, 44);
            this.LogInBut.TabIndex = 7;
            this.LogInBut.Text = "Log in";
            this.LogInBut.UseVisualStyleBackColor = false;
            this.LogInBut.Click += new System.EventHandler(this.LogInBut_Click);
            // 
            // LogResult
            // 
            this.LogResult.AutoSize = true;
            this.LogResult.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.LogResult.Location = new System.Drawing.Point(12, 275);
            this.LogResult.Name = "LogResult";
            this.LogResult.Size = new System.Drawing.Size(69, 20);
            this.LogResult.TabIndex = 8;
            this.LogResult.Text = "_ _ _";
            this.LogResult.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Create Account";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RetreivePassBut
            // 
            this.RetreivePassBut.BackColor = System.Drawing.Color.Teal;
            this.RetreivePassBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RetreivePassBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RetreivePassBut.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.RetreivePassBut.ForeColor = System.Drawing.Color.White;
            this.RetreivePassBut.Location = new System.Drawing.Point(12, 245);
            this.RetreivePassBut.Name = "RetreivePassBut";
            this.RetreivePassBut.Size = new System.Drawing.Size(225, 27);
            this.RetreivePassBut.TabIndex = 10;
            this.RetreivePassBut.Text = "Retreive Password";
            this.RetreivePassBut.UseVisualStyleBackColor = false;
            this.RetreivePassBut.Click += new System.EventHandler(this.RetreivePassBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(379, 340);
            this.Controls.Add(this.RetreivePassBut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogResult);
            this.Controls.Add(this.LogInBut);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.Userbox);
            this.Controls.Add(this.ChemRevIntroLBL);
            this.Controls.Add(this.PassLBL);
            this.Controls.Add(this.UserNameLBL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.Label PassLBL;
        private System.Windows.Forms.Label ChemRevIntroLBL;
        private System.Windows.Forms.TextBox Userbox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button LogInBut;
        private System.Windows.Forms.Label LogResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RetreivePassBut;
    }
}

