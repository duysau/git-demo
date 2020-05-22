namespace PLC_PC2
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
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.checkQ0_0 = new System.Windows.Forms.CheckBox();
            this.checkQ0_1 = new System.Windows.Forms.CheckBox();
            this.checkQ0_2 = new System.Windows.Forms.CheckBox();
            this.checkQ0_3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(29, 24);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(214, 20);
            this.txtIp.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(278, 24);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(86, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test Connect";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // checkQ0_0
            // 
            this.checkQ0_0.AutoSize = true;
            this.checkQ0_0.Location = new System.Drawing.Point(29, 80);
            this.checkQ0_0.Name = "checkQ0_0";
            this.checkQ0_0.Size = new System.Drawing.Size(49, 17);
            this.checkQ0_0.TabIndex = 2;
            this.checkQ0_0.Text = "Q0.0";
            this.checkQ0_0.UseVisualStyleBackColor = true;
            this.checkQ0_0.CheckedChanged += new System.EventHandler(this.checkQ0_0_CheckedChanged);
            // 
            // checkQ0_1
            // 
            this.checkQ0_1.AutoSize = true;
            this.checkQ0_1.Location = new System.Drawing.Point(29, 120);
            this.checkQ0_1.Name = "checkQ0_1";
            this.checkQ0_1.Size = new System.Drawing.Size(49, 17);
            this.checkQ0_1.TabIndex = 2;
            this.checkQ0_1.Text = "Q0.1";
            this.checkQ0_1.UseVisualStyleBackColor = true;
            this.checkQ0_1.CheckedChanged += new System.EventHandler(this.checkQ0_0_CheckedChanged);
            // 
            // checkQ0_2
            // 
            this.checkQ0_2.AutoSize = true;
            this.checkQ0_2.Location = new System.Drawing.Point(29, 157);
            this.checkQ0_2.Name = "checkQ0_2";
            this.checkQ0_2.Size = new System.Drawing.Size(49, 17);
            this.checkQ0_2.TabIndex = 2;
            this.checkQ0_2.Text = "Q0.2";
            this.checkQ0_2.UseVisualStyleBackColor = true;
            this.checkQ0_2.CheckedChanged += new System.EventHandler(this.checkQ0_0_CheckedChanged);
            // 
            // checkQ0_3
            // 
            this.checkQ0_3.AutoSize = true;
            this.checkQ0_3.Location = new System.Drawing.Point(29, 193);
            this.checkQ0_3.Name = "checkQ0_3";
            this.checkQ0_3.Size = new System.Drawing.Size(49, 17);
            this.checkQ0_3.TabIndex = 2;
            this.checkQ0_3.Text = "Q0.3";
            this.checkQ0_3.UseVisualStyleBackColor = true;
            this.checkQ0_3.CheckedChanged += new System.EventHandler(this.checkQ0_0_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 252);
            this.Controls.Add(this.checkQ0_3);
            this.Controls.Add(this.checkQ0_2);
            this.Controls.Add(this.checkQ0_1);
            this.Controls.Add(this.checkQ0_0);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.CheckBox checkQ0_0;
        private System.Windows.Forms.CheckBox checkQ0_1;
        private System.Windows.Forms.CheckBox checkQ0_2;
        private System.Windows.Forms.CheckBox checkQ0_3;
    }
}

