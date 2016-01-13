using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class Record : Form
    {
        private BeveragePOSDataContext dataContext = new BeveragePOSDataContext();
        private BindingList<string> log = new BindingList<string>();
        private BindingList<string> trade = new BindingList<string>();

        public Record()
        {
            InitializeComponent();
        }

        private void getLog()
        {
            log.Clear();
            var results = from systemLog in dataContext.SystemLog where systemLog.DateTime.Day >= dateTimePicker1.Value.Day && systemLog.DateTime.Day <= dateTimePicker2.Value.Day select new { systemLog.ID, systemLog.Employee.Name, systemLog.DateTime, systemLog.Description };
            foreach (var result in results)
            {
                log.Add(result.ID + ". " + result.Name + " 於 " + result.DateTime + " " + result.Description + "。");
            }
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'beveragePOSDataSet.OrderMaster' 資料表。您可以視需要進行移動或移除。
            this.orderMasterTableAdapter.Fill(this.beveragePOSDataSet.OrderMaster);
            // TODO: 這行程式碼會將資料載入 'beveragePOSDataSet.OrderDetail' 資料表。您可以視需要進行移動或移除。
            this.orderDetailTableAdapter.Fill(this.beveragePOSDataSet.OrderDetail);
            getLog();
            listBox1.DataSource = log;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getLog();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            getLog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
