using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class Main : Form
    {
        private BeveragePOSDataContext dataContext = new BeveragePOSDataContext();
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        private Color colorBtnChecked = Color.FromArgb(145, 106, 94);
        private Color colorBtnControl = Color.FromArgb(210, 211, 154);
        private Color colorBtnDisable = Color.FromArgb(220, 228, 203);
        private Color colorBtnEnable = Color.FromArgb(112, 153, 171);
        private Color colorBtnMouseDown = Color.FromArgb(132, 96, 85);
        private Color colorBtnMouseOver = Color.FromArgb(145, 106, 94);
        private List<Beverage> beverages;
        private bool isMouseOnBtnPlus = false;
        private bool isMouseOnBtnMinus = false;
        private bool _isCloseable = false;
        private Employee _employee = new Employee();

        public bool isCloseable
        {
            get { return _isCloseable; }
            set { _isCloseable = value; }
        }

        public Employee employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        private void countTotal()
        {
            int total = 0;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                total += orderDetail.Beverage.Price * orderDetail.Quantity;
            }
            lblTotalContent.Text = total.ToString();
        }

        private void getBeverages()
        {
            // 設資料庫中取得飲料的資料
            var results = from be in dataContext.Beverage where be.IsSale == true select be;
            beverages = results.ToList();
        }

        private void getOrderNumber()
        {
            // 從資料庫中找出並接續之前的單號，每天會重新計數
            var results = from or in dataContext.OrderMaster where or.DateTime.Day == DateTime.Now.Day select or.Number;
            lblOrderNumberContent.Text = (results.Count() > 0) ? (results.Max() + 1).ToString() : "1" ;
        }

        private void initialDgvOrderDetail()
        {
            // 自訂 dgvOrderDetail 的 UI 樣示
            dgvOrderDetail.SuspendLayout();
            dgvOrderDetail.DataSource = orderDetails;
            dgvOrderDetail.Columns.Remove("ID");
            dgvOrderDetail.Columns.Remove("OrderMasterID");
            dgvOrderDetail.Columns.Remove("Beverage");
            dgvOrderDetail.Columns.Remove("OrderMaster");
            dgvOrderDetail.Columns["BeverageName"].HeaderText = "名稱";
            dgvOrderDetail.Columns["Sugar"].HeaderText = "甜度";
            dgvOrderDetail.Columns["Ice"].HeaderText = "冰塊";
            dgvOrderDetail.Columns["Quantity"].HeaderText = "數量";
            dgvOrderDetail.Columns["BeverageName"].Width = 198;
            dgvOrderDetail.Columns["Sugar"].Width = 80;
            dgvOrderDetail.Columns["Ice"].Width = 80;
            dgvOrderDetail.Columns["Quantity"].Width = 100;
            dgvOrderDetail.ResumeLayout();
        }

        private void createRbCategory()
        {
            // 取得飲料的分類並產生按鈕
            var results = from be in beverages select be.Category;
            foreach (string category in results.Distinct())
            {
                RadioButton rbCategory = new RadioButton();
                rbCategory.Appearance = Appearance.Button;
                rbCategory.BackColor = colorBtnEnable;
                rbCategory.Click += new EventHandler(rbCategory_Click);
                rbCategory.FlatAppearance.CheckedBackColor = colorBtnChecked;
                rbCategory.FlatAppearance.MouseDownBackColor = colorBtnMouseDown;
                rbCategory.FlatAppearance.MouseOverBackColor = colorBtnMouseOver;
                rbCategory.FlatStyle = FlatStyle.Flat;
                rbCategory.Margin = new Padding(5);
                rbCategory.Parent = flpCatelogiesRegion;
                rbCategory.Size = new Size(flpCatelogiesRegion.Width / 3 - 35, 50);
                rbCategory.Text = category;
                rbCategory.TextAlign = ContentAlignment.MiddleCenter;
                rbCategory.UseVisualStyleBackColor = true;
            }
        }

        internal void setSystemLog(string description)
        {
            // 於資料庫中記錄系統訊息
            SystemLog log = new SystemLog
            {
                EmployeeID = employee.ID,
                DateTime = DateTime.Now,
                Description = description
            };
            dataContext.SystemLog.InsertOnSubmit(log);
            dataContext.SubmitChanges();
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // 自訂初始化開始
            getBeverages();
            getOrderNumber();
            SuspendLayout();
            flpCatelogiesRegion.SuspendLayout();
            initialDgvOrderDetail();
            createRbCategory();
            flpCatelogiesRegion.ResumeLayout();
            ResumeLayout();
            if (flpCatelogiesRegion.Controls.Count > 0)
            {
                // 有分類按鈕時預設點擊第一顆按鈕
                (flpCatelogiesRegion.Controls[0] as RadioButton).PerformClick();
            }
            // 自訂初始化結束
            // 載入 Login 表單
            Login login = new Login(this);
            login.ShowDialog();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 鎖定表單的關閉功能
            e.Cancel = (isCloseable) ? false : true;
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int index = dgvOrderDetail.SelectedRows[0].Index;
                OrderDetail orderDetail = orderDetails[index];
                bool isChoosableSugar = orderDetail.Beverage.IsChoosableSugar;
                bool isChoosableIce = orderDetail.Beverage.IsChoosableIce;
                // 開啟刪除按鈕的功能
                btnDelete.Enabled = true;
                btnDelete.BackColor = colorBtnEnable;
                // 開啟甜度按鈕的功能
                pnlChoosableSugarRegion.Enabled = isChoosableSugar;
                foreach (RadioButton rbSugar in pnlChoosableSugarRegion.Controls)
                {
                    rbSugar.BackColor = isChoosableSugar ? colorBtnEnable : colorBtnDisable;
                    rbSugar.Checked = false;
                    rbSugar.Checked = (orderDetail.Sugar == rbSugar.Text) ? true : false;
                }
                // 開啟冰塊按鈕的功能
                pnlChoosableIceRegion.Enabled = isChoosableIce;
                foreach (RadioButton rbIce in pnlChoosableIceRegion.Controls)
                {
                    rbIce.BackColor = isChoosableIce ? colorBtnEnable : colorBtnDisable;
                    rbIce.Checked = (orderDetail.Ice == rbIce.Text) ? true : false;
                }
                // 開啟加按鈕的功能
                btnPlus.Enabled = true;
                btnPlus.BackColor = colorBtnEnable;
                // 開啟減按鈕的功能
                btnMinus.Enabled = true;
                btnMinus.BackColor = colorBtnEnable;
                // 開啟結帳按鈕的功能
                btnRingUp.Enabled = true;
                btnRingUp.BackColor = colorBtnControl;
                // 關閉管理按鈕的功能
                btnManage.Enabled = false;
                btnManage.BackColor = colorBtnDisable;
                // 關閉記錄按鈕的功能
                btnRecord.Enabled = false;
                btnRecord.BackColor = colorBtnDisable;
                // 關閉登出按鈕的功能
                btnLogout.Enabled = false;
                btnLogout.BackColor = colorBtnDisable;
                // 顯示選取操作的訊息
                lblMessage.Text = "選取第" + (index + 1) + "筆交易項目";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                Button btnDelete = sender as Button;
                // 刪除選取的交易
                orderDetails.RemoveAt(dgvOrderDetail.SelectedRows[0].Index);
                // 計算小計
                countTotal();
                if (dgvOrderDetail.Rows.Count > 0)
                {
                    // 選取另一筆交易項目
                    dgvOrderDetail.Rows[dgvOrderDetail.Rows.Count - 1].Selected = true;
                    dgvOrderDetail.Select();
                }
                else
                {
                    // 關閉刪除按鈕的功能
                    btnDelete.Enabled = false;
                    btnDelete.BackColor = colorBtnDisable;
                    // 關閉甜度按鈕的功能
                    pnlChoosableSugarRegion.Enabled = false;
                    foreach (RadioButton rbSugar in pnlChoosableSugarRegion.Controls)
                    {
                        rbSugar.BackColor = colorBtnDisable;
                        rbSugar.Checked = false;
                    }
                    // 關閉冰塊按鈕的功能
                    pnlChoosableIceRegion.Enabled = false;
                    foreach (RadioButton rbIce in pnlChoosableIceRegion.Controls)
                    {
                        rbIce.BackColor = colorBtnDisable;
                        rbIce.Checked = false;
                    }
                    // 關閉加按鈕的功能
                    btnPlus.Enabled = false;
                    btnPlus.BackColor = colorBtnDisable;
                    // 關閉減按鈕的功能
                    btnMinus.Enabled = false;
                    btnMinus.BackColor = colorBtnDisable;
                    // 關閉結帳按鈕的功能
                    btnRingUp.Enabled = false;
                    btnRingUp.BackColor = colorBtnDisable;
                    // 開啟管理按鈕的功能
                    btnManage.Enabled = true;
                    btnManage.BackColor = colorBtnControl;
                    // 開啟記錄按鈕的功能
                    btnRecord.Enabled = true;
                    btnRecord.BackColor = colorBtnControl;
                    // 開啟登出按鈕的功能
                    btnLogout.Enabled = true;
                    btnLogout.BackColor = colorBtnControl;
                }
                // 顯示刪除操作的訊息
                lblMessage.Text = "刪除1筆交易項目";
            }
        }

        private void rbSugar_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Sugar = (sender as RadioButton).Text;
            }
            // 清空訊息
            lblMessage.Text = "";
        }

        private void rbIce_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Ice = (sender as RadioButton).Text;
            }
            // 清空訊息
            lblMessage.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity += 1;
            }
            countTotal();
            lblMessage.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                if (orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity == 1)
                {
                    orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity = 1;
                }
                else
                {
                    orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity -= 1;
                }
            }
            countTotal();
            lblMessage.Text = "";
        }

        private void btnPlus_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseOnBtnPlus = true;
            mouseClickTimer.Enabled = true;
        }

        private void btnPlus_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseOnBtnPlus = false;
            mouseClickTimer.Enabled = false;
        }

        private void btnMinus_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseOnBtnMinus = true;
            mouseClickTimer.Enabled = true;
        }

        private void btnMinus_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseOnBtnMinus = false;
            mouseClickTimer.Enabled = false;
        }

        private void btnRingUp_Click(object sender, EventArgs e)
        {
            int number = int.Parse(lblOrderNumberContent.Text);
            OrderMaster orderMaster = new OrderMaster()
            {
                EmployeeID = employee.ID,
                Number = number,
                DateTime = DateTime.Now
            };
            dataContext.OrderMaster.InsertOnSubmit(orderMaster);
            dataContext.SubmitChanges();
            int orderMasterID = ((from o in dataContext.OrderMaster where o.DateTime.Day == DateTime.Now.Day && o.Number == number select new { o.ID }).Single().ID);
            foreach (OrderDetail orderDetail in orderDetails)
            {
                orderDetail.OrderMasterID = orderMasterID;
                dataContext.OrderDetail.InsertOnSubmit(orderDetail);
            }
            dataContext.SubmitChanges();
            orderDetails.Clear();
            countTotal();
            lblOrderNumberContent.Text = (number + 1).ToString();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            Manage manage = new Manage();
            manage.ShowDialog();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (orderDetails.Count > 0)
            {
                lblMessage.Text = "尚有未完成的交易！";
            }
            else
            {
                lblEmployeeContent.Text = "未登入";
                lblMessage.Text = "己登出";
                setSystemLog("登出");
                Login login = new Login(this);
                login.ShowDialog();
            }
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {
            // 依不同分類產生對應的飲料按鈕
            RadioButton rbCategory = sender as RadioButton;
            var results = from be in beverages where be.Category == rbCategory.Text select be;
            SuspendLayout();
            flpBeveragesRegion.SuspendLayout();
            flpBeveragesRegion.Controls.Clear();
            foreach (Beverage beverage in results)
            {
                Button btnBeverage = new Button();
                btnBeverage.BackColor = colorBtnEnable;
                btnBeverage.Click += new EventHandler(btnBeverage_Click);
                btnBeverage.FlatAppearance.CheckedBackColor = colorBtnChecked;
                btnBeverage.FlatAppearance.MouseDownBackColor = colorBtnMouseDown;
                btnBeverage.FlatAppearance.MouseOverBackColor = colorBtnMouseOver;
                btnBeverage.FlatStyle = FlatStyle.Flat;
                btnBeverage.Margin = new Padding(5);
                btnBeverage.Parent = flpBeveragesRegion;
                btnBeverage.Size = new Size(flpBeveragesRegion.Width / 3 - 35, 50);
                btnBeverage.Tag = beverage;
                btnBeverage.Text = beverage.Name;
                btnBeverage.UseVisualStyleBackColor = true;
            }
            flpBeveragesRegion.ResumeLayout();
            ResumeLayout();
            // 清空訊息
            lblMessage.Text = "";
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Beverage = (sender as Button).Tag as Beverage;
            orderDetail.Quantity = 1;
            if (!orderDetail.Beverage.IsChoosableSugar)
            {
                orderDetail.Sugar = "固定";
            }
            else
            {
                orderDetail.Sugar = "全糖";
                rbFullSugar.Checked = true;
            }
            if (!orderDetail.Beverage.IsChoosableIce)
            {
                orderDetail.Ice = "熱飲";
            }
            else
            {
                orderDetail.Ice = "正常";
                rbMoreIce.Checked = true;
            }
            orderDetails.Add(orderDetail);
            lblMessage.Text = "新增1筆交易項目";
            countTotal();
            dgvOrderDetail.Rows[dgvOrderDetail.RowCount - 1].Selected = true;
            dgvOrderDetail.Select();
        }

        private void mouseClickTimer_Tick(object sender, EventArgs e)
        {
            if (isMouseOnBtnPlus)
            {
                btnPlus.PerformClick();
            }
            if (isMouseOnBtnMinus)
            {
                btnMinus.PerformClick();
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            // 顯示當前時間
            lblTime.Text = "時間︰" + DateTime.Now.ToString();
        }
    }
}
