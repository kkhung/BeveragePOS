using System;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class RingUp : Form
    {
        private int total;

        public RingUp(int total)
        {
            InitializeComponent();
            // 從 Main 表單取得小計
            this.total = total;
        }
        
        private void RingUp_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btnNumber = sender as Button;
            // 顯示數字
            txtChargeMoney.Text = txtChargeMoney.Text + btnNumber.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清空數字
            txtChargeMoney.Clear();
            lblChangeMoney.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 關閉表單
            Close();
        }

        private void txtChargeMoney_TextChanged(object sender, EventArgs e)
        {
            int money = 0;
            // 將收銀的文字轉換成數字
            if (int.TryParse(txtChargeMoney.Text, out money))
            {
                // 判斷收銀是否大於小計
                if (money > total)
                {
                    // 計算找零
                    lblChangeMoney.Text = money - total + " 元";
                }
            }
        }
    }
}
