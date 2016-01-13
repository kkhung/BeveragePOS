using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class Login : Form
    {
        private BeveragePOSDataContext dataContext = new BeveragePOSDataContext();
        private Main main;
        private bool isCloseable = false;

        public Login(Main main)
        {
            InitializeComponent();
            // 用以存取 Main 表單上的 employee 屬性
            this.main = main;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // 提示訊息
            lblMessage.Text = "請輸入員工編號及密碼";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 鎖定表單的關閉功能
            e.Cancel = (isCloseable) ? false : true;
        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            // 輸入文字時清空訊息
            lblMessage.Text = "";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // 以 employeeID 為條件查詢資料庫
            var results = from em in dataContext.Employee where em.ID == txtEmployeeID.Text select em;
            // 判斷有無查詢結果並確認密碼是否正確
            if (results.Count() == 1 && txtEmployeePassword.Text == results.Single().Password)
            {
                Employee employee = results.Single();
                // 將查詢結果填入 Main 表單上的 employee 屬性
                main.employee = employee;
                // 設定歡迎訊息
                main.lblMessage.Text = "歡迎使用本系統";
                // 設定員工姓名
                main.lblEmployeeContent.Text = employee.Name;
                // 設定登入記錄
                main.setSystemLog("登入");
                // 開啟關閉功能並關閉 Login 表單
                isCloseable = true;
                Close();
                // 進入 Main 表單
            }
            // 錯誤訊息
            if (txtEmployeeID.Text == "" || txtEmployeePassword.Text == "")
            {
                lblMessage.Text = "帳號或密碼不能空白";
            }
            else
            {
                lblMessage.Text = "帳號或密碼錯誤";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // 開啟表單的關閉功能並結束程式
            isCloseable = true;
            main.isCloseable = true;
            Application.Exit();
        }
    }
}
