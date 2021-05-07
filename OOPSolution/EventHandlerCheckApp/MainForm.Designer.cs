
namespace EventHandlerCheckApp
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextUserID = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.BitLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // TextUserID
            // 
            this.TextUserID.Location = new System.Drawing.Point(131, 25);
            this.TextUserID.Name = "TextUserID";
            this.TextUserID.Size = new System.Drawing.Size(167, 27);
            this.TextUserID.TabIndex = 2;
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(131, 64);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '●';
            this.TextPassword.Size = new System.Drawing.Size(167, 27);
            this.TextPassword.TabIndex = 3;
            // 
            // BitLogin
            // 
            this.BitLogin.Location = new System.Drawing.Point(315, 25);
            this.BitLogin.Name = "BitLogin";
            this.BitLogin.Size = new System.Drawing.Size(94, 66);
            this.BitLogin.TabIndex = 4;
            this.BitLogin.Text = "로그인";
            this.BitLogin.UseVisualStyleBackColor = true;
            this.BitLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BitLogin.Enter += new System.EventHandler(this.Text);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 116);
            this.Controls.Add(this.BitLogin);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextUserID;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Button BitLogin;
    }
}

