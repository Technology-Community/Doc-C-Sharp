namespace Bai2_UngdungA
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
            this.btnGuilai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuilai
            // 
            this.btnGuilai.Location = new System.Drawing.Point(330, 36);
            this.btnGuilai.Name = "btnGuilai";
            this.btnGuilai.Size = new System.Drawing.Size(103, 23);
            this.btnGuilai.TabIndex = 0;
            this.btnGuilai.Text = "Gửi Lại nghĩa";
            this.btnGuilai.UseVisualStyleBackColor = true;
            this.btnGuilai.Click += new System.EventHandler(this.btnGuilai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiếng Anh";
            // 
            // txtAnh
            // 
            this.txtAnh.Location = new System.Drawing.Point(94, 36);
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(230, 20);
            this.txtAnh.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 100);
            this.Controls.Add(this.txtAnh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuilai);
            this.Name = "Form1";
            this.Text = "Ung Dung A";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuilai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnh;
    }
}

