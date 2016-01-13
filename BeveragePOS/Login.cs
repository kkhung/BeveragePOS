using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class Login : Form
    {
        private bool isCloseable = false;
        private BeveragePOSDataContext dataContext = new BeveragePOSDataContext();
        private Main main;

        public Login(Main main)
        {
            InitializeComponent();
            // 用以存取 Main 表單上的 employee 屬性
            this.main = main;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "請輸入員工編號及密碼";
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (isCloseable) ? false : true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int employeeID = -1;
            if (int.TryParse(txtEmployeeID.Text, out employeeID))
            {
                // 以 employeeID 為條件查詢資料庫
                var employee = from em in dataContext.Employee where em.ID == employeeID select em;
                // 判斷有無查詢結果並確認密碼是否正確
                if (employee.Count() == 1 && txtEmployeePassword.Text == employee.Single().Password)
                {
                    // 將查詢結果填入 Main 表單上的 employee 屬性
                    main.employee = employee.Single();
                    // 設定登入訊息
                    main.setSystemLog("登入");
                    // 開啟關閉功能並關閉 Login 表單
                    isCloseable = true;
                    Close();
                }
            }
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
            // 開啟關閉功能並結束程式
            isCloseable = true;
            main.isCloseable = true;
            Application.Exit();
        }
    }
}
