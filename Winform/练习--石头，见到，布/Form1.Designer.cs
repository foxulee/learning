namespace 练习__石头_见到_布
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStone = new System.Windows.Forms.Button();
            this.btnScissor = new System.Windows.Forms.Button();
            this.btnCloth = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家出:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "电脑出:";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(103, 60);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(0, 13);
            this.lblPlayer.TabIndex = 2;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(418, 60);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(0, 13);
            this.lblComputer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "裁判:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(268, 136);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 5;
            // 
            // btnStone
            // 
            this.btnStone.Location = new System.Drawing.Point(130, 187);
            this.btnStone.Name = "btnStone";
            this.btnStone.Size = new System.Drawing.Size(75, 23);
            this.btnStone.TabIndex = 6;
            this.btnStone.Text = "石头";
            this.btnStone.UseVisualStyleBackColor = true;
            this.btnStone.Click += new System.EventHandler(this.btnStone_Click);
            // 
            // btnScissor
            // 
            this.btnScissor.Location = new System.Drawing.Point(246, 187);
            this.btnScissor.Name = "btnScissor";
            this.btnScissor.Size = new System.Drawing.Size(75, 23);
            this.btnScissor.TabIndex = 7;
            this.btnScissor.Text = "剪刀";
            this.btnScissor.UseVisualStyleBackColor = true;
            this.btnScissor.Click += new System.EventHandler(this.btnScissor_Click);
            // 
            // btnCloth
            // 
            this.btnCloth.Location = new System.Drawing.Point(363, 187);
            this.btnCloth.Name = "btnCloth";
            this.btnCloth.Size = new System.Drawing.Size(75, 23);
            this.btnCloth.TabIndex = 8;
            this.btnCloth.Text = "布";
            this.btnCloth.UseVisualStyleBackColor = true;
            this.btnCloth.Click += new System.EventHandler(this.btnCloth_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(196, 22);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(139, 13);
            this.lblStart.TabIndex = 9;
            this.lblStart.Text = "游戏开始，请玩家选择！";
            this.lblStart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 262);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnCloth);
            this.Controls.Add(this.btnScissor);
            this.Controls.Add(this.btnStone);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStone;
        private System.Windows.Forms.Button btnScissor;
        private System.Windows.Forms.Button btnCloth;
        private System.Windows.Forms.Label lblStart;
    }
}

