namespace SqlConnectionStringBuilder
{
    partial class mainFrm
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
            this.btnGetStr = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.propGrid4String = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // btnGetStr
            // 
            this.btnGetStr.Location = new System.Drawing.Point(24, 32);
            this.btnGetStr.Name = "btnGetStr";
            this.btnGetStr.Size = new System.Drawing.Size(160, 23);
            this.btnGetStr.TabIndex = 0;
            this.btnGetStr.Text = "Get ConnectionString";
            this.btnGetStr.UseVisualStyleBackColor = true;
            this.btnGetStr.Click += new System.EventHandler(this.btnGetStr_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(24, 76);
            this.txtStr.Multiline = true;
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(206, 305);
            this.txtStr.TabIndex = 1;
            // 
            // propGrid4String
            // 
            this.propGrid4String.Location = new System.Drawing.Point(283, 32);
            this.propGrid4String.Name = "propGrid4String";
            this.propGrid4String.Size = new System.Drawing.Size(330, 437);
            this.propGrid4String.TabIndex = 2;
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 508);
            this.Controls.Add(this.propGrid4String);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.btnGetStr);
            this.Name = "mainFrm";
            this.Text = "Connection String Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetStr;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.PropertyGrid propGrid4String;
    }
}

