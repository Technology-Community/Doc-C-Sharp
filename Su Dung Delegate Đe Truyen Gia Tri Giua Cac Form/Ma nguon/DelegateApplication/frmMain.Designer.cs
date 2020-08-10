namespace DelegateApplication
{
    partial class frmMain
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
            this.txtFirstValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetValue2 = new System.Windows.Forms.Button();
            this.btnGetValue1 = new System.Windows.Forms.Button();
            this.txtSecondValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá Trị 1";
            // 
            // txtFirstValue
            // 
            this.txtFirstValue.Location = new System.Drawing.Point(73, 42);
            this.txtFirstValue.Name = "txtFirstValue";
            this.txtFirstValue.Size = new System.Drawing.Size(100, 20);
            this.txtFirstValue.TabIndex = 1;
            
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGetValue2);
            this.groupBox1.Controls.Add(this.btnGetValue1);
            this.groupBox1.Controls.Add(this.txtSecondValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Zensoft";
            // 
            // btnGetValue2
            // 
            this.btnGetValue2.Location = new System.Drawing.Point(179, 77);
            this.btnGetValue2.Name = "btnGetValue2";
            this.btnGetValue2.Size = new System.Drawing.Size(27, 20);
            this.btnGetValue2.TabIndex = 4;
            this.btnGetValue2.Text = "...";
            this.btnGetValue2.UseVisualStyleBackColor = true;
            this.btnGetValue2.Click += new System.EventHandler(this.btnGetValue2_Click);
            // 
            // btnGetValue1
            // 
            this.btnGetValue1.Location = new System.Drawing.Point(179, 43);
            this.btnGetValue1.Name = "btnGetValue1";
            this.btnGetValue1.Size = new System.Drawing.Size(27, 19);
            this.btnGetValue1.TabIndex = 4;
            this.btnGetValue1.Text = "...";
            this.btnGetValue1.UseVisualStyleBackColor = true;
            this.btnGetValue1.Click += new System.EventHandler(this.btnGetValue1_Click);
            // 
            // txtSecondValue
            // 
            this.txtSecondValue.Location = new System.Drawing.Point(73, 77);
            this.txtSecondValue.Name = "txtSecondValue";
            this.txtSecondValue.Size = new System.Drawing.Size(100, 20);
            this.txtSecondValue.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá Trị 2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 268);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.Text = "http://Zensoft.vn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetValue2;
        private System.Windows.Forms.Button btnGetValue1;
        private System.Windows.Forms.TextBox txtSecondValue;
        private System.Windows.Forms.Label label2;
    }
}