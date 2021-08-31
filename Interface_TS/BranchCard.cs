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
    public partial class BranchCard : Form
    {
        public BranchCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private double GetSum(List<BranchMaterials> bm)//для каждого материала в этом филиале высчитывает конечную сумму
        {
            using (ClientEntities db = new ClientEntities())
            {
                double sum = 0;
                foreach (BranchMaterials b in bm)
                {
                    List<BranchMaterials> listbm = db.BranchMaterials.Where(x => x.MaterialID == b.MaterialID && x.BranchID == b.MaterialID && x.DeleteTime == null).ToList();
                    foreach (BranchMaterials br in listbm)
                    {
                        if (br.CountForTheAmount == null)
                        {
                            if (Convert.ToBoolean(br.AddOrDelete))
                            {
                                sum = sum + Convert.ToDouble(br.CountPerPiece);
                            }
                            else
                            {
                                sum = sum - Convert.ToDouble(br.CountPerPiece);
                            }
                        }
                        if (br.CountPerPiece == null)
                        {
                            if (Convert.ToBoolean(br.AddOrDelete))
                            {
                                sum = sum + Convert.ToDouble(br.CountForTheAmount);
                            }
                            else
                            {
                                sum = sum - Convert.ToDouble(br.CountForTheAmount);
                            }
                        }
                    }
                }
                return sum;
            }
        }
        private void FillDataGridView()
        {
            BranchMaterialDataGrid.Rows.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT Material.Name as Material,SUM((CASE  WHEN BranchMaterials.AddOrDelete =1 THEN BranchMaterials.CountPerPiece ELSE -BranchMaterials.CountPerPiece END)) As PerPiece, SUM((CASE  WHEN BranchMaterials.AddOrDelete =1 THEN BranchMaterials.CountForTheAmount ELSE -BranchMaterials.CountForTheAmount END)) as ForTheAmount FROM [Branch] 
                    INNER JOIN [BranchMaterials] on  BranchMaterials.BranchID= Branch.Id
					INNER JOIN [Material] on  BranchMaterials.MaterialID= Material.Id
                    WHERE  Branch.Id = " + this.id + " GROUP BY BranchMaterials.MaterialID";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                DataSet dataSet = new DataSet();
                DataTable table = dataSet.Tables.Add("Table1");
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
                    BranchMaterialDataGrid.Rows.Add(s);
                Connect.Close();
            }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Branch temp = db.Branch.Where(x => x.Id == this.id).FirstOrDefault<Branch>();
                BranchNameLbl.Text = temp.Name;
                BranchAddressLbl.Text = temp.Address;
                BranchPhoneLbl.Text = temp.Phone;
                FillDataGridView();
            }
        }
        private void EditBranchBtn_Click(object sender, EventArgs e)
        {
            BranchEdit branchedit = new BranchEdit();
            branchedit.Currentid = id;
            branchedit.ShowDialog();
            Refresh1();
        }
        private void DeleteBranchBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить услугу?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Branch w = db.Branch.Where(x => x.Id == id).FirstOrDefault<Branch>();
                    w.DeleteTime = DateTime.Now;
                    List<Cabinet> c = db.Cabinet.Where(x => x.BranchID == id).ToList();
                    foreach (Cabinet cab in c)
                    {
                        cab.DeleteTime = DateTime.Now;
                    }
                    List<BranchMaterials> bm = db.BranchMaterials.Where(x => x.BranchID == id).ToList();
                    foreach (BranchMaterials brmat in bm)
                    {
                        brmat.DeleteTime = DateTime.Now;
                    }
                    db.SaveChanges();
                    this.Close();
                }               
            }
        }

        private void BranchCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
        private void AddMaterialInBranch_Click(object sender, EventArgs e)
        {
            AddMaterialCount adc = new AddMaterialCount();
            adc.Currentid = id;
            adc.ShowDialog();
            FillDataGridView();
        }

        private void DeleteMaterialFromBranch_Click(object sender, EventArgs e)
        {
            DeleteMaterialCount dmc = new DeleteMaterialCount();
            dmc.Currentid = id;
            dmc.ShowDialog();
            FillDataGridView();
        }
    }
}
