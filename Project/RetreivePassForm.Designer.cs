namespace NTM_V4
{
    partial class RetreivePassForm
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
            this.RecBox = new System.Windows.Forms.TextBox();
            this.RecBut = new System.Windows.Forms.Button();
            this.UsernameintroLBL = new System.Windows.Forms.Label();
            this.PasswordintroLBL = new System.Windows.Forms.Label();
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecCodeLbl
            // 
            this.RecCodeLbl.AutoSize = true;
            this.RecCodeLbl.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.RecCodeLbl.Location = new System.Drawing.Point(12, 9);
            this.RecCodeLbl.Name = "RecCodeLbl";
            this.RecCodeLbl.Size = new System.Drawing.Size(297, 20);
            this.RecCodeLbl.TabIndex = 1;
            this.RecCodeLbl.Text = "Enter your recovery code";
            // 
            // RecBox
            // 
            this.RecBox.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Bold);
            this.RecBox.Location = new System.Drawing.Point(16, 43);
            this.RecBox.Multiline = true;
            this.RecBox.Name = "RecBox";
            this.RecBox.Size = new System.Drawing.Size(282, 55);
            this.RecBox.TabIndex = 2;
            // 
            // RecBut
            // 
            this.RecBut.BackColor = System.Drawing.Color.Teal;
            this.RecBut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RecBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecBut.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.RecBut.ForeColor = System.Drawing.Color.White;
            this.RecBut.Location = new System.Drawing.Point(304, 43);
            this.RecBut.Name = "RecBut";
            this.RecBut.Size = new System.Drawing.Size(118, 55);
            this.RecBut.TabIndex = 8;
            this.RecBut.Text = "Enter";
            this.RecBut.UseVisualStyleBackColor = false;
            this.RecBut.Click += new System.EventHandler(this.RecBut_Click);
            // 
            // UsernameintroLBL
            // 
            this.UsernameintroLBL.AutoSize = true;
            this.UsernameintroLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.UsernameintroLBL.Location = new System.Drawing.Point(12, 101);
            this.UsernameintroLBL.Name = "UsernameintroLBL";
            this.UsernameintroLBL.Size = new System.Drawing.Size(129, 20);
            this.UsernameintroLBL.TabIndex = 9;
            this.UsernameintroLBL.Text = "Username :";
            // 
            // PasswordintroLBL
            // 
            this.PasswordintroLBL.AutoSize = true;
            this.PasswordintroLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.PasswordintroLBL.Location = new System.Drawing.Point(12, 138);
            this.PasswordintroLBL.Name = "PasswordintroLBL";
            this.PasswordintroLBL.Size = new System.Drawing.Size(129, 20);
            this.PasswordintroLBL.TabIndex = 10;
            this.PasswordintroLBL.Text = "Password :";
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.UsernameLBL.Location = new System.Drawing.Point(147, 101);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(69, 20);
            this.UsernameLBL.TabIndex = 11;
            this.UsernameLBL.Text = "- - -";
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.PasswordLBL.Location = new System.Drawing.Point(147, 138);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(69, 20);
            this.PasswordLBL.TabIndex = 12;
            this.PasswordLBL.Text = "- - -";
            // 
            // RetreivePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(434, 221);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.UsernameLBL);
            this.Controls.Add(this.PasswordintroLBL);
            this.Controls.Add(this.UsernameintroLBL);
            this.Controls.Add(this.RecBut);
            this.Controls.Add(this.RecBox);
            this.Controls.Add(this.RecCodeLbl);
            this.Name = "RetreivePassForm";
            this.Text = "RetreivePassForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RetreivePassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecCodeLbl;
        private System.Windows.Forms.TextBox RecBox;
        private System.Windows.Forms.Button RecBut;
        private System.Windows.Forms.Label UsernameintroLBL;
        private System.Windows.Forms.Label PasswordintroLBL;
        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.Label PasswordLBL;
    }
}