﻿namespace WinformPoject0527
{
    partial class SellerLogin
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonregister = new System.Windows.Forms.Button();
            this.textBoxPw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxaccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.buttonexit = new System.Windows.Forms.Button();
            this.buttonDemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 42);
            this.label4.TabIndex = 19;
            this.label4.Text = "我是賣家";
            // 
            // buttonregister
            // 
            this.buttonregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonregister.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonregister.Location = new System.Drawing.Point(581, 41);
            this.buttonregister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonregister.Name = "buttonregister";
            this.buttonregister.Size = new System.Drawing.Size(107, 48);
            this.buttonregister.TabIndex = 20;
            this.buttonregister.Text = "註冊";
            this.buttonregister.UseVisualStyleBackColor = true;
            this.buttonregister.Click += new System.EventHandler(this.buttonregister_Click);
            // 
            // textBoxPw
            // 
            this.textBoxPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPw.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxPw.Location = new System.Drawing.Point(283, 188);
            this.textBoxPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPw.Name = "textBoxPw";
            this.textBoxPw.PasswordChar = '*';
            this.textBoxPw.Size = new System.Drawing.Size(208, 34);
            this.textBoxPw.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(216, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "密碼：";
            // 
            // textBoxaccount
            // 
            this.textBoxaccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxaccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxaccount.Location = new System.Drawing.Point(283, 133);
            this.textBoxaccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxaccount.Name = "textBoxaccount";
            this.textBoxaccount.Size = new System.Drawing.Size(208, 34);
            this.textBoxaccount.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(429, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "還沒有會員嗎：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(216, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "帳號：";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonlogin.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonlogin.Location = new System.Drawing.Point(384, 275);
            this.buttonlogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(107, 48);
            this.buttonlogin.TabIndex = 21;
            this.buttonlogin.Text = "登入";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // buttonexit
            // 
            this.buttonexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonexit.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonexit.Location = new System.Drawing.Point(221, 275);
            this.buttonexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(107, 48);
            this.buttonexit.TabIndex = 22;
            this.buttonexit.Text = "離開";
            this.buttonexit.UseVisualStyleBackColor = true;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // buttonDemo
            // 
            this.buttonDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDemo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonDemo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonDemo.Location = new System.Drawing.Point(545, 139);
            this.buttonDemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(72, 34);
            this.buttonDemo.TabIndex = 23;
            this.buttonDemo.Text = "Demo";
            this.buttonDemo.UseVisualStyleBackColor = false;
            this.buttonDemo.Click += new System.EventHandler(this.buttonDemo_Click);
            // 
            // SellerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonregister);
            this.Controls.Add(this.textBoxPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxaccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.buttonDemo);
            this.Controls.Add(this.label4);
            this.Name = "SellerLogin";
            this.Text = "SellerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonregister;
        private System.Windows.Forms.TextBox textBoxPw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxaccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Button buttonDemo;
    }
}