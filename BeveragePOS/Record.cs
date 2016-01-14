using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BeveragePOS
{
    public partial class Record : Form
    {
        private BeveragePOSDataContext dataContext = new BeveragePOSDataContext();

        private BindingList<string> getOrderDetails(int orderMasterID)
        {
            // 從資料庫中取得訂單明細
            var results = from od in dataContext.OrderDetail where od.OrderMasterID == orderMasterID select od;
            List<string> orderDetails = new List<string>();
            foreach (OrderDetail orderDetail in results)
            {
                orderDetails.Add(orderDetail.BeverageName + "\t甜度 " + orderDetail.Sugar + "\t冰塊 " + orderDetail.Ice + "\t" + orderDetail.Quantity + " 杯");
            }
            return new BindingList<string>(orderDetails);
        }

        private BindingList<string> getOrderMasters()
        {
            // 從資料庫中取得訂單主檔
            var results = from om in dataContext.OrderMaster where om.DateTime.Day >= dtpTradeLogBegin.Value.Day && om.DateTime.Day <= dtpTradeLogEnd.Value.Day select om;
            List<string> orderMasters = new List<string>();
            foreach (OrderMaster orderMaster in results)
            {
                int total = 0;
                foreach (OrderDetail orderDetail in orderMaster.OrderDetail)
                {
                    total += orderDetail.Beverage.Price * orderDetail.Quantity;
                }
                orderMasters.Add(orderMaster.ID + ". 於 " + orderMaster.DateTime + " 由 " + orderMaster.Employee.Name + " 經手 " + total + " 元");
            }
            return new BindingList<string>(orderMasters);
        }

        private BindingList<string> getSystemLogs()
        {
            // 從資料庫中取得系統記錄
            var results = from sl in dataContext.SystemLog where sl.DateTime.Day >= dtpSystemLogBegin.Value.Day && sl.DateTime.Day <= dtpSystemLogEnd.Value.Day select sl;
            List<string> systemLogs = new List<string>();
            foreach (SystemLog systemLog in results)
            {
                systemLogs.Add(systemLog.ID + ". " + systemLog.EmployeeID + " " + systemLog.Employee.Name + " 於 " + systemLog.DateTime + " 登入");
            }
            return new BindingList<string>(systemLogs);
        }

        public Record()
        {
            InitializeComponent();
        }

        private void Record_Load(object sender, EventArgs e)
        {
            // 設定 ListBox 的資料來源
            lstSystemLog.DataSource = getSystemLogs();
            lstTradeLog.DataSource = getOrderMasters();
        }

        private void dtpSystemLog_ValueChanged(object sender, EventArgs e)
        {
            // 重設資料來源
            lstSystemLog.DataSource = getSystemLogs();
        }

        private void dtpTradeLog_ValueChanged(object sender, EventArgs e)
        {
            // 重設資料來源
            lstTradeLog.DataSource = getOrderMasters();
        }

        private void lstTradeLog_DoubleClick(object sender, EventArgs e)
        {
            if (btnReturn.Visible == false)
            {
                string selectedString = lstTradeLog.SelectedItem as string;
                int orderMasterID = int.Parse(selectedString.Substring(0, selectedString.IndexOf(".")));
                // 顯示訂單明細資料
                lstTradeLog.DataSource = getOrderDetails(orderMasterID);
                btnReturn.Visible = true;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // 顯示訂單主檔資料
            lstTradeLog.DataSource = getOrderMasters();
            btnReturn.Visible = false;
        }
    }
}
