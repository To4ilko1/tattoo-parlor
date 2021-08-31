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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            BranchCmbBx.Validating += BranchCmbBx_Validating;
        }
        private void BranchCmbBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(BranchCmbBx.Text))
            {
                error1.SetError(BranchCmbBx, "Не указан филиал");
                SearchBtn.Enabled = false;
            }
            else
            {
                error1.Clear();
                SearchBtn.Enabled = true;
            }
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            FillForm();
        }
        public void FillBranchCmbx()
        {
            BranchCmbBx.Items.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                foreach (Branch b in db.Branch.Where(x => x.DeleteTime == null).ToList())
                {
                    BranchCmbBx.Items.Add(b.Name);
                }
                BranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                BranchCmbBx.SelectedIndex = 0;
            }
        }
        private void FillForm()
        {
            FillBranchCmbx();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int branchid = 0;
            using (ClientEntities db = new ClientEntities())
            {
                Branch temp = db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>();
                branchid = Convert.ToInt16(temp.Id);
                List<BranchMaterials> bm = db.BranchMaterials.Where(x => x.BranchID == temp.Id && x.DeleteTime == null).ToList();
            }
            FillDataGridView(branchid);
        }
        private void FillDataGridView(int BrId)
        {
            string datestart = Convert.ToString(dateTimePicker1.Value);
            string[] datewithtime = datestart.Split(' ');
            string[] date = datewithtime[0].Split('.');
            string result = date[2] + '-' + date[1] + '-' + date[0];//2018-12-05
            string dateend = Convert.ToString(dateTimePicker2.Value);
            string[] datewithtime1 = dateend.Split(' ');
            string[] date1 = datewithtime1[0].Split('.');
            string result1 = date1[2] + '-' + date1[1] + '-' + date1[0];//2018-12-05
            ExpensesGridView.Rows.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
              //  var date1 = t;
                string commandText = @"SELECT Material.Name as Material,SUM(BranchMaterials.CountPerPiece) As PerPiece,SUM(BranchMaterials.CountForTheAmount) as ForTheAmount FROM [Session] 
				INNER JOIN [Branch] on  Session.BranchID= Branch.Id 
                INNER JOIN [BranchMaterials] on  BranchMaterials.BranchID= Branch.Id
                INNER JOIN [Material] on  Material.Id= BranchMaterials.MaterialID 				
                WHERE  Branch.Id = " + BrId+ " and BranchMaterials.AddOrDelete =0 and (Session.TimeStart>= '"+result+ "' AND Session.TimeEnd<= '" + result1 + "') GROUP BY BranchMaterials.MaterialID";
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
               // Connect.Close();
                foreach (string[] s in data)
                    ExpensesGridView.Rows.Add(s);
                // dataSet.Load(Command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                // ExpensesGridView.DataSource = dataSet.Tables["Table"];
                Connect.Close();
            }
        }
    }
}
