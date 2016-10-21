namespace SqlDataAdapter_____WinformDataGridView
{
    partial class SqlCommandBuilderCRUD_Form
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
            this.dgvUserInfoCRUD = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfoCRUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUserInfoCRUD
            // 
            this.dgvUserInfoCRUD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserInfoCRUD.Location = new System.Drawing.Point(48, 50);
            this.dgvUserInfoCRUD.Name = "dgvUserInfoCRUD";
            this.dgvUserInfoCRUD.Size = new System.Drawing.Size(448, 229);
            this.dgvUserInfoCRUD.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SqlCommandBuilderCRUD_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 355);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvUserInfoCRUD);
            this.Name = "SqlCommandBuilderCRUD_Form";
            this.Text = "SqlCommandBuilderCRUD";
            this.Load += new System.EventHandler(this.SqlCommandBuilderCRUD_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfoCRUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInfoCRUD;
        private System.Windows.Forms.Button btnSave;
    }
}