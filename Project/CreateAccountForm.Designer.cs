namespace NTM_V4
{
    partial class CreateAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateAcctBut = new System.Windows.Forms.Button();
            this.CreateUserBox = new System.Windows.Forms.TextBox();
            this.CreatePassBox = new System.Windows.Forms.TextBox();
            this.RepeatPassBox = new System.Windows.Forms.TextBox();
            this.CreateAcctRecBox = new System.Windows.Forms.TextBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Recovery code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.Location = new System.Drawing.Point(12, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Repeat Password";
            // 
            // CreateAcctBut
            // 
            this.CreateAcctBut.BackColor = System.Drawing.Color.Teal;
            this.CreateAcctBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateAcctBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAcctBut.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.CreateAcctBut.ForeColor = System.Drawing.Color.White;
            this.CreateAcctBut.Location = new System.Drawing.Point(18, 490);
            this.CreateAcctBut.Name = "CreateAcctBut";
            this.CreateAcctBut.Size = new System.Drawing.Size(213, 35);
            this.CreateAcctBut.TabIndex = 8;
            this.CreateAcctBut.Text = "Create Account";
            this.CreateAcctBut.UseVisualStyleBackColor = false;
            this.CreateAcctBut.Click += new System.EventHandler(this.LogInBut_Click);
            // 
            // CreateUserBox
            // 
            this.CreateUserBox.Location = new System.Drawing.Point(18, 46);
            this.CreateUserBox.Multiline = true;
            this.CreateUserBox.Name = "CreateUserBox";
            this.CreateUserBox.Size = new System.Drawing.Size(293, 78);
            this.CreateUserBox.TabIndex = 9;
            // 
            // CreatePassBox
            // 
            this.CreatePassBox.Location = new System.Drawing.Point(18, 170);
            this.CreatePassBox.Multiline = true;
            this.CreatePassBox.Name = "CreatePassBox";
            this.CreatePassBox.Size = new System.Drawing.Size(293, 78);
            this.CreatePassBox.TabIndex = 10;
            // 
            // RepeatPassBox
            // 
            this.RepeatPassBox.Location = new System.Drawing.Point(18, 288);
            this.RepeatPassBox.Multiline = true;
            this.RepeatPassBox.Name = "RepeatPassBox";
            this.RepeatPassBox.Size = new System.Drawing.Size(293, 78);
            this.RepeatPassBox.TabIndex = 11;
            // 
            // CreateAcctRecBox
            // 
            this.CreateAcctRecBox.Location = new System.Drawing.Point(18, 406);
            this.CreateAcctRecBox.Multiline = true;
            this.CreateAcctRecBox.Name = "CreateAcctRecBox";
            this.CreateAcctRecBox.Size = new System.Drawing.Size(293, 78);
            this.CreateAcctRecBox.TabIndex = 12;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLbl.Location = new System.Drawing.Point(12, 528);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(85, 24);
            this.ErrorLbl.TabIndex = 13;
            this.ErrorLbl.Text = "- - -";
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(499, 588);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.CreateAcctRecBox);
            this.Controls.Add(this.RepeatPassBox);
            this.Controls.Add(this.CreatePassBox);
            this.Controls.Add(this.CreateUserBox);
            this.Controls.Add(this.CreateAcctBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateAcctBut;
        private System.Windows.Forms.TextBox CreateUserBox;
        private System.Windows.Forms.TextBox CreatePassBox;
        private System.Windows.Forms.TextBox RepeatPassBox;
        private System.Windows.Forms.TextBox CreateAcctRecBox;
        private System.Windows.Forms.Label ErrorLbl;
    }
}