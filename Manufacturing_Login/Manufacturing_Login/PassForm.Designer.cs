﻿namespace Manufacturing_Login
{
    partial class PassForm
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
            this.CurrentPassLabel = new System.Windows.Forms.Label();
            this.CurrentPassText = new System.Windows.Forms.TextBox();
            this.NewPassTxt = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentPassLabel
            // 
            this.CurrentPassLabel.AutoSize = true;
            this.CurrentPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPassLabel.Location = new System.Drawing.Point(12, 29);
            this.CurrentPassLabel.Name = "CurrentPassLabel";
            this.CurrentPassLabel.Size = new System.Drawing.Size(159, 24);
            this.CurrentPassLabel.TabIndex = 2;
            this.CurrentPassLabel.Text = "Current Password";
            // 
            // CurrentPassText
            // 
            this.CurrentPassText.Location = new System.Drawing.Point(16, 56);
            this.CurrentPassText.Name = "CurrentPassText";
            this.CurrentPassText.Size = new System.Drawing.Size(251, 20);
            this.CurrentPassText.TabIndex = 5;
            // 
            // NewPassTxt
            // 
            this.NewPassTxt.Location = new System.Drawing.Point(19, 134);
            this.NewPassTxt.Name = "NewPassTxt";
            this.NewPassTxt.Size = new System.Drawing.Size(251, 20);
            this.NewPassTxt.TabIndex = 7;
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassLabel.Location = new System.Drawing.Point(15, 107);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(136, 24);
            this.NewPassLabel.TabIndex = 6;
            this.NewPassLabel.Text = "New Password";
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(78, 193);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(122, 23);
            this.ResetBtn.TabIndex = 8;
            this.ResetBtn.Text = "Reset Password";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // PassFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.NewPassTxt);
            this.Controls.Add(this.NewPassLabel);
            this.Controls.Add(this.CurrentPassText);
            this.Controls.Add(this.CurrentPassLabel);
            this.Name = "PassFormcs";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentPassLabel;
        private System.Windows.Forms.TextBox CurrentPassText;
        private System.Windows.Forms.TextBox NewPassTxt;
        private System.Windows.Forms.Label NewPassLabel;
        private System.Windows.Forms.Button ResetBtn;
    }
}