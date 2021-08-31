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
    public partial class MaterialCard : Form
    {
        public MaterialCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Material temp = db.Material.Where(x => x.Id == this.id).FirstOrDefault<Material>();
                MaterialNameLbl.Text = temp.Name;
                MaterialNameOfSupplierLbl.Text = temp.NameOfSupplier;
                MaterialCostPerPieceLbl.Text = Convert.ToString(temp.CostPerPiece);
                MaterialTheCostForTheAmountLbl.Text = Convert.ToString(temp.TheCostForTheAmount);
                MaterialDescriptionLbl.Text = temp.Description;
                FillDataGridView();
                //BranchMaterialDataGrid.Rows.Clear();
                //List<BranchMaterials> sm = db.BranchMaterials.Where(x => x.MaterialID == id).ToList();
                //foreach (BranchMaterials s in sm)
                //{        
                //    Branch bran = db.Branch.Where(x => x.Id == s.BranchID).FirstOrDefault<Branch>();
                //    double amount=0; double piece=0;
                //    if (s.AddOrDelete == false)
                //    {          
                //        if (s.CountForTheAmount != null) amount = Convert.ToDouble(-s.CountForTheAmount);
                //        if (s.CountPerPiece != null) piece = Convert.ToDouble(-s.CountPerPiece);
                //    }
                //    else
                //    {
                //        if (s.CountForTheAmount != null) amount = Convert.ToDouble(s.CountForTheAmount);
                //        if (s.CountPerPiece != null) piece = Convert.ToDouble(s.CountPerPiece);
                //    }
                //    BranchMaterialDataGrid.Rows.Add(bran.Name, amount, piece);
                //}
                //BranchMaterialDataGrid.Enabled = false;
            }
        }
        private void FillDataGridView()
        {
            BranchMaterialDataGrid.Rows.Clear();
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT Service.Name as Service,SUM(ServiceMaterials.CountPerPiece) As PerPiece,
 SUM(ServiceMaterials.CountForTheAmount) as ForTheAmount FROM [Material] 
                    INNER JOIN [ServiceMaterials] on  ServiceMaterials.MaterialID= Material.Id
					INNER JOIN [Service] on  ServiceMaterials.ServiceID= Service.Id
					INNER JOIN [SessionServices] on  SessionServices.ServiceID= Service.Id			
                    WHERE  Material.Id = " + this.id + " GROUP BY ServiceMaterials.ServiceID";
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
        private void EditBtn_Click(object sender, EventArgs e)
        {
            MaterialEdit me = new MaterialEdit();
            me.Currentid = id;
            me.ShowDialog();
            Refresh1();
        }
        private void DeleteMaterialBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить материал?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Material c = db.Material.Where(x => x.Id == id).FirstOrDefault<Material>();
                    c.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        private void MaterialCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
    }
}
