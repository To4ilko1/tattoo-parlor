using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Interface_TS
{
    public partial class ExpensesByServices : Form
    {
        public ExpensesByServices()
        {
            InitializeComponent();
            ServiceCmbBx.Validating += BranchCmbBx_Validating;
        }
        private void BranchCmbBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ServiceCmbBx.Text))
            {
                error1.SetError(ServiceCmbBx, "Не указана услуга");
                SearchBtn.Enabled = false;
            }
            else
            {
                error1.Clear();
                SearchBtn.Enabled = true;
            }
        }
        public void FillServiceCmbx()
        {
            ServiceCmbBx.Items.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                foreach (Service s in db.Service.Where(x => x.DeleteTime == null).ToList())
                {
                    ServiceCmbBx.Items.Add(s.Name);
                }
                ServiceCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                ServiceCmbBx.SelectedIndex = 0;
            }
        }
        private void FillForm()
        {
            FillServiceCmbx();
        }


        private void FillDataGridView(int SrId)
        {
            string datestart = Convert.ToString(dateTimePicker1.Value);
            string[] datewithtime = datestart.Split(' ');
            string[] date = datewithtime[0].Split('.');
            string result = date[2] + '-' + date[1] + '-' + date[0];//2018-12-05
            string dateend = Convert.ToString(dateTimePicker2.Value);
            string[] datewithtime1 = dateend.Split(' ');
            string[] date1 = datewithtime1[0].Split('.');
            string result1 = date1[2] + '-' + date1[1] + '-' + date1[0];//2018-12-05
            ExpensesServiceGridView.Rows.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT Material.Name as Material,SUM(ServiceMaterials.CountPerPiece) As PerPiece,SUM(ServiceMaterials.CountForTheAmount) as ForTheAmount FROM [Session] 
				INNER JOIN [SessionServices] on  Session.Id= SessionServices.SessionID 
				INNER JOIN [Service] on  Service.Id= SessionServices.ServiceID 
				INNER JOIN [ServiceMaterials] on  SessionServices.ServiceID= ServiceMaterials.ServiceID
                INNER JOIN [Material] on  Material.Id= ServiceMaterials.MaterialID 
                WHERE  Service.Id = " + SrId + " and (Session.TimeStart>= '" + result + "' AND Session.TimeEnd<= '" + result1 + "') GROUP BY ServiceMaterials.MaterialID";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                DataSet dataSet = new DataSet();
                DataTable table = dataSet.Tables.Add("Table");
                IDataReader reader = Command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[3]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                }
                reader.Close();
                foreach (string[] s in data)
                    ExpensesServiceGridView.Rows.Add(s);
                Connect.Close();
            }
        }

        private void ExpensesByServices_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int serviceid = 0;
            using (ClientEntities db = new ClientEntities())
            {
                Service temp = db.Service.Where(x => x.Name == ServiceCmbBx.Text).FirstOrDefault<Service>();
                serviceid = Convert.ToInt16(temp.Id);
                List<ServiceMaterials> bm = db.ServiceMaterials.Where(x => x.ServiceID == temp.Id && x.DeleteTime == null).ToList();/////////////////////
            }
            FillDataGridView(serviceid);
        }
    }
}
