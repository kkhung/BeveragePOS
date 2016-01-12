namespace BeveragePOS
{
    partial class Main
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.flpCatelogiesRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.flpBeveragesRegion = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlChoosableSugarRegion = new System.Windows.Forms.Panel();
            this.btnNoSugar = new System.Windows.Forms.Button();
            this.btnQuarterSugar = new System.Windows.Forms.Button();
            this.btnHalfSugar = new System.Windows.Forms.Button();
            this.btnLessSugar = new System.Windows.Forms.Button();
            this.btnFullSugar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWarm = new System.Windows.Forms.Button();
            this.btnNoIce = new System.Windows.Forms.Button();
            this.btnLittleIce = new System.Windows.Forms.Button();
            this.btnLessIce = new System.Windows.Forms.Button();
            this.btnMoreIce = new System.Windows.Forms.Button();
            this.pnlChoosableIceRegion = new System.Windows.Forms.Panel();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnRingUp = new System.Windows.Forms.Button();
            this.lblTxtTotal = new System.Windows.Forms.Label();
            this.lblNumTotal = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.mouseClickTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTxtOrderNumber = new System.Windows.Forms.Label();
            this.lblNumOrderNumber = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlChoosableSugarRegion.SuspendLayout();
            this.pnlChoosableIceRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // flpCatelogiesRegion
            // 
            this.flpCatelogiesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCatelogiesRegion.AutoScroll = true;
            this.flpCatelogiesRegion.Location = new System.Drawing.Point(450, 50);
            this.flpCatelogiesRegion.Name = "flpCatelogiesRegion";
            this.flpCatelogiesRegion.Size = new System.Drawing.Size(550, 150);
            this.flpCatelogiesRegion.TabIndex = 0;
            // 
            // flpBeveragesRegion
            // 
            this.flpBeveragesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBeveragesRegion.AutoScroll = true;
            this.flpBeveragesRegion.Location = new System.Drawing.Point(450, 200);
            this.flpBeveragesRegion.Name = "flpBeveragesRegion";
            this.flpBeveragesRegion.Size = new System.Drawing.Size(550, 500);
            this.flpBeveragesRegion.TabIndex = 0;
            // 
            // pnlChoosableSugarRegion
            // 
            this.pnlChoosableSugarRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChoosableSugarRegion.Controls.Add(this.btnNoSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.btnQuarterSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.btnHalfSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.btnLessSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.btnFullSugar);
            this.pnlChoosableSugarRegion.Location = new System.Drawing.Point(0, 475);
            this.pnlChoosableSugarRegion.Name = "pnlChoosableSugarRegion";
            this.pnlChoosableSugarRegion.Size = new System.Drawing.Size(375, 75);
            this.pnlChoosableSugarRegion.TabIndex = 0;
            // 
            // btnNoSugar
            // 
            this.btnNoSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnNoSugar.Location = new System.Drawing.Point(300, 0);
            this.btnNoSugar.Name = "btnNoSugar";
            this.btnNoSugar.Size = new System.Drawing.Size(75, 75);
            this.btnNoSugar.TabIndex = 4;
            this.btnNoSugar.Text = "無糖";
            this.btnNoSugar.UseVisualStyleBackColor = false;
            this.btnNoSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnQuarterSugar
            // 
            this.btnQuarterSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnQuarterSugar.Location = new System.Drawing.Point(225, 0);
            this.btnQuarterSugar.Name = "btnQuarterSugar";
            this.btnQuarterSugar.Size = new System.Drawing.Size(75, 75);
            this.btnQuarterSugar.TabIndex = 3;
            this.btnQuarterSugar.Text = "微糖";
            this.btnQuarterSugar.UseVisualStyleBackColor = false;
            this.btnQuarterSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnHalfSugar
            // 
            this.btnHalfSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnHalfSugar.Location = new System.Drawing.Point(150, 0);
            this.btnHalfSugar.Name = "btnHalfSugar";
            this.btnHalfSugar.Size = new System.Drawing.Size(75, 75);
            this.btnHalfSugar.TabIndex = 2;
            this.btnHalfSugar.Text = "半糖";
            this.btnHalfSugar.UseVisualStyleBackColor = false;
            this.btnHalfSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnLessSugar
            // 
            this.btnLessSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnLessSugar.Location = new System.Drawing.Point(75, 0);
            this.btnLessSugar.Name = "btnLessSugar";
            this.btnLessSugar.Size = new System.Drawing.Size(75, 75);
            this.btnLessSugar.TabIndex = 1;
            this.btnLessSugar.Text = "少糖";
            this.btnLessSugar.UseVisualStyleBackColor = false;
            this.btnLessSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnFullSugar
            // 
            this.btnFullSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnFullSugar.Location = new System.Drawing.Point(0, 0);
            this.btnFullSugar.Name = "btnFullSugar";
            this.btnFullSugar.Size = new System.Drawing.Size(75, 75);
            this.btnFullSugar.TabIndex = 0;
            this.btnFullSugar.Text = "全糖";
            this.btnFullSugar.UseVisualStyleBackColor = false;
            this.btnFullSugar.Click += new System.EventHandler(this.btnSugar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnDelete.Location = new System.Drawing.Point(0, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(450, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnWarm
            // 
            this.btnWarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnWarm.Location = new System.Drawing.Point(300, 0);
            this.btnWarm.Name = "btnWarm";
            this.btnWarm.Size = new System.Drawing.Size(75, 75);
            this.btnWarm.TabIndex = 14;
            this.btnWarm.Text = "常溫";
            this.btnWarm.UseVisualStyleBackColor = false;
            this.btnWarm.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnNoIce
            // 
            this.btnNoIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnNoIce.Location = new System.Drawing.Point(225, 0);
            this.btnNoIce.Name = "btnNoIce";
            this.btnNoIce.Size = new System.Drawing.Size(75, 75);
            this.btnNoIce.TabIndex = 13;
            this.btnNoIce.Text = "去冰";
            this.btnNoIce.UseVisualStyleBackColor = false;
            this.btnNoIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnLittleIce
            // 
            this.btnLittleIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnLittleIce.Location = new System.Drawing.Point(150, 0);
            this.btnLittleIce.Name = "btnLittleIce";
            this.btnLittleIce.Size = new System.Drawing.Size(75, 75);
            this.btnLittleIce.TabIndex = 12;
            this.btnLittleIce.Text = "微冰";
            this.btnLittleIce.UseVisualStyleBackColor = false;
            this.btnLittleIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnLessIce
            // 
            this.btnLessIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnLessIce.Location = new System.Drawing.Point(75, 0);
            this.btnLessIce.Name = "btnLessIce";
            this.btnLessIce.Size = new System.Drawing.Size(75, 75);
            this.btnLessIce.TabIndex = 11;
            this.btnLessIce.Text = "少冰";
            this.btnLessIce.UseVisualStyleBackColor = false;
            this.btnLessIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnMoreIce
            // 
            this.btnMoreIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnMoreIce.Location = new System.Drawing.Point(0, 0);
            this.btnMoreIce.Name = "btnMoreIce";
            this.btnMoreIce.Size = new System.Drawing.Size(75, 75);
            this.btnMoreIce.TabIndex = 10;
            this.btnMoreIce.Text = "正常";
            this.btnMoreIce.UseVisualStyleBackColor = false;
            this.btnMoreIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // pnlChoosableIceRegion
            // 
            this.pnlChoosableIceRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlChoosableIceRegion.Controls.Add(this.btnNoIce);
            this.pnlChoosableIceRegion.Controls.Add(this.btnLittleIce);
            this.pnlChoosableIceRegion.Controls.Add(this.btnWarm);
            this.pnlChoosableIceRegion.Controls.Add(this.btnLessIce);
            this.pnlChoosableIceRegion.Controls.Add(this.btnMoreIce);
            this.pnlChoosableIceRegion.Location = new System.Drawing.Point(0, 550);
            this.pnlChoosableIceRegion.Name = "pnlChoosableIceRegion";
            this.pnlChoosableIceRegion.Size = new System.Drawing.Size(375, 75);
            this.pnlChoosableIceRegion.TabIndex = 0;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AllowUserToResizeColumns = false;
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrderDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderDetail.ColumnHeadersHeight = 50;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvOrderDetail.EnableHeadersVisualStyles = false;
            this.dgvOrderDetail.GridColor = System.Drawing.Color.Black;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 50);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrderDetail.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Empty;
            this.dgvOrderDetail.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrderDetail.RowTemplate.DividerHeight = 1;
            this.dgvOrderDetail.RowTemplate.Height = 50;
            this.dgvOrderDetail.RowTemplate.ReadOnly = true;
            this.dgvOrderDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.ShowCellErrors = false;
            this.dgvOrderDetail.ShowCellToolTips = false;
            this.dgvOrderDetail.ShowEditingIcon = false;
            this.dgvOrderDetail.ShowRowErrors = false;
            this.dgvOrderDetail.Size = new System.Drawing.Size(450, 325);
            this.dgvOrderDetail.TabIndex = 3;
            this.dgvOrderDetail.SelectionChanged += new System.EventHandler(this.dgvOrderDetail_SelectionChanged);
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnLogout.Location = new System.Drawing.Point(375, 625);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 75);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManage
            // 
            this.btnManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnManage.Location = new System.Drawing.Point(225, 625);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(75, 75);
            this.btnManage.TabIndex = 10;
            this.btnManage.Text = "管理";
            this.btnManage.UseVisualStyleBackColor = false;
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnLog.Location = new System.Drawing.Point(300, 625);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 75);
            this.btnLog.TabIndex = 9;
            this.btnLog.Text = "記錄";
            this.btnLog.UseVisualStyleBackColor = false;
            // 
            // btnRingUp
            // 
            this.btnRingUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnRingUp.Location = new System.Drawing.Point(0, 625);
            this.btnRingUp.Name = "btnRingUp";
            this.btnRingUp.Size = new System.Drawing.Size(225, 75);
            this.btnRingUp.TabIndex = 7;
            this.btnRingUp.Text = "結帳";
            this.btnRingUp.UseVisualStyleBackColor = false;
            this.btnRingUp.Click += new System.EventHandler(this.btnRingUp_Click);
            // 
            // lblTxtTotal
            // 
            this.lblTxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTxtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblTxtTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTxtTotal.Location = new System.Drawing.Point(0, 375);
            this.lblTxtTotal.Name = "lblTxtTotal";
            this.lblTxtTotal.Size = new System.Drawing.Size(75, 50);
            this.lblTxtTotal.TabIndex = 12;
            this.lblTxtTotal.Text = "小計︰";
            this.lblTxtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumTotal
            // 
            this.lblNumTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblNumTotal.ForeColor = System.Drawing.Color.Black;
            this.lblNumTotal.Location = new System.Drawing.Point(75, 375);
            this.lblNumTotal.Name = "lblNumTotal";
            this.lblNumTotal.Size = new System.Drawing.Size(300, 50);
            this.lblNumTotal.TabIndex = 13;
            this.lblNumTotal.Text = "0";
            this.lblNumTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDollar
            // 
            this.lblDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDollar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblDollar.ForeColor = System.Drawing.Color.Black;
            this.lblDollar.Location = new System.Drawing.Point(375, 375);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(75, 50);
            this.lblDollar.TabIndex = 14;
            this.lblDollar.Text = "元";
            this.lblDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlus
            // 
            this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnPlus.Location = new System.Drawing.Point(375, 475);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 75);
            this.btnPlus.TabIndex = 15;
            this.btnPlus.Text = "加";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            this.btnPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnPlus_MouseDown);
            this.btnPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnPlus_MouseUp);
            // 
            // btnMinus
            // 
            this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            this.btnMinus.Location = new System.Drawing.Point(375, 550);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 75);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "減";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            this.btnMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMinus_MouseDown);
            this.btnMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMinus_MouseUp);
            // 
            // mouseClickTimer
            // 
            this.mouseClickTimer.Tick += new System.EventHandler(this.mouseClickTimer_Tick);
            // 
            // lblTxtOrderNumber
            // 
            this.lblTxtOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblTxtOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.lblTxtOrderNumber.Location = new System.Drawing.Point(0, 0);
            this.lblTxtOrderNumber.Name = "lblTxtOrderNumber";
            this.lblTxtOrderNumber.Size = new System.Drawing.Size(75, 50);
            this.lblTxtOrderNumber.TabIndex = 16;
            this.lblTxtOrderNumber.Text = "單號︰";
            this.lblTxtOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumOrderNumber
            // 
            this.lblNumOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblNumOrderNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumOrderNumber.Location = new System.Drawing.Point(75, 0);
            this.lblNumOrderNumber.Name = "lblNumOrderNumber";
            this.lblNumOrderNumber.Size = new System.Drawing.Size(100, 50);
            this.lblNumOrderNumber.TabIndex = 16;
            this.lblNumOrderNumber.Text = "0";
            this.lblNumOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(450, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(400, 50);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "時間︰";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNumOrderNumber);
            this.Controls.Add(this.lblTxtOrderNumber);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblNumTotal);
            this.Controls.Add(this.lblTxtTotal);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnRingUp);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.pnlChoosableIceRegion);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.flpCatelogiesRegion);
            this.Controls.Add(this.flpBeveragesRegion);
            this.Controls.Add(this.pnlChoosableSugarRegion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Main";
            this.Text = "飲料訂購系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlChoosableSugarRegion.ResumeLayout(false);
            this.pnlChoosableIceRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpCatelogiesRegion;
        private System.Windows.Forms.FlowLayoutPanel flpBeveragesRegion;
        private System.Windows.Forms.Panel pnlChoosableSugarRegion;
        private System.Windows.Forms.Button btnLessSugar;
        private System.Windows.Forms.Button btnFullSugar;
        private System.Windows.Forms.Button btnNoSugar;
        private System.Windows.Forms.Button btnQuarterSugar;
        private System.Windows.Forms.Button btnHalfSugar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWarm;
        private System.Windows.Forms.Button btnNoIce;
        private System.Windows.Forms.Button btnLittleIce;
        private System.Windows.Forms.Button btnLessIce;
        private System.Windows.Forms.Button btnMoreIce;
        private System.Windows.Forms.Panel pnlChoosableIceRegion;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnRingUp;
        private System.Windows.Forms.Label lblTxtTotal;
        private System.Windows.Forms.Label lblNumTotal;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Timer mouseClickTimer;
        private System.Windows.Forms.Label lblTxtOrderNumber;
        private System.Windows.Forms.Label lblNumOrderNumber;
        private System.Windows.Forms.Label lblTime;
    }
}

