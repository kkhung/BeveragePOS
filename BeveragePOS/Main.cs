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
        // 可用來當作DataGridView資料來源的訂單名細串列
        private BindingList<OrderDetail> orderDetails = new BindingList<OrderDetail>();
        // RadioButton確認時的顏色
        private Color colorRbChecked = Color.FromArgb(145, 106, 94);
        // 系統按鈕的顏色
        private Color colorBtnControl = Color.FromArgb(210, 211, 154);
        // 失效按鈕的顏色
        private Color colorBtnDisable = Color.FromArgb(220, 228, 203);
        // 交易操作按鈕的顏色
        private Color colorBtnTrade = Color.FromArgb(112, 153, 171);
        // 滑鼠按下按鈕時的顏色
        private Color colorBtnMouseDown = Color.FromArgb(132, 96, 85);
        // 滑鼠經過按鈕時的顏色
        private Color colorBtnMouseOver = Color.FromArgb(145, 106, 94);
        // 飲料串列
        private List<Beverage> beverages;
        // 用來暫存數量加減的按鈕
        private Button btnQuantity;
        // 表單是否可以關閉
        private bool _isCloseable = false;
        // 員工
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

        // 計算小計
        private void countTotal()
        {
            int total = 0;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                total += orderDetail.Beverage.Price * orderDetail.Quantity;
            }
            lblTotalContent.Text = total.ToString();
        }

        private void createRbCategory()
        {
            // 取得飲料的分類並產生按鈕
            var results = from b in beverages select b.Category;
            foreach (string category in results.Distinct())
            {
                RadioButton rbCategory = new RadioButton();
                rbCategory.Appearance = Appearance.Button;
                rbCategory.BackColor = colorBtnTrade;
                rbCategory.Click += new EventHandler(rbCategory_Click);
                rbCategory.FlatAppearance.CheckedBackColor = colorRbChecked;
                rbCategory.FlatAppearance.MouseDownBackColor = colorBtnMouseDown;
                rbCategory.FlatAppearance.MouseOverBackColor = colorBtnMouseOver;
                rbCategory.FlatStyle = FlatStyle.Flat;
                rbCategory.Margin = new Padding(5);
                rbCategory.Parent = flpCatelogiesRegion;
                rbCategory.Size = new Size(200, 50);
                rbCategory.Text = category;
                rbCategory.TextAlign = ContentAlignment.MiddleCenter;
                rbCategory.UseVisualStyleBackColor = true;
            }
        }

        // 於資料庫中取得飲料的資料
        private List<Beverage> getBeverages()
        {
            var results = from b in dataContext.Beverage where b.IsSale == true select b;
            return results.ToList();
        }

        private int getOrderNumber()
        {
            // 從資料庫中找出並接續之前的單號，每天會重新計數
            var results = from om in dataContext.OrderMaster where om.DateTime.Day == DateTime.Now.Day select om.Number;
            return (results.Count() > 0) ? (results.Max() + 1) : 1;
        }

        private void goTradeMode()
        {
            int index = dgvOrderDetail.SelectedRows[0].Index;
            OrderDetail orderDetail = orderDetails[index];
            bool isChoosableSugar = orderDetail.Beverage.IsChoosableSugar;
            bool isChoosableIce = orderDetail.Beverage.IsChoosableIce;
            // 開啟刪除按鈕的功能
            btnDelete.Enabled = true;
            btnDelete.BackColor = colorBtnTrade;
            // 開啟甜度按鈕的功能
            pnlChoosableSugarRegion.Enabled = isChoosableSugar;
            foreach (RadioButton rbSugar in pnlChoosableSugarRegion.Controls)
            {
                rbSugar.BackColor = isChoosableSugar ? colorBtnTrade : colorBtnDisable;
                rbSugar.Checked = false;
                rbSugar.Checked = (orderDetail.Sugar == rbSugar.Text) ? true : false;
            }
            // 開啟冰塊按鈕的功能
            pnlChoosableIceRegion.Enabled = isChoosableIce;
            foreach (RadioButton rbIce in pnlChoosableIceRegion.Controls)
            {
                rbIce.BackColor = isChoosableIce ? colorBtnTrade : colorBtnDisable;
                rbIce.Checked = (orderDetail.Ice == rbIce.Text) ? true : false;
            }
            // 開啟加按鈕的功能
            btnQuantityIncrease.Enabled = true;
            btnQuantityIncrease.BackColor = colorBtnTrade;
            // 開啟減按鈕的功能
            btnQuantityDecrease.Enabled = true;
            btnQuantityDecrease.BackColor = colorBtnTrade;
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
        }

        private void exitTradeMode()
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
            btnQuantityIncrease.Enabled = false;
            btnQuantityIncrease.BackColor = colorBtnDisable;
            // 關閉減按鈕的功能
            btnQuantityDecrease.Enabled = false;
            btnQuantityDecrease.BackColor = colorBtnDisable;
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

        private void initialDgvOrderDetail()
        {
            // 自訂 dgvOrderDetail 的 UI 樣示
            SuspendLayout();
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
            ResumeLayout();
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
            beverages = getBeverages();
            lblOrderNumberContent.Text = getOrderNumber().ToString();
            flpCatelogiesRegion.SuspendLayout();
            SuspendLayout();
            initialDgvOrderDetail();
            createRbCategory();
            ResumeLayout();
            flpCatelogiesRegion.ResumeLayout();
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
                // 進入交易模式
                goTradeMode();
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
                // 判斷是否有未完成的交易
                if (dgvOrderDetail.Rows.Count > 0)
                {
                    // 選取餘下的最後一筆交易項目
                    dgvOrderDetail.Rows[dgvOrderDetail.Rows.Count - 1].Selected = true;
                    dgvOrderDetail.Select();
                }
                else
                {
                    exitTradeMode();
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

        private void btnQuantityIncrease_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                // 數量加一
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity += 1;
            }
            // 重新計算小計
            countTotal();
            // 清空訊息
            lblMessage.Text = "";
        }

        private void btnQuantityDecrease_Click(object sender, EventArgs e)
        {
            // 判斷是否選中交易項目
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                int index = dgvOrderDetail.SelectedRows[0].Index;
                // 數量減一但不可小於一
                orderDetails[index].Quantity = (orderDetails[index].Quantity == 1) ? 1 : orderDetails[index].Quantity - 1;
            }
            // 重新計算小計
            countTotal();
            // 清空訊息
            lblMessage.Text = "";
        }

        private void btnQuantity_MouseDown(object sender, MouseEventArgs e)
        {
            // 開啟計時器
            mouseClickTimer.Enabled = true;
            // 指定正在執行的按鈕
            btnQuantity = sender as Button;
        }

        private void btnQuantity_MouseUp(object sender, MouseEventArgs e)
        {
            // 關閉計時器
            mouseClickTimer.Enabled = false;
            // 指定正在執行的按鈕
            btnQuantity = sender as Button;
        }

        private void btnRingUp_Click(object sender, EventArgs e)
        {
            int orderNumber = int.Parse(lblOrderNumberContent.Text);
            OrderMaster orderMaster = new OrderMaster()
            {
                EmployeeID = employee.ID,
                Number = orderNumber,
                DateTime = DateTime.Now,
            };
            orderMaster.OrderDetail.AddRange(orderDetails.ToList());
            // 清空 ChangeSet
            foreach (var insert in dataContext.GetChangeSet().Inserts)
            {
                if (!orderDetails.Contains(insert))
                {
                    dataContext.GetTable(insert.GetType()).DeleteOnSubmit(insert);
                }
            }
            // 將訂單資料塞入資料庫
            dataContext.OrderMaster.InsertOnSubmit(orderMaster);
            dataContext.SubmitChanges();
            // 重置訂單名細串列
            orderDetails.Clear();
            // 顯示交易成功訊息
            lblMessage.Text = "交易成功";
            // 重新計算小計
            countTotal();
            // 增加單號
            lblOrderNumberContent.Text = (orderNumber + 1).ToString();
            // 離開交易模式
            exitTradeMode();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            // 關啟 Manage 表單
            Manage manage = new Manage();
            manage.ShowDialog();
            // 進入 Manage 表單
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            // 關啟 Record 表單
            Record record = new Record();
            record.ShowDialog();
            // 進入 Record 表單
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 設定登出訊息
            lblEmployeeContent.Text = "未登入";
            lblMessage.Text = "己登出";
            // 清空 ChangeSet
            foreach (var insert in dataContext.GetChangeSet().Inserts)
            {
                dataContext.GetTable(insert.GetType()).DeleteOnSubmit(insert);
            }
            // 設定登入記錄
            setSystemLog("登出");
            // 關啟 Login 表單
            Login login = new Login(this);
            login.ShowDialog();
            // 進入 Login 表單
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {
            // 依不同分類產生對應的飲料按鈕
            RadioButton rbCategory = sender as RadioButton;
            var results = from b in beverages where b.Category == rbCategory.Text select b;
            flpBeveragesRegion.SuspendLayout();
            SuspendLayout();
            flpBeveragesRegion.Controls.Clear();
            foreach (Beverage beverage in results)
            {
                Button btnBeverage = new Button();
                btnBeverage.BackColor = colorBtnTrade;
                btnBeverage.Click += new EventHandler(btnBeverage_Click);
                btnBeverage.FlatAppearance.CheckedBackColor = colorRbChecked;
                btnBeverage.FlatAppearance.MouseDownBackColor = colorBtnMouseDown;
                btnBeverage.FlatAppearance.MouseOverBackColor = colorBtnMouseOver;
                btnBeverage.FlatStyle = FlatStyle.Flat;
                btnBeverage.Margin = new Padding(5);
                btnBeverage.Parent = flpBeveragesRegion;
                btnBeverage.Size = new Size(200, 50);
                btnBeverage.Tag = beverage;
                btnBeverage.Text = beverage.Name;
                btnBeverage.UseVisualStyleBackColor = true;
            }
            ResumeLayout();
            flpBeveragesRegion.ResumeLayout();
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            Beverage beverage = (sender as Button).Tag as Beverage;
            // 新增一筆交易項目
            OrderDetail orderDetail = new OrderDetail()
            {
                Beverage = beverage,
                Sugar = beverage.IsChoosableSugar ? "全糖" : "固定",
                Ice = beverage.IsChoosableIce ? "正常" : "熱飲",
                Quantity = 1
            };
            // 加入交易串列
            orderDetails.Add(orderDetail);
            // 重新計算小計
            countTotal();
            // 顯示新增操作的訊息
            lblMessage.Text = "新增1筆交易項目";
            // 選取新增的那一筆交易項目
            dgvOrderDetail.Rows[dgvOrderDetail.RowCount - 1].Selected = true;
            dgvOrderDetail.Select();
            // 進入交易模式
            goTradeMode();
        }

        private void mouseClickTimer_Tick(object sender, EventArgs e)
        {
            // 每次計數時點擊按鈕
            btnQuantity.PerformClick();
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            // 顯示當前時間
            lblTime.Text = "時間︰" + DateTime.Now.ToString();
        }
    }
}
