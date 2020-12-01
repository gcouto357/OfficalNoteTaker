namespace OfficalNoteTaker
{
    partial class Form2
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
            this.Login_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.Notes = new System.Windows.Forms.Label();
            this.Local_but = new System.Windows.Forms.Button();
            this.Reset_but = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Set_but = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.reset_label = new System.Windows.Forms.Label();
            this.reset_lbl = new System.Windows.Forms.Label();
            this.Reset2_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_but
            // 
            this.Login_but.Location = new System.Drawing.Point(355, 221);
            this.Login_but.Name = "Login_but";
            this.Login_but.Size = new System.Drawing.Size(75, 23);
            this.Login_but.TabIndex = 0;
            this.Login_but.Text = "Login";
            this.Login_but.UseVisualStyleBackColor = true;
            this.Login_but.Click += new System.EventHandler(this.Login_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(344, 145);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(100, 20);
            this.txt_User.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(344, 195);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 4;
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(361, 78);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(69, 13);
            this.Notes.TabIndex = 5;
            this.Notes.Text = "Note Taking ";
            this.Notes.Click += new System.EventHandler(this.label3_Click);
            // 
            // Local_but
            // 
            this.Local_but.Location = new System.Drawing.Point(209, 259);
            this.Local_but.Name = "Local_but";
            this.Local_but.Size = new System.Drawing.Size(75, 23);
            this.Local_but.TabIndex = 6;
            this.Local_but.Text = "Local User";
            this.Local_but.UseVisualStyleBackColor = true;
            this.Local_but.Click += new System.EventHandler(this.Local_but_Click);
            // 
            // Reset_but
            // 
            this.Reset_but.Location = new System.Drawing.Point(355, 259);
            this.Reset_but.Name = "Reset_but";
            this.Reset_but.Size = new System.Drawing.Size(75, 23);
            this.Reset_but.TabIndex = 7;
            this.Reset_but.Text = "Reset";
            this.Reset_but.UseVisualStyleBackColor = true;
            this.Reset_but.Click += new System.EventHandler(this.Reset_but_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "If you have never logged in, select the set option after typing the desired passw" +
    "ord and username";
            // 
            // Set_but
            // 
            this.Set_but.Location = new System.Drawing.Point(494, 259);
            this.Set_but.Name = "Set_but";
            this.Set_but.Size = new System.Drawing.Size(75, 23);
            this.Set_but.TabIndex = 9;
            this.Set_but.Text = "Sign up";
            this.Set_but.UseVisualStyleBackColor = true;
            this.Set_but.Click += new System.EventHandler(this.Set_but_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(482, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "If you want to reset existing credentials, place old username and password and pr" +
    "ess the reset button";
            // 
            // reset_label
            // 
            this.reset_label.Location = new System.Drawing.Point(0, 0);
            this.reset_label.Name = "reset_label";
            this.reset_label.Size = new System.Drawing.Size(100, 23);
            this.reset_label.TabIndex = 0;
            // 
            // reset_lbl
            // 
            this.reset_lbl.AutoSize = true;
            this.reset_lbl.Location = new System.Drawing.Point(235, 341);
            this.reset_lbl.Name = "reset_lbl";
            this.reset_lbl.Size = new System.Drawing.Size(302, 13);
            this.reset_lbl.TabIndex = 11;
            this.reset_lbl.Text = "Now enter your desired username and password and press Set";
            // 
            // Reset2_but
            // 
            this.Reset2_but.Location = new System.Drawing.Point(355, 357);
            this.Reset2_but.Name = "Reset2_but";
            this.Reset2_but.Size = new System.Drawing.Size(75, 23);
            this.Reset2_but.TabIndex = 12;
            this.Reset2_but.Text = "Reset";
            this.Reset2_but.UseVisualStyleBackColor = true;
            this.Reset2_but.Click += new System.EventHandler(this.Reset2_but_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset2_but);
            this.Controls.Add(this.reset_lbl);
            this.Controls.Add(this.reset_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Set_but);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reset_but);
            this.Controls.Add(this.Local_but);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_but);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label Notes;
        private System.Windows.Forms.Button Local_but;
        private System.Windows.Forms.Button Reset_but;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Set_but;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label reset_label;
        private System.Windows.Forms.Label reset_lbl;
        private System.Windows.Forms.Button Reset2_but;
    }
}