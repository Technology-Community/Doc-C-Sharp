namespace Bai2_UngdungB
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
            this.btngui = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngia TV";
            // 
            // btngui
            // 
            this.btngui.Location = new System.Drawing.Point(409, 42);
            this.btngui.Name = "btngui";
            this.btngui.Size = new System.Drawing.Size(75, 23);
            this.btngui.TabIndex = 1;
            this.btngui.Text = "Gui di";
            this.btngui.UseVisualStyleBackColor = true;
            this.btngui.Click += new System.EventHandler(this.btngui_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tieng Anh";
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(137, 39);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(243, 20);
            this.txtTA.TabIndex = 3;
            // 
            // txtTV
            // 
            this.txtTV.Location = new System.Drawing.Point(137, 78);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(243, 20);
            this.txtTV.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 142);
            this.Controls.Add(this.txtTV);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngui);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtTV;
    }
}

