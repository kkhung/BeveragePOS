namespace BeveragePOS
{
    partial class Record
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
            this.pnlSystemLog = new System.Windows.Forms.Panel();
            this.lblSystemLogFrom = new System.Windows.Forms.Label();
            this.dtpSystemLogBegin = new System.Windows.Forms.DateTimePicker();
            this.lblSystemLogTo = new System.Windows.Forms.Label();
            this.dtpSystemLogEnd = new System.Windows.Forms.DateTimePicker();
            this.lstSystemLog = new System.Windows.Forms.ListBox();
            this.pnlTradeLog = new System.Windows.Forms.Panel();
            this.lblTradeLogFrom = new System.Windows.Forms.Label();
            this.dtpTradeLogBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpTradeLogEnd = new System.Windows.Forms.DateTimePicker();
            this.lblTradeLogTo = new System.Windows.Forms.Label();
            this.lstTradeLog = new System.Windows.Forms.ListBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlSystemLog.SuspendLayout();
            this.pnlTradeLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSystemLog
            // 
            this.pnlSystemLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSystemLog.Controls.Add(this.lblSystemLogFrom);
            this.pnlSystemLog.Controls.Add(this.dtpSystemLogBegin);
            this.pnlSystemLog.Controls.Add(this.lblSystemLogTo);
            this.pnlSystemLog.Controls.Add(this.dtpSystemLogEnd);
            this.pnlSystemLog.Controls.Add(this.lstSystemLog);
            this.pnlSystemLog.Location = new System.Drawing.Point(70, 30);
            this.pnlSystemLog.Name = "pnlSystemLog";
            this.pnlSystemLog.Size = new System.Drawing.Size(652, 182);
            this.pnlSystemLog.TabIndex = 0;
            // 
            // lblSystemLogFrom
            // 
            this.lblSystemLogFrom.AutoSize = true;
            this.lblSystemLogFrom.Location = new System.Drawing.Point(162, 27);
            this.lblSystemLogFrom.Name = "lblSystemLogFrom";
            this.lblSystemLogFrom.Size = new System.Drawing.Size(32, 21);
            this.lblSystemLogFrom.TabIndex = 0;
            this.lblSystemLogFrom.Text = "從";
            // 
            // dtpSystemLogBegin
            // 
            this.dtpSystemLogBegin.Location = new System.Drawing.Point(194, 21);
            this.dtpSystemLogBegin.Name = "dtpSystemLogBegin";
            this.dtpSystemLogBegin.Size = new System.Drawing.Size(200, 33);
            this.dtpSystemLogBegin.TabIndex = 0;
            this.dtpSystemLogBegin.TabStop = false;
            this.dtpSystemLogBegin.ValueChanged += new System.EventHandler(this.dtpSystemLog_ValueChanged);
            // 
            // lblSystemLogTo
            // 
            this.lblSystemLogTo.AutoSize = true;
            this.lblSystemLogTo.Location = new System.Drawing.Point(394, 27);
            this.lblSystemLogTo.Name = "lblSystemLogTo";
            this.lblSystemLogTo.Size = new System.Drawing.Size(32, 21);
            this.lblSystemLogTo.TabIndex = 0;
            this.lblSystemLogTo.Text = "至";
            // 
            // dtpSystemLogEnd
            // 
            this.dtpSystemLogEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpSystemLogEnd.CalendarTitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dtpSystemLogEnd.Location = new System.Drawing.Point(426, 21);
            this.dtpSystemLogEnd.Name = "dtpSystemLogEnd";
            this.dtpSystemLogEnd.Size = new System.Drawing.Size(200, 33);
            this.dtpSystemLogEnd.TabIndex = 0;
            this.dtpSystemLogEnd.TabStop = false;
            this.dtpSystemLogEnd.ValueChanged += new System.EventHandler(this.dtpSystemLog_ValueChanged);
            // 
            // lstSystemLog
            // 
            this.lstSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSystemLog.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstSystemLog.FormattingEnabled = true;
            this.lstSystemLog.ItemHeight = 19;
            this.lstSystemLog.Location = new System.Drawing.Point(26, 64);
            this.lstSystemLog.Name = "lstSystemLog";
            this.lstSystemLog.Size = new System.Drawing.Size(600, 97);
            this.lstSystemLog.TabIndex = 1;
            this.lstSystemLog.TabStop = false;
            this.lstSystemLog.UseTabStops = false;
            // 
            // pnlTradeLog
            // 
            this.pnlTradeLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlTradeLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTradeLog.Controls.Add(this.lblTradeLogFrom);
            this.pnlTradeLog.Controls.Add(this.dtpTradeLogBegin);
            this.pnlTradeLog.Controls.Add(this.dtpTradeLogEnd);
            this.pnlTradeLog.Controls.Add(this.lblTradeLogTo);
            this.pnlTradeLog.Controls.Add(this.lstTradeLog);
            this.pnlTradeLog.Controls.Add(this.btnReturn);
            this.pnlTradeLog.Location = new System.Drawing.Point(70, 230);
            this.pnlTradeLog.Name = "pnlTradeLog";
            this.pnlTradeLog.Size = new System.Drawing.Size(652, 260);
            this.pnlTradeLog.TabIndex = 0;
            // 
            // lblTradeLogFrom
            // 
            this.lblTradeLogFrom.AutoSize = true;
            this.lblTradeLogFrom.Location = new System.Drawing.Point(162, 27);
            this.lblTradeLogFrom.Name = "lblTradeLogFrom";
            this.lblTradeLogFrom.Size = new System.Drawing.Size(32, 21);
            this.lblTradeLogFrom.TabIndex = 0;
            this.lblTradeLogFrom.Text = "從";
            // 
            // dtpTradeLogBegin
            // 
            this.dtpTradeLogBegin.Location = new System.Drawing.Point(194, 21);
            this.dtpTradeLogBegin.Name = "dtpTradeLogBegin";
            this.dtpTradeLogBegin.Size = new System.Drawing.Size(200, 33);
            this.dtpTradeLogBegin.TabIndex = 0;
            this.dtpTradeLogBegin.TabStop = false;
            this.dtpTradeLogBegin.ValueChanged += new System.EventHandler(this.dtpTradeLog_ValueChanged);
            // 
            // dtpTradeLogEnd
            // 
            this.dtpTradeLogEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpTradeLogEnd.CalendarTitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dtpTradeLogEnd.Location = new System.Drawing.Point(426, 21);
            this.dtpTradeLogEnd.Name = "dtpTradeLogEnd";
            this.dtpTradeLogEnd.Size = new System.Drawing.Size(200, 33);
            this.dtpTradeLogEnd.TabIndex = 0;
            this.dtpTradeLogEnd.TabStop = false;
            this.dtpTradeLogEnd.ValueChanged += new System.EventHandler(this.dtpTradeLog_ValueChanged);
            // 
            // lblTradeLogTo
            // 
            this.lblTradeLogTo.AutoSize = true;
            this.lblTradeLogTo.Location = new System.Drawing.Point(394, 27);
            this.lblTradeLogTo.Name = "lblTradeLogTo";
            this.lblTradeLogTo.Size = new System.Drawing.Size(32, 21);
            this.lblTradeLogTo.TabIndex = 0;
            this.lblTradeLogTo.Text = "至";
            // 
            // lstTradeLog
            // 
            this.lstTradeLog.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstTradeLog.FormattingEnabled = true;
            this.lstTradeLog.ItemHeight = 19;
            this.lstTradeLog.Location = new System.Drawing.Point(26, 64);
            this.lstTradeLog.Name = "lstTradeLog";
            this.lstTradeLog.Size = new System.Drawing.Size(600, 175);
            this.lstTradeLog.TabIndex = 1;
            this.lstTradeLog.TabStop = false;
            this.lstTradeLog.DoubleClick += new System.EventHandler(this.lstTradeLog_DoubleClick);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReturn.Location = new System.Drawing.Point(26, 21);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 33);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(225, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(350, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSystemLog);
            this.Controls.Add(this.pnlTradeLog);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Record";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "記錄";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Record_Load);
            this.pnlSystemLog.ResumeLayout(false);
            this.pnlSystemLog.PerformLayout();
            this.pnlTradeLog.ResumeLayout(false);
            this.pnlTradeLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSystemLog;
        private System.Windows.Forms.Label lblSystemLogFrom;
        private System.Windows.Forms.DateTimePicker dtpSystemLogBegin;
        private System.Windows.Forms.Label lblSystemLogTo;
        private System.Windows.Forms.DateTimePicker dtpSystemLogEnd;
        private System.Windows.Forms.ListBox lstSystemLog;
        private System.Windows.Forms.Panel pnlTradeLog;
        private System.Windows.Forms.Label lblTradeLogFrom;
        private System.Windows.Forms.DateTimePicker dtpTradeLogBegin;
        private System.Windows.Forms.Label lblTradeLogTo;
        private System.Windows.Forms.DateTimePicker dtpTradeLogEnd;
        private System.Windows.Forms.ListBox lstTradeLog;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
    }
}