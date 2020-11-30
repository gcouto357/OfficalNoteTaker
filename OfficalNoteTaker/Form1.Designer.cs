namespace OfficalNoteTaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.New_but = new System.Windows.Forms.Button();
            this.Open_but = new System.Windows.Forms.Button();
            this.Save_but = new System.Windows.Forms.Button();
            this.Del_but = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Text";
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(92, 341);
            this.txt_msg.Multiline = true;
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(417, 84);
            this.txt_msg.TabIndex = 3;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(92, 50);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(229, 20);
            this.txt_title.TabIndex = 4;
            this.txt_title.TextChanged += new System.EventHandler(this.Name_title_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(92, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(417, 191);
            this.dataGridView1.TabIndex = 5;
            // 
            // New_but
            // 
            this.New_but.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.New_but.Location = new System.Drawing.Point(23, 12);
            this.New_but.Name = "New_but";
            this.New_but.Size = new System.Drawing.Size(75, 23);
            this.New_but.TabIndex = 6;
            this.New_but.Text = "Open";
            this.New_but.UseVisualStyleBackColor = true;
            this.New_but.Click += new System.EventHandler(this.New_but_Click);
            // 
            // Open_but
            // 
            this.Open_but.Location = new System.Drawing.Point(154, 12);
            this.Open_but.Name = "Open_but";
            this.Open_but.Size = new System.Drawing.Size(75, 23);
            this.Open_but.TabIndex = 7;
            this.Open_but.Text = "Update";
            this.Open_but.UseVisualStyleBackColor = true;
            this.Open_but.Click += new System.EventHandler(this.Open_but_Click);
            // 
            // Save_but
            // 
            this.Save_but.Location = new System.Drawing.Point(289, 12);
            this.Save_but.Name = "Save_but";
            this.Save_but.Size = new System.Drawing.Size(75, 23);
            this.Save_but.TabIndex = 8;
            this.Save_but.Text = "Save";
            this.Save_but.UseVisualStyleBackColor = true;
            this.Save_but.Click += new System.EventHandler(this.Save_but_Click);
            // 
            // Del_but
            // 
            this.Del_but.Location = new System.Drawing.Point(420, 12);
            this.Del_but.Name = "Del_but";
            this.Del_but.Size = new System.Drawing.Size(75, 23);
            this.Del_but.TabIndex = 9;
            this.Del_but.Text = "Delete";
            this.Del_but.UseVisualStyleBackColor = true;
            this.Del_but.Click += new System.EventHandler(this.Del_but_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(501, 15);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(100, 20);
            this.txt_Id.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Enter Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.Del_but);
            this.Controls.Add(this.Save_but);
            this.Controls.Add(this.Open_but);
            this.Controls.Add(this.New_but);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button New_but;
        private System.Windows.Forms.Button Open_but;
        private System.Windows.Forms.Button Save_but;
        private System.Windows.Forms.Button Del_but;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label4;
    }
}

