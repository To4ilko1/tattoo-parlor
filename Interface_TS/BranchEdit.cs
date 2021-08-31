using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_TS
{
    public partial class BranchEdit : Form
    {
        public BranchEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int backid;
        public int BackId //////////////////////////
        {
            get { return backid; }
            set { backid = value; }
        }
        private int CountCabinets()
        {
            int count = 0;
            using (ClientEntities db = new ClientEntities())
            {
                List<Cabinet> cabinets = db.Cabinet.Where(x => x.DeleteTime == null && x.BranchID == id).ToList();
                count = cabinets.Count;
            }
            return count;
        }
        public void FillDataGridView()
        {
            using (ClientEntities db = new ClientEntities())
            {
                BranchMaterialDataGrid1.Rows.Clear();
                List<BranchMaterials> bm = db.BranchMaterials.Where(x => x.BranchID == id).ToList();

            
                foreach (BranchMaterials s in bm)
                {
                    Material mat = db.Material.Where(x => x.Id == s.MaterialID).FirstOrDefault<Material>();
                    BranchMaterialDataGrid1.Rows.Add(mat.Name, s.CountPerPiece, s.CountForTheAmount);
                }
                BranchMaterialDataGrid1.Enabled = false;
            }
        }
        private void SaveBranchBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Branch.Find(id) == null)
                {
                    Branch b = new Branch();
                    b.Id = id;
                    b.Name = textBox1.Text;
                    b.Phone = textBox3.Text;
                    b.Address = textBox2.Text;
                    b.CountCabinets = CountCabinets();
                    db.Branch.Add(b);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    Branch temp = db.Branch.Where(x => x.Id == id).FirstOrDefault<Branch>();
                    temp.Name = textBox1.Text;
                    temp.Phone = textBox3.Text;
                    temp.Address = textBox2.Text;
                    temp.CountCabinets = CountCabinets();
                    db.SaveChanges();
                    this.Close();
                }
            }
        }

        private void BranchEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Branch.Find(id) != null)
                {
                    Branch temp = db.Branch.Where(x => x.Id == id).FirstOrDefault<Branch>();
                    textBox1.Text = temp.Name;
                    textBox2.Text = temp.Address;
                    textBox3.Text = temp.Phone;
                    FillDataGridView();
                }
                else
                {
                    Branch c = new Branch();
                    c.Id = db.Branch.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "Филиал \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Адрес \n"; v = false; }
            if (textBox3.Text == "") { error.SetError(textBox3, "Заполните поле!"); message += "Телефон \n"; v = false; }
            if (v == false)
            {
                DialogResult result = MessageBox.Show(
                "Заполните поля: " + message,
                "Ошибка сохранения!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
            return v;
        }
    }
}
