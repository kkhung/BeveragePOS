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
            this.rbNoSugar = new System.Windows.Forms.RadioButton();
            this.rbQuarterSugar = new System.Windows.Forms.RadioButton();
            this.rbHalfSugar = new System.Windows.Forms.RadioButton();
            this.rbLessSugar = new System.Windows.Forms.RadioButton();
            this.rbFullSugar = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.rbWarm = new System.Windows.Forms.RadioButton();
            this.rbNoIce = new System.Windows.Forms.RadioButton();
            this.rbLittleIce = new System.Windows.Forms.RadioButton();
            this.rbLessIce = new System.Windows.Forms.RadioButton();
            this.rbMoreIce = new System.Windows.Forms.RadioButton();
            this.pnlChoosableIceRegion = new System.Windows.Forms.Panel();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnRingUp = new System.Windows.Forms.Button();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalContent = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.btnQuantityIncrease = new System.Windows.Forms.Button();
            this.btnQuantityDecrease = new System.Windows.Forms.Button();
            this.mouseClickTimer = new System.Windows.Forms.Timer(this.components);
            this.lblOrderNumberTitle = new System.Windows.Forms.Label();
            this.lblOrderNumberContent = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlOrderRegion = new System.Windows.Forms.Panel();
            this.pnlEmployeeTitle = new System.Windows.Forms.Label();
            this.lblEmployeeContent = new System.Windows.Forms.Label();
            this.pnlControlsRegion = new System.Windows.Forms.Panel();
            this.pnlFavorAndQuantityRegion = new System.Windows.Forms.Panel();
            this.pnlInformationRegion = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlChoosableSugarRegion.SuspendLayout();
            this.pnlChoosableIceRegion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.pnlOrderRegion.SuspendLayout();
            this.pnlControlsRegion.SuspendLayout();
            this.pnlFavorAndQuantityRegion.SuspendLayout();
            this.pnlInformationRegion.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpCatelogiesRegion
            // 
            this.flpCatelogiesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCatelogiesRegion.AutoScroll = true;
            this.flpCatelogiesRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.flpCatelogiesRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCatelogiesRegion.Location = new System.Drawing.Point(572, 154);
            this.flpCatelogiesRegion.Name = "flpCatelogiesRegion";
            this.flpCatelogiesRegion.Padding = new System.Windows.Forms.Padding(21, 16, 21, 16);
            this.flpCatelogiesRegion.Size = new System.Drawing.Size(398, 152);
            this.flpCatelogiesRegion.TabIndex = 0;
            // 
            // flpBeveragesRegion
            // 
            this.flpBeveragesRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBeveragesRegion.AutoScroll = true;
            this.flpBeveragesRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.flpBeveragesRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpBeveragesRegion.Location = new System.Drawing.Point(572, 336);
            this.flpBeveragesRegion.Name = "flpBeveragesRegion";
            this.flpBeveragesRegion.Padding = new System.Windows.Forms.Padding(21, 16, 21, 16);
            this.flpBeveragesRegion.Size = new System.Drawing.Size(398, 334);
            this.flpBeveragesRegion.TabIndex = 0;
            // 
            // pnlChoosableSugarRegion
            // 
            this.pnlChoosableSugarRegion.Controls.Add(this.rbNoSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.rbQuarterSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.rbHalfSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.rbLessSugar);
            this.pnlChoosableSugarRegion.Controls.Add(this.rbFullSugar);
            this.pnlChoosableSugarRegion.Enabled = false;
            this.pnlChoosableSugarRegion.Location = new System.Drawing.Point(26, 21);
            this.pnlChoosableSugarRegion.Name = "pnlChoosableSugarRegion";
            this.pnlChoosableSugarRegion.Size = new System.Drawing.Size(375, 50);
            this.pnlChoosableSugarRegion.TabIndex = 0;
            // 
            // rbNoSugar
            // 
            this.rbNoSugar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNoSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbNoSugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbNoSugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbNoSugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbNoSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNoSugar.Location = new System.Drawing.Point(300, 0);
            this.rbNoSugar.Name = "rbNoSugar";
            this.rbNoSugar.Size = new System.Drawing.Size(75, 50);
            this.rbNoSugar.TabIndex = 4;
            this.rbNoSugar.Text = "無糖";
            this.rbNoSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNoSugar.UseVisualStyleBackColor = false;
            this.rbNoSugar.Click += new System.EventHandler(this.rbSugar_Click);
            // 
            // rbQuarterSugar
            // 
            this.rbQuarterSugar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbQuarterSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbQuarterSugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbQuarterSugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbQuarterSugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbQuarterSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbQuarterSugar.Location = new System.Drawing.Point(225, 0);
            this.rbQuarterSugar.Name = "rbQuarterSugar";
            this.rbQuarterSugar.Size = new System.Drawing.Size(75, 50);
            this.rbQuarterSugar.TabIndex = 3;
            this.rbQuarterSugar.Text = "微糖";
            this.rbQuarterSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbQuarterSugar.UseVisualStyleBackColor = false;
            this.rbQuarterSugar.Click += new System.EventHandler(this.rbSugar_Click);
            // 
            // rbHalfSugar
            // 
            this.rbHalfSugar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbHalfSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbHalfSugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbHalfSugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbHalfSugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbHalfSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbHalfSugar.Location = new System.Drawing.Point(150, 0);
            this.rbHalfSugar.Name = "rbHalfSugar";
            this.rbHalfSugar.Size = new System.Drawing.Size(75, 50);
            this.rbHalfSugar.TabIndex = 2;
            this.rbHalfSugar.Text = "半糖";
            this.rbHalfSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbHalfSugar.UseVisualStyleBackColor = false;
            this.rbHalfSugar.Click += new System.EventHandler(this.rbSugar_Click);
            // 
            // rbLessSugar
            // 
            this.rbLessSugar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLessSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbLessSugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLessSugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbLessSugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLessSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLessSugar.Location = new System.Drawing.Point(75, 0);
            this.rbLessSugar.Name = "rbLessSugar";
            this.rbLessSugar.Size = new System.Drawing.Size(75, 50);
            this.rbLessSugar.TabIndex = 1;
            this.rbLessSugar.Text = "少糖";
            this.rbLessSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLessSugar.UseVisualStyleBackColor = false;
            this.rbLessSugar.Click += new System.EventHandler(this.rbSugar_Click);
            // 
            // rbFullSugar
            // 
            this.rbFullSugar.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbFullSugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbFullSugar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbFullSugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbFullSugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbFullSugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFullSugar.Location = new System.Drawing.Point(0, 0);
            this.rbFullSugar.Name = "rbFullSugar";
            this.rbFullSugar.Size = new System.Drawing.Size(75, 50);
            this.rbFullSugar.TabIndex = 0;
            this.rbFullSugar.Text = "全糖";
            this.rbFullSugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbFullSugar.UseVisualStyleBackColor = false;
            this.rbFullSugar.Click += new System.EventHandler(this.rbSugar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(26, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(460, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "刪除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // rbWarm
            // 
            this.rbWarm.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbWarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbWarm.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbWarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbWarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbWarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbWarm.Location = new System.Drawing.Point(300, 0);
            this.rbWarm.Name = "rbWarm";
            this.rbWarm.Size = new System.Drawing.Size(75, 50);
            this.rbWarm.TabIndex = 14;
            this.rbWarm.Text = "常溫";
            this.rbWarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbWarm.UseVisualStyleBackColor = false;
            this.rbWarm.Click += new System.EventHandler(this.rbIce_Click);
            // 
            // rbNoIce
            // 
            this.rbNoIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNoIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbNoIce.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbNoIce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbNoIce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbNoIce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNoIce.Location = new System.Drawing.Point(225, 0);
            this.rbNoIce.Name = "rbNoIce";
            this.rbNoIce.Size = new System.Drawing.Size(75, 50);
            this.rbNoIce.TabIndex = 13;
            this.rbNoIce.Text = "去冰";
            this.rbNoIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNoIce.UseVisualStyleBackColor = false;
            this.rbNoIce.Click += new System.EventHandler(this.rbIce_Click);
            // 
            // rbLittleIce
            // 
            this.rbLittleIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLittleIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbLittleIce.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLittleIce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbLittleIce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLittleIce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLittleIce.Location = new System.Drawing.Point(150, 0);
            this.rbLittleIce.Name = "rbLittleIce";
            this.rbLittleIce.Size = new System.Drawing.Size(75, 50);
            this.rbLittleIce.TabIndex = 12;
            this.rbLittleIce.Text = "微冰";
            this.rbLittleIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLittleIce.UseVisualStyleBackColor = false;
            this.rbLittleIce.Click += new System.EventHandler(this.rbIce_Click);
            // 
            // rbLessIce
            // 
            this.rbLessIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLessIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbLessIce.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLessIce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbLessIce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbLessIce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLessIce.Location = new System.Drawing.Point(75, 0);
            this.rbLessIce.Name = "rbLessIce";
            this.rbLessIce.Size = new System.Drawing.Size(75, 50);
            this.rbLessIce.TabIndex = 11;
            this.rbLessIce.Text = "少冰";
            this.rbLessIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbLessIce.UseVisualStyleBackColor = false;
            this.rbLessIce.Click += new System.EventHandler(this.rbIce_Click);
            // 
            // rbMoreIce
            // 
            this.rbMoreIce.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbMoreIce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.rbMoreIce.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbMoreIce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.rbMoreIce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.rbMoreIce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbMoreIce.Location = new System.Drawing.Point(0, 0);
            this.rbMoreIce.Name = "rbMoreIce";
            this.rbMoreIce.Size = new System.Drawing.Size(75, 50);
            this.rbMoreIce.TabIndex = 10;
            this.rbMoreIce.Text = "正常";
            this.rbMoreIce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbMoreIce.UseVisualStyleBackColor = false;
            this.rbMoreIce.Click += new System.EventHandler(this.rbIce_Click);
            // 
            // pnlChoosableIceRegion
            // 
            this.pnlChoosableIceRegion.Controls.Add(this.rbNoIce);
            this.pnlChoosableIceRegion.Controls.Add(this.rbLittleIce);
            this.pnlChoosableIceRegion.Controls.Add(this.rbWarm);
            this.pnlChoosableIceRegion.Controls.Add(this.rbLessIce);
            this.pnlChoosableIceRegion.Controls.Add(this.rbMoreIce);
            this.pnlChoosableIceRegion.Enabled = false;
            this.pnlChoosableIceRegion.Location = new System.Drawing.Point(26, 81);
            this.pnlChoosableIceRegion.Name = "pnlChoosableIceRegion";
            this.pnlChoosableIceRegion.Size = new System.Drawing.Size(375, 50);
            this.pnlChoosableIceRegion.TabIndex = 0;
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.AllowUserToResizeColumns = false;
            this.dgvOrderDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvOrderDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrderDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderDetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvOrderDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvOrderDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(153)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.dgvOrderDetail.Location = new System.Drawing.Point(26, 50);
            this.dgvOrderDetail.MultiSelect = false;
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrderDetail.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrderDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgvOrderDetail.Size = new System.Drawing.Size(460, 165);
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
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(411, 21);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 50);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.btnManage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Location = new System.Drawing.Point(241, 21);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(75, 50);
            this.btnManage.TabIndex = 10;
            this.btnManage.Text = "管理";
            this.btnManage.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.btnRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.Location = new System.Drawing.Point(326, 21);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(75, 50);
            this.btnRecord.TabIndex = 9;
            this.btnRecord.Text = "記錄";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnRingUp
            // 
            this.btnRingUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.btnRingUp.Enabled = false;
            this.btnRingUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnRingUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnRingUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRingUp.Location = new System.Drawing.Point(26, 21);
            this.btnRingUp.Name = "btnRingUp";
            this.btnRingUp.Size = new System.Drawing.Size(205, 50);
            this.btnRingUp.TabIndex = 7;
            this.btnRingUp.Text = "結帳";
            this.btnRingUp.UseVisualStyleBackColor = false;
            this.btnRingUp.Click += new System.EventHandler(this.btnRingUp_Click);
            // 
            // lblTotalTitle
            // 
            this.lblTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTotalTitle.Location = new System.Drawing.Point(26, 215);
            this.lblTotalTitle.Name = "lblTotalTitle";
            this.lblTotalTitle.Size = new System.Drawing.Size(100, 50);
            this.lblTotalTitle.TabIndex = 12;
            this.lblTotalTitle.Text = "小計︰";
            this.lblTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalContent
            // 
            this.lblTotalContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalContent.ForeColor = System.Drawing.Color.Black;
            this.lblTotalContent.Location = new System.Drawing.Point(126, 215);
            this.lblTotalContent.Name = "lblTotalContent";
            this.lblTotalContent.Size = new System.Drawing.Size(285, 50);
            this.lblTotalContent.TabIndex = 13;
            this.lblTotalContent.Text = "0";
            this.lblTotalContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDollar
            // 
            this.lblDollar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDollar.ForeColor = System.Drawing.Color.Black;
            this.lblDollar.Location = new System.Drawing.Point(411, 215);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(75, 50);
            this.lblDollar.TabIndex = 14;
            this.lblDollar.Text = "元";
            this.lblDollar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuantityIncrease
            // 
            this.btnQuantityIncrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.btnQuantityIncrease.Enabled = false;
            this.btnQuantityIncrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnQuantityIncrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnQuantityIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantityIncrease.Location = new System.Drawing.Point(411, 26);
            this.btnQuantityIncrease.Name = "btnQuantityIncrease";
            this.btnQuantityIncrease.Size = new System.Drawing.Size(75, 50);
            this.btnQuantityIncrease.TabIndex = 15;
            this.btnQuantityIncrease.Text = "加";
            this.btnQuantityIncrease.UseVisualStyleBackColor = false;
            this.btnQuantityIncrease.Click += new System.EventHandler(this.btnQuantityIncrease_Click);
            this.btnQuantityIncrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnQuantity_MouseDown);
            this.btnQuantityIncrease.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnQuantity_MouseUp);
            // 
            // btnQuantityDecrease
            // 
            this.btnQuantityDecrease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.btnQuantityDecrease.Enabled = false;
            this.btnQuantityDecrease.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(96)))), ((int)(((byte)(85)))));
            this.btnQuantityDecrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(106)))), ((int)(((byte)(94)))));
            this.btnQuantityDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantityDecrease.Location = new System.Drawing.Point(411, 76);
            this.btnQuantityDecrease.Name = "btnQuantityDecrease";
            this.btnQuantityDecrease.Size = new System.Drawing.Size(75, 50);
            this.btnQuantityDecrease.TabIndex = 15;
            this.btnQuantityDecrease.Text = "減";
            this.btnQuantityDecrease.UseVisualStyleBackColor = false;
            this.btnQuantityDecrease.Click += new System.EventHandler(this.btnQuantityDecrease_Click);
            this.btnQuantityDecrease.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnQuantity_MouseDown);
            this.btnQuantityDecrease.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnQuantity_MouseUp);
            // 
            // mouseClickTimer
            // 
            this.mouseClickTimer.Interval = 50;
            this.mouseClickTimer.Tick += new System.EventHandler(this.mouseClickTimer_Tick);
            // 
            // lblOrderNumberTitle
            // 
            this.lblOrderNumberTitle.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNumberTitle.Location = new System.Drawing.Point(26, 0);
            this.lblOrderNumberTitle.Name = "lblOrderNumberTitle";
            this.lblOrderNumberTitle.Size = new System.Drawing.Size(80, 50);
            this.lblOrderNumberTitle.TabIndex = 16;
            this.lblOrderNumberTitle.Text = "單號︰";
            this.lblOrderNumberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrderNumberContent
            // 
            this.lblOrderNumberContent.ForeColor = System.Drawing.Color.Black;
            this.lblOrderNumberContent.Location = new System.Drawing.Point(106, 0);
            this.lblOrderNumberContent.Name = "lblOrderNumberContent";
            this.lblOrderNumberContent.Size = new System.Drawing.Size(100, 50);
            this.lblOrderNumberContent.TabIndex = 16;
            this.lblOrderNumberContent.Text = "0";
            this.lblOrderNumberContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(26, 21);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(76, 21);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "時間︰";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlOrderRegion
            // 
            this.pnlOrderRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlOrderRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlOrderRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrderRegion.Controls.Add(this.pnlEmployeeTitle);
            this.pnlOrderRegion.Controls.Add(this.lblEmployeeContent);
            this.pnlOrderRegion.Controls.Add(this.lblOrderNumberContent);
            this.pnlOrderRegion.Controls.Add(this.lblOrderNumberTitle);
            this.pnlOrderRegion.Controls.Add(this.dgvOrderDetail);
            this.pnlOrderRegion.Controls.Add(this.lblTotalContent);
            this.pnlOrderRegion.Controls.Add(this.lblDollar);
            this.pnlOrderRegion.Controls.Add(this.lblTotalTitle);
            this.pnlOrderRegion.Controls.Add(this.btnDelete);
            this.pnlOrderRegion.Location = new System.Drawing.Point(30, 30);
            this.pnlOrderRegion.Name = "pnlOrderRegion";
            this.pnlOrderRegion.Size = new System.Drawing.Size(512, 336);
            this.pnlOrderRegion.TabIndex = 17;
            // 
            // pnlEmployeeTitle
            // 
            this.pnlEmployeeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEmployeeTitle.ForeColor = System.Drawing.Color.Black;
            this.pnlEmployeeTitle.Location = new System.Drawing.Point(306, 0);
            this.pnlEmployeeTitle.Name = "pnlEmployeeTitle";
            this.pnlEmployeeTitle.Size = new System.Drawing.Size(80, 50);
            this.pnlEmployeeTitle.TabIndex = 17;
            this.pnlEmployeeTitle.Text = "員工︰";
            this.pnlEmployeeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmployeeContent
            // 
            this.lblEmployeeContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeContent.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeContent.Location = new System.Drawing.Point(386, 0);
            this.lblEmployeeContent.Name = "lblEmployeeContent";
            this.lblEmployeeContent.Size = new System.Drawing.Size(100, 50);
            this.lblEmployeeContent.TabIndex = 16;
            this.lblEmployeeContent.Text = "未登入";
            this.lblEmployeeContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlControlsRegion
            // 
            this.pnlControlsRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControlsRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlControlsRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControlsRegion.Controls.Add(this.btnRingUp);
            this.pnlControlsRegion.Controls.Add(this.btnManage);
            this.pnlControlsRegion.Controls.Add(this.btnRecord);
            this.pnlControlsRegion.Controls.Add(this.btnLogout);
            this.pnlControlsRegion.Location = new System.Drawing.Point(30, 578);
            this.pnlControlsRegion.Name = "pnlControlsRegion";
            this.pnlControlsRegion.Size = new System.Drawing.Size(512, 92);
            this.pnlControlsRegion.TabIndex = 18;
            // 
            // pnlFavorAndQuantityRegion
            // 
            this.pnlFavorAndQuantityRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlFavorAndQuantityRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.pnlFavorAndQuantityRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFavorAndQuantityRegion.Controls.Add(this.pnlChoosableSugarRegion);
            this.pnlFavorAndQuantityRegion.Controls.Add(this.pnlChoosableIceRegion);
            this.pnlFavorAndQuantityRegion.Controls.Add(this.btnQuantityDecrease);
            this.pnlFavorAndQuantityRegion.Controls.Add(this.btnQuantityIncrease);
            this.pnlFavorAndQuantityRegion.Location = new System.Drawing.Point(30, 396);
            this.pnlFavorAndQuantityRegion.Name = "pnlFavorAndQuantityRegion";
            this.pnlFavorAndQuantityRegion.Size = new System.Drawing.Size(512, 152);
            this.pnlFavorAndQuantityRegion.TabIndex = 19;
            // 
            // pnlInformationRegion
            // 
            this.pnlInformationRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInformationRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(154)))));
            this.pnlInformationRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformationRegion.Controls.Add(this.lblMessage);
            this.pnlInformationRegion.Controls.Add(this.lblTime);
            this.pnlInformationRegion.Location = new System.Drawing.Point(572, 30);
            this.pnlInformationRegion.Name = "pnlInformationRegion";
            this.pnlInformationRegion.Size = new System.Drawing.Size(398, 94);
            this.pnlInformationRegion.TabIndex = 20;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 52);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 21);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "未登入";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(228)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.pnlInformationRegion);
            this.Controls.Add(this.pnlFavorAndQuantityRegion);
            this.Controls.Add(this.pnlControlsRegion);
            this.Controls.Add(this.pnlOrderRegion);
            this.Controls.Add(this.flpCatelogiesRegion);
            this.Controls.Add(this.flpBeveragesRegion);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "飲料訂購系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlChoosableSugarRegion.ResumeLayout(false);
            this.pnlChoosableIceRegion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.pnlOrderRegion.ResumeLayout(false);
            this.pnlControlsRegion.ResumeLayout(false);
            this.pnlFavorAndQuantityRegion.ResumeLayout(false);
            this.pnlInformationRegion.ResumeLayout(false);
            this.pnlInformationRegion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpCatelogiesRegion;
        private System.Windows.Forms.FlowLayoutPanel flpBeveragesRegion;
        private System.Windows.Forms.Panel pnlChoosableSugarRegion;
        private System.Windows.Forms.RadioButton rbLessSugar;
        private System.Windows.Forms.RadioButton rbFullSugar;
        private System.Windows.Forms.RadioButton rbNoSugar;
        private System.Windows.Forms.RadioButton rbQuarterSugar;
        private System.Windows.Forms.RadioButton rbHalfSugar;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RadioButton rbWarm;
        private System.Windows.Forms.RadioButton rbNoIce;
        private System.Windows.Forms.RadioButton rbLittleIce;
        private System.Windows.Forms.RadioButton rbLessIce;
        private System.Windows.Forms.RadioButton rbMoreIce;
        private System.Windows.Forms.Panel pnlChoosableIceRegion;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnRingUp;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalContent;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Button btnQuantityIncrease;
        private System.Windows.Forms.Button btnQuantityDecrease;
        private System.Windows.Forms.Timer mouseClickTimer;
        private System.Windows.Forms.Label lblOrderNumberTitle;
        private System.Windows.Forms.Label lblOrderNumberContent;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlOrderRegion;
        private System.Windows.Forms.Panel pnlControlsRegion;
        private System.Windows.Forms.Panel pnlFavorAndQuantityRegion;
        private System.Windows.Forms.Panel pnlInformationRegion;
        private System.Windows.Forms.Label pnlEmployeeTitle;
        internal System.Windows.Forms.Label lblEmployeeContent;
        internal System.Windows.Forms.Label lblMessage;
    }
}

