namespace SqlDataAdapter_____WinformDataGridView
{
    partial class Mainfrm
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
            this.dgvSelectedUserInfo = new System.Windows.Forms.DataGridView();
            this.dgvAllUserInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelectedUserInfo
            // 
            this.dgvSelectedUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedUserInfo.Location = new System.Drawing.Point(102, 264);
            this.dgvSelectedUserInfo.Name = "dgvSelectedUserInfo";
            this.dgvSelectedUserInfo.Size = new System.Drawing.Size(442, 150);
            this.dgvSelectedUserInfo.TabIndex = 1;
            // 
            // dgvAllUserInfo
            // 
            this.dgvAllUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllUserInfo.Location = new System.Drawing.Point(102, 83);
            this.dgvAllUserInfo.Name = "dgvAllUserInfo";
            this.dgvAllUserInfo.Size = new System.Drawing.Size(442, 150);
            this.dgvAllUserInfo.TabIndex = 2;
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 471);
            this.Controls.Add(this.dgvAllUserInfo);
            this.Controls.Add(this.dgvSelectedUserInfo);
            this.Name = "Mainfrm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Mainfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUserInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSelectedUserInfo;
        private System.Windows.Forms.DataGridView dgvAllUserInfo;
    }
}

