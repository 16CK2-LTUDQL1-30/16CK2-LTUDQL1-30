namespace GUI
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
            this.btn2HuyVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb2Sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbViTriGhe2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn2HuyVe
            // 
            this.btn2HuyVe.Location = new System.Drawing.Point(423, 100);
            this.btn2HuyVe.Name = "btn2HuyVe";
            this.btn2HuyVe.Size = new System.Drawing.Size(75, 64);
            this.btn2HuyVe.TabIndex = 0;
            this.btn2HuyVe.Text = "Hủy vé";
            this.btn2HuyVe.UseVisualStyleBackColor = true;
            this.btn2HuyVe.Click += new System.EventHandler(this.btn2HuyVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số điện thoại:";
            // 
            // tb2Sdt
            // 
            this.tb2Sdt.Location = new System.Drawing.Point(193, 139);
            this.tb2Sdt.Name = "tb2Sdt";
            this.tb2Sdt.Size = new System.Drawing.Size(213, 22);
            this.tb2Sdt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vị trí ghế:";
            // 
            // tbViTriGhe2
            // 
            this.tbViTriGhe2.Location = new System.Drawing.Point(193, 105);
            this.tbViTriGhe2.Name = "tbViTriGhe2";
            this.tbViTriGhe2.Size = new System.Drawing.Size(213, 22);
            this.tbViTriGhe2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 403);
            this.Controls.Add(this.tbViTriGhe2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb2Sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn2HuyVe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2HuyVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb2Sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbViTriGhe2;
    }
}