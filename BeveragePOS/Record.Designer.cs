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
            this.dtpSystemLogBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpSystemLogEnd = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSystemLogBegin = new System.Windows.Forms.Label();
            this.lbSystemLog = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbOrderMaster = new System.Windows.Forms.ListBox();
            this.dtpTradeLogEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTradeLogBegin = new System.Windows.Forms.DateTimePicker();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSystemLogBegin
            // 
            this.dtpSystemLogBegin.Location = new System.Drawing.Point(194, 21);
            this.dtpSystemLogBegin.Name = "dtpSystemLogBegin";
            this.dtpSystemLogBegin.Size = new System.Drawing.Size(200, 33);
            this.dtpSystemLogBegin.TabIndex = 0;
            this.dtpSystemLogBegin.ValueChanged += new System.EventHandler(this.dtpSystemLogBegin_ValueChanged);
            // 
            // dtpSystemLogEnd
            // 
            this.dtpSystemLogEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpSystemLogEnd.CalendarTitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dtpSystemLogEnd.Location = new System.Drawing.Point(426, 21);
            this.dtpSystemLogEnd.Name = "dtpSystemLogEnd";
            this.dtpSystemLogEnd.Size = new System.Drawing.Size(200, 33);
            this.dtpSystemLogEnd.TabIndex = 0;
            this.dtpSystemLogEnd.ValueChanged += new System.EventHandler(this.dtpSystemLogEnd_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSystemLogBegin);
            this.panel1.Controls.Add(this.lbSystemLog);
            this.panel1.Controls.Add(this.dtpSystemLogEnd);
            this.panel1.Controls.Add(this.dtpSystemLogBegin);
            this.panel1.Location = new System.Drawing.Point(70, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 182);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "至";
            // 
            // lblSystemLogBegin
            // 
            this.lblSystemLogBegin.AutoSize = true;
            this.lblSystemLogBegin.Location = new System.Drawing.Point(162, 27);
            this.lblSystemLogBegin.Name = "lblSystemLogBegin";
            this.lblSystemLogBegin.Size = new System.Drawing.Size(32, 21);
            this.lblSystemLogBegin.TabIndex = 2;
            this.lblSystemLogBegin.Text = "從";
            // 
            // lbSystemLog
            // 
            this.lbSystemLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSystemLog.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSystemLog.FormattingEnabled = true;
            this.lbSystemLog.ItemHeight = 19;
            this.lbSystemLog.Location = new System.Drawing.Point(26, 64);
            this.lbSystemLog.Name = "lbSystemLog";
            this.lbSystemLog.Size = new System.Drawing.Size(600, 97);
            this.lbSystemLog.TabIndex = 1;
            this.lbSystemLog.UseTabStops = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbOrderMaster);
            this.panel2.Controls.Add(this.dtpTradeLogEnd);
            this.panel2.Controls.Add(this.dtpTradeLogBegin);
            this.panel2.Location = new System.Drawing.Point(70, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 260);
            this.panel2.TabIndex = 2;
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
            this.btnReturn.Size = new System.Drawing.Size(60, 30);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "至";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "從";
            // 
            // lbOrderMaster
            // 
            this.lbOrderMaster.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOrderMaster.FormattingEnabled = true;
            this.lbOrderMaster.ItemHeight = 19;
            this.lbOrderMaster.Location = new System.Drawing.Point(26, 64);
            this.lbOrderMaster.Name = "lbOrderMaster";
            this.lbOrderMaster.Size = new System.Drawing.Size(600, 175);
            this.lbOrderMaster.TabIndex = 1;
            this.lbOrderMaster.DoubleClick += new System.EventHandler(this.lbOrderMaster_DoubleClick);
            // 
            // dtpTradeLogEnd
            // 
            this.dtpTradeLogEnd.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpTradeLogEnd.CalendarTitleForeColor = System.Drawing.Color.BlanchedAlmond;
            this.dtpTradeLogEnd.Location = new System.Drawing.Point(426, 21);
            this.dtpTradeLogEnd.Name = "dtpTradeLogEnd";
            this.dtpTradeLogEnd.Size = new System.Drawing.Size(200, 33);
            this.dtpTradeLogEnd.TabIndex = 0;
            this.dtpTradeLogEnd.ValueChanged += new System.EventHandler(this.dtpTradeLogEnd_ValueChanged);
            // 
            // dtpTradeLogBegin
            // 
            this.dtpTradeLogBegin.Location = new System.Drawing.Point(194, 21);
            this.dtpTradeLogBegin.Name = "dtpTradeLogBegin";
            this.dtpTradeLogBegin.Size = new System.Drawing.Size(200, 33);
            this.dtpTradeLogBegin.TabIndex = 0;
            this.dtpTradeLogBegin.ValueChanged += new System.EventHandler(this.dtpTradeLogBegin_ValueChanged);
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
            this.btnExit.TabIndex = 12;
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
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSystemLogBegin;
        private System.Windows.Forms.DateTimePicker dtpSystemLogEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpTradeLogEnd;
        private System.Windows.Forms.DateTimePicker dtpTradeLogBegin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lbOrderMaster;
        private System.Windows.Forms.Label lblSystemLogBegin;
        private System.Windows.Forms.ListBox lbSystemLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;

    }
}