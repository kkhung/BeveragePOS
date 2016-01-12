namespace BeveragePOS
{
    partial class Login
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(30, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(240, 30);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "訊息";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Controls.Add(this.lblEmployeeID);
            this.pnlLogin.Controls.Add(this.txtEmployeeID);
            this.pnlLogin.Controls.Add(this.lblEmployeePassword);
            this.pnlLogin.Controls.Add(this.txtEmployeePassword);
            this.pnlLogin.Location = new System.Drawing.Point(30, 75);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(240, 125);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(20, 26);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(54, 21);
            this.lblEmployeeID.TabIndex = 0;
            this.lblEmployeeID.Text = "編號";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BackColor = System.Drawing.Color.White;
            this.txtEmployeeID.Location = new System.Drawing.Point(74, 20);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(146, 33);
            this.txtEmployeeID.TabIndex = 1;
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Location = new System.Drawing.Point(20, 78);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(54, 21);
            this.lblEmployeePassword.TabIndex = 0;
            this.lblEmployeePassword.Text = "密碼";
            this.lblEmployeePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.BackColor = System.Drawing.Color.White;
            this.txtEmployeePassword.Location = new System.Drawing.Point(74, 72);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '*';
            this.txtEmployeePassword.Size = new System.Drawing.Size(146, 33);
            this.txtEmployeePassword.TabIndex = 2;
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnAccept.Location = new System.Drawing.Point(60, 220);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 50);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "確定";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(165, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 50);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.pnlLogin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}