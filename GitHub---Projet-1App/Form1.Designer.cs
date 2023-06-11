namespace GitHub___Projet_1App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblButton1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblButton1
            // 
            this.lblButton1.AutoSize = true;
            this.lblButton1.Location = new System.Drawing.Point(12, 19);
            this.lblButton1.Name = "lblButton1";
            this.lblButton1.Size = new System.Drawing.Size(52, 15);
            this.lblButton1.TabIndex = 0;
            this.lblButton1.Text = "Button 1";
            this.lblButton1.Click += new System.EventHandler(this.lblButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblButton1;
    }
}