
namespace TestCallAPI
{
    partial class run
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
            this.lblKey = new System.Windows.Forms.Label();
            this.lblExpired = new System.Windows.Forms.Label();
            this.lblKeyVal = new System.Windows.Forms.Label();
            this.lblExpiredVal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new ns1.SiticoneButton();
            this.SuspendLayout();
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.White;
            this.lblKey.Location = new System.Drawing.Point(59, 74);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(38, 21);
            this.lblKey.TabIndex = 0;
            this.lblKey.Text = "Key:";
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpired.ForeColor = System.Drawing.Color.White;
            this.lblExpired.Location = new System.Drawing.Point(59, 101);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(106, 21);
            this.lblExpired.TabIndex = 0;
            this.lblExpired.Text = "Ngày hết hạn:";
            // 
            // lblKeyVal
            // 
            this.lblKeyVal.AutoSize = true;
            this.lblKeyVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyVal.ForeColor = System.Drawing.Color.White;
            this.lblKeyVal.Location = new System.Drawing.Point(209, 74);
            this.lblKeyVal.Name = "lblKeyVal";
            this.lblKeyVal.Size = new System.Drawing.Size(22, 21);
            this.lblKeyVal.TabIndex = 0;
            this.lblKeyVal.Text = "...";
            // 
            // lblExpiredVal
            // 
            this.lblExpiredVal.AutoSize = true;
            this.lblExpiredVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiredVal.ForeColor = System.Drawing.Color.White;
            this.lblExpiredVal.Location = new System.Drawing.Point(209, 101);
            this.lblExpiredVal.Name = "lblExpiredVal";
            this.lblExpiredVal.Size = new System.Drawing.Size(22, 21);
            this.lblExpiredVal.TabIndex = 0;
            this.lblExpiredVal.Text = "...";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(58, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Ví dụ Fake API - Le Dung - tuihocweb.com";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(92)))), ((int)(((byte)(101)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoveredState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(534, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(191)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(568, 168);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblExpiredVal);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.lblKeyVal);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "run";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblExpired;
        private System.Windows.Forms.Label lblKeyVal;
        private System.Windows.Forms.Label lblExpiredVal;
        private System.Windows.Forms.Label lblTitle;
        private ns1.SiticoneButton btnExit;
    }
}