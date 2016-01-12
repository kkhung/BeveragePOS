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
            // DialogResult 等於 Cancel （預設）時鎖定關閉鈕
            e.Cancel = (DialogResult != DialogResult.Cancel) ? false : true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int employeeID = -1;
            if (int.TryParse(txtEmployeeID.Text, out employeeID))
            {
                // 以 employeeID 為條件查詢資料庫
                var results = from employee in dataContext.Employee where employee.ID == employeeID select new { employee.ID, employee.Name, employee.Password, employee.hasSuperRight };
                // 判斷有無查詢結果並確認密碼是否正確
                if (results.Count() == 1 && txtEmployeePassword.Text == results.Single().Password)
                {
                    // 將查詢結果填入 Main 表單上的 employee 屬性
                    main.employee.ID = results.Single().ID;
                    main.employee.Name = results.Single().Name;
                    main.employee.Password = results.Single().Password;
                    main.employee.hasSuperRight = results.Single().hasSuperRight;
                    // 設定 DialogResult 並關閉 Login 表單
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            lblMessage.Text = "會員編號或密碼錯誤";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 設定 DialogResult 並結束程式
            DialogResult = DialogResult.None;
            main.Close();
        }
    }
}
