
namespace B3_Selenium_Chi_35
{
    partial class Selenium_Chi_35
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
            this.btn1_Chi_35 = new System.Windows.Forms.Button();
            this.txtUrl_Chi_35 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1_Chi_35
            // 
            this.btn1_Chi_35.Location = new System.Drawing.Point(306, 232);
            this.btn1_Chi_35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn1_Chi_35.Name = "btn1_Chi_35";
            this.btn1_Chi_35.Size = new System.Drawing.Size(152, 45);
            this.btn1_Chi_35.TabIndex = 0;
            this.btn1_Chi_35.Text = "Open Browse";
            this.btn1_Chi_35.UseVisualStyleBackColor = true;
            this.btn1_Chi_35.Click += new System.EventHandler(this.btn1_Chi_35_Click);
            // 
            // txtUrl_Chi_35
            // 
            this.txtUrl_Chi_35.Location = new System.Drawing.Point(306, 91);
            this.txtUrl_Chi_35.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUrl_Chi_35.Name = "txtUrl_Chi_35";
            this.txtUrl_Chi_35.Size = new System.Drawing.Size(148, 26);
            this.txtUrl_Chi_35.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "url:";
            // 
            // Selenium_Chi_35
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl_Chi_35);
            this.Controls.Add(this.btn1_Chi_35);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Selenium_Chi_35";
            this.Text = "Selenium_Chi_35";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1_Chi_35;
        private System.Windows.Forms.TextBox txtUrl_Chi_35;
        private System.Windows.Forms.Label label1;
    }
}

