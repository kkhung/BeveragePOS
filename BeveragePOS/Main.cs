using System;
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
        private Color colorBtnDefault = Color.FromArgb(112, 153, 171);
        private Color colorBtnMouseDown = Color.FromArgb(132, 96, 85);
        private Color colorBtnMouseOver = Color.FromArgb(145, 106, 94);
        private bool _isCloseable = false;
        public bool isCloseable
        {
            get { return _isCloseable; }
            set { _isCloseable = value; }
        }
        private Employee _employee = new Employee();
        public Employee employee
        {
            get { return _employee; }
            set { _employee = value; }
        }

        private void getLblOrderNumber()
        {
            var results = from orderMaster in dataContext.OrderMaster where orderMaster.DateTime.Day == DateTime.Now.Day select new { orderMaster.Number };
            if (results.Count() == 0)
            {
                lblOrderNumberContent.Text = "1";
            }
            else
            {
                lblOrderNumberContent.Text = results.Max().Number.ToString();
            }
        }
        
        private void initialDgvOrderDetail()
        {
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

        private void initialFlpCatelogiesRegion()
        {
            var results = from beverage in dataContext.Beverage where beverage.IsSale == true select beverage.Category;
            flpCatelogiesRegion.SuspendLayout();
            foreach (var result in results.Distinct())
            {
                RadioButton rbCategory = new RadioButton();
                rbCategory.Appearance = Appearance.Button;
                rbCategory.Click += new EventHandler(rbCategory_Click);
                rbCategory.FlatAppearance.CheckedBackColor = colorBtnChecked;
                rbCategory.FlatAppearance.MouseDownBackColor = colorBtnMouseDown;
                rbCategory.FlatAppearance.MouseOverBackColor = colorBtnMouseOver;
                rbCategory.FlatStyle = FlatStyle.Flat;
                rbCategory.Margin = new Padding(5);
                rbCategory.Parent = flpCatelogiesRegion;
                rbCategory.Size = new Size(flpCatelogiesRegion.Width / 3 - 35, 50);
                rbCategory.Text = result;
                rbCategory.TextAlign = ContentAlignment.MiddleCenter;
                rbCategory.UseVisualStyleBackColor = true;
            }
            flpCatelogiesRegion.ResumeLayout();
        }

        public void setSystemLog(string description)
        {
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
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (isCloseable) ? false : true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SuspendLayout();
            initialDgvOrderDetail();
            initialFlpCatelogiesRegion();
            ResumeLayout();
            getLblOrderNumber();
            if (flpCatelogiesRegion.Controls.Count > 0)
            {
                (flpCatelogiesRegion.Controls[0] as RadioButton).PerformClick();
            }
            Login login = new Login(this);
            login.ShowDialog();
            lblEmployeeContent.Text = employee.Name;
            lblMessage.Text = "歡迎使用本系統";
        }

        private void dgvOrderDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                bool isChoosableSugar = orderDetails[dgvOrderDetail.SelectedRows[0].Index].Beverage.IsChoosableSugar;
                bool isChoosableIce = orderDetails[dgvOrderDetail.SelectedRows[0].Index].Beverage.IsChoosableIce;
                pnlChoosableSugarRegion.Enabled = isChoosableSugar;
                pnlChoosableIceRegion.Enabled = isChoosableIce;
                if (!isChoosableSugar)
                {
                    orderDetails[dgvOrderDetail.SelectedRows[0].Index].Sugar = "固定";
                }
                if (!isChoosableIce)
                {
                    orderDetails[dgvOrderDetail.SelectedRows[0].Index].Ice = "熱飲";
                }
                foreach (RadioButton rbSugar in pnlChoosableSugarRegion.Controls)
                {
                    rbSugar.Checked = false;
                    if (orderDetails[dgvOrderDetail.SelectedRows[0].Index].Sugar == rbSugar.Text)
                    {
                        rbSugar.Checked = true;
                    }
                }
                foreach (RadioButton rbIce in pnlChoosableIceRegion.Controls)
                {
                    rbIce.Checked = false;
                    if (orderDetails[dgvOrderDetail.SelectedRows[0].Index].Ice == rbIce.Text)
                    {
                        rbIce.Checked = true;
                    }
                }
                lblMessage.Text = "選取第" + (dgvOrderDetail.SelectedRows[0].Index + 1) + "筆交易項目";
            }
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {
            RadioButton rbCategory = sender as RadioButton;
            var results = from beverage in dataContext.Beverage where beverage.IsSale == true && beverage.Category == rbCategory.Text select new { beverage.Name, beverage.Category, beverage.Price, beverage.IsChoosableSugar, beverage.IsChoosableIce };
            SuspendLayout();
            flpBeveragesRegion.SuspendLayout();
            flpBeveragesRegion.Controls.Clear();
            foreach (var result in results)
            {
                Beverage beverage = new Beverage();
                beverage.Name = result.Name;
                beverage.Price = result.Price;
                beverage.IsChoosableSugar = result.IsChoosableSugar;
                beverage.IsChoosableIce = result.IsChoosableIce;
                Button btnBeverage = new Button();
                btnBeverage.BackColor = colorBtnDefault;
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
            foreach (RadioButton rb in flpCatelogiesRegion.Controls)
            {
                rb.BackColor = (rb.Checked) ? colorBtnChecked : colorBtnDefault;
            }
            lblMessage.Text = "";
        }

        private void btnBeverage_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            orderDetail.Beverage = (sender as Button).Tag as Beverage;
            orderDetail.Quantity = 1;
            orderDetails.Add(orderDetail);
            countTotal();
            dgvOrderDetail.Rows[dgvOrderDetail.RowCount - 1].Selected = true;
            dgvOrderDetail.Select();
            lblMessage.Text = "新增1筆交易項目";
        }

        private void rbSugar_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Sugar = (sender as RadioButton).Text;
            }
            lblMessage.Text = "";
        }

        private void rbIce_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Ice = (sender as RadioButton).Text;
            }
            lblMessage.Text = "";
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                Button btnDelete = sender as Button;
                btnDelete.BackColor = colorBtnChecked;
                btnDelete.Update();
                orderDetails.RemoveAt(dgvOrderDetail.SelectedRows[0].Index);
                countTotal();
                if (dgvOrderDetail.Rows.Count > 0)
                {
                    dgvOrderDetail.Rows[dgvOrderDetail.Rows.Count - 1].Selected = true;
                    dgvOrderDetail.Select();
                }
                btnDelete.BackColor = colorBtnDefault;
                lblMessage.Text = "刪除1筆交易項目";
            }
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
            int orderMasterID = ((from o in dataContext.OrderMaster where o.DateTime.Day == DateTime.Now.Day && o.Number == number  select new { o.ID }).Single().ID);
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

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (orderDetails.Count > 0)
            {
                lblMessage.Text = "交易未完成！";
            }
            else
            {
                lblMessage.Text = "己登出";
                setSystemLog("登出");
                Login login = new Login(this);
                login.ShowDialog();
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "時間︰" + DateTime.Now.ToString();
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity += 1;
            }
            countTotal();
            lblMessage.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
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

        bool isMouseOnBtnPlus = false;

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

        bool isMouseOnBtnMinus = false;

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

        private void btnRecord_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.ShowDialog();
        }
    }
}
