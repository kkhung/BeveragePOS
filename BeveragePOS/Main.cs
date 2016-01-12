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
        private Employee _employee = new Employee();
        public Employee employee { get { return _employee; } set { _employee = value; } }
        private Color defaultButtonColor = Color.FromArgb(112, 153, 171);
        private Color selectedButtonColor = Color.FromArgb(145, 106, 94);
        
        private void getLblOrderNumber()
        {
            var results = from orderMaster in dataContext.OrderMaster where orderMaster.Time.Days == DateTime.Now.Day select new { orderMaster.Number, orderMaster.Time };
            if (results.Count() == 0)
            {
                lblNumOrderNumber.Text = "1";
            }
            else
            {
                lblNumOrderNumber.Text = results.Max().Number.ToString();
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
            dgvOrderDetail.Columns["BeverageName"].Width = 200;
            dgvOrderDetail.Columns["Sugar"].Width = 75;
            dgvOrderDetail.Columns["Ice"].Width = 75;
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
                rbCategory.Margin = new Padding(0);
                rbCategory.Parent = flpCatelogiesRegion;
                rbCategory.Size = new Size(flpCatelogiesRegion.Width / 3 - 10, 75);
                rbCategory.Text = result;
                rbCategory.TextAlign = ContentAlignment.MiddleCenter;
            }
            flpCatelogiesRegion.ResumeLayout();
        }

        private void setSystemLog(string description)
        {
            SystemLog log = new SystemLog();
            log.EmployeeID = _employee.ID;
            log.Time = TimeSpan.FromTicks(DateTime.Now.Ticks);
            log.Description = description;
        }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            setSystemLog("登出");
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
            setSystemLog("登入");
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
            }
        }

        private void rbCategory_Click(object sender, EventArgs e)
        {
            RadioButton rbCategory = sender as RadioButton;
            var results = from beverage in dataContext.Beverage where beverage.IsSale == true && beverage.Category == rbCategory.Text select new { beverage.Name, beverage.Price, beverage.IsChoosableSugar, beverage.IsChoosableIce };
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
                btnBeverage.BackColor = defaultButtonColor;
                btnBeverage.Click += new EventHandler(btnBeverage_Click);
                btnBeverage.Margin = new Padding(0);
                btnBeverage.Parent = flpBeveragesRegion;
                btnBeverage.Size = new Size(flpBeveragesRegion.Width / 3 - 10, 75);
                btnBeverage.Tag = beverage;
                btnBeverage.Text = beverage.Name + "(" + beverage.Price + ")";
            }
            flpBeveragesRegion.ResumeLayout();
            ResumeLayout();
            foreach (RadioButton rb in flpCatelogiesRegion.Controls)
            {
                rb.BackColor = (rb.Checked) ? selectedButtonColor : defaultButtonColor;
            }
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
        }

        private void btnSugar_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Sugar = (sender as Button).Text;
            }
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Ice = (sender as Button).Text;
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity = int.Parse(orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity + (sender as Button).Text);
                countTotal();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity = 1;
            countTotal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails.RemoveAt(dgvOrderDetail.SelectedRows[0].Index);
                countTotal();
                if (dgvOrderDetail.Rows.Count > 0)
                {
                    dgvOrderDetail.Rows[dgvOrderDetail.Rows.Count - 1].Selected = true;
                    dgvOrderDetail.Select();
                }
            }
        }

        private void btnRingUp_Click(object sender, EventArgs e)
        {
            orderDetails.Clear();
            countTotal();
            lblNumOrderNumber.Text = (int.Parse(lblNumOrderNumber.Text) + 1).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void btnManage_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            setSystemLog("登出");
            Login login = new Login(this);
            login.ShowDialog();
            setSystemLog("登入");
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
            lblNumTotal.Text = total.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetail.SelectedRows.Count > 0)
            {
                orderDetails[dgvOrderDetail.SelectedRows[0].Index].Quantity += 1;
            }
            countTotal();
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
    }
}
