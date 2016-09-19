namespace Do_you_love_me
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
            this.btnLove = new System.Windows.Forms.Button();
            this.btnNotLove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLove
            // 
            this.btnLove.Location = new System.Drawing.Point(51, 67);
            this.btnLove.Name = "btnLove";
            this.btnLove.Size = new System.Drawing.Size(75, 23);
            this.btnLove.TabIndex = 0;
            this.btnLove.Text = "爱";
            this.btnLove.UseVisualStyleBackColor = true;
            this.btnLove.Click += new System.EventHandler(this.btnLove_Click);
            // 
            // btnNotLove
            // 
            this.btnNotLove.Location = new System.Drawing.Point(181, 67);
            this.btnNotLove.Name = "btnNotLove";
            this.btnNotLove.Size = new System.Drawing.Size(75, 23);
            this.btnNotLove.TabIndex = 1;
            this.btnNotLove.Text = "不爱";
            this.btnNotLove.UseVisualStyleBackColor = true;
            this.btnNotLove.MouseEnter += new System.EventHandler(this.btnNotLove_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnNotLove);
            this.Controls.Add(this.btnLove);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLove;
        private System.Windows.Forms.Button btnNotLove;
    }
}

