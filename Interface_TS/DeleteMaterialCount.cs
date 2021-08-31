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
    public partial class DeleteMaterialCount : Form
    {
        public DeleteMaterialCount()
        {
            InitializeComponent();
            linkLabel1.Validating += linkLabel1_Validating;
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int materialid;
        public int Materialid
        {
            get { return materialid; }
            set { materialid = value; }
        }
        private bool saveornot;
        private void linkLabel1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(linkLabel1.Text))
            {
                error.SetError(linkLabel1, "Не указан материал");
                SaveMaterialCountInBranch.Enabled = false;
            }
            else
            {
                error.Clear();
                SaveMaterialCountInBranch.Enabled = true;
            }
        }
        private void ChooseMaterial_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Refresh1();
                TattooParlor TP = new TattooParlor();
                TP.Text = "Списать материал";
                TP.MaterialId = id;
                materialid = id;
                TP.FormStatus = 3;
                TP.ShowDialog();
                linkLabel1.Visible = true;
                linkLabel1.Text = db.Material.Find(TP.MaterialId).Name;
                if (db.Material.Find(TP.MaterialId).CostPerPiece == null)
                {
                    TheCostForTheAmountTxtBx.Enabled = true;
                    CostPerPieceTxt.Enabled = false;
                }
                if (db.Material.Find(TP.MaterialId).TheCostForTheAmount == null)
                {
                    CostPerPieceTxt.Enabled = true;
                    TheCostForTheAmountTxtBx.Enabled = false;
                }
            }
        }
        private void Refresh1()
        {
            saveornot = false;
            linkLabel1.Text = "";
            CostPerPieceTxt.Text = "";
            TheCostForTheAmountTxtBx.Text = "";
            CostPerPieceTxt.Clear();
            CostPerPieceTxt.Enabled = false;
            TheCostForTheAmountTxtBx.Clear();
            TheCostForTheAmountTxtBx.Enabled = false;
            linkLabel1.Visible = false;
        }

        private void DeleteMaterialCount_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
        private void SaveForm()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Material temp = db.Material.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Material>();
                if (db.BranchMaterials.Any(x => x.BranchID.Equals(id) && x.MaterialID.Equals(temp.Id) && x.DeleteTime == null))////////////
                {
                    BranchMaterials b = new BranchMaterials();
                    b.MaterialID = db.Material.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Material>().Id;
                    b.BranchID = id;
                    if (TheCostForTheAmountTxtBx.Text != "") b.CountForTheAmount = Convert.ToDouble(TheCostForTheAmountTxtBx.Text);
                    else b.CountForTheAmount = null;
                    if (CostPerPieceTxt.Text != "") b.CountPerPiece = Convert.ToInt16(CostPerPieceTxt.Text);
                    else b.CountPerPiece = null;
                    b.Date = DateTime.Now;
                    b.AddOrDelete = false;
                    db.BranchMaterials.Add(b);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Тату салон");

                }
                else
                {
                    MessageBox.Show("В данном филиале нет такого материала. Списание невозможно.", "Тату салон");
                }
                Refresh1();
            }
        }
            
        
        private void SaveMaterialCountInBranch_Click(object sender, EventArgs e)
        {         
                Check();          
        }
        private void Check()
        {
            using (ClientEntities db = new ClientEntities())
            {
                bool b;
                Material temp = db.Material.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Material>();
                List<BranchMaterials> bm = db.BranchMaterials.Where(x => x.BranchID == id && x.MaterialID == temp.Id).ToList();
                b = GetSum(bm);
                if (b)
                {
                    SaveForm();
                }
                else
                {
                    MessageBox.Show("В данном филиале материала в таком количестве. Списание невозможно.", "Тату салон");
                }          
            }
        }
        private bool GetSum(List<BranchMaterials> bm)//true -все нормальн, false-нельзя списать такое количество материала
        {
            bool bo;
            double sum = 0;
            foreach (BranchMaterials b in bm)
            {
                if (b.CountForTheAmount == null)
                {
                    if (Convert.ToBoolean(b.AddOrDelete))
                    {
                        sum = sum + Convert.ToDouble(b.CountPerPiece);
                    }
                    else
                    {
                        sum = sum - Convert.ToDouble(b.CountPerPiece);
                    }
                }
                if (b.CountPerPiece == null)
                {
                    if (Convert.ToBoolean(b.AddOrDelete))
                    {
                        sum = sum + Convert.ToDouble(b.CountForTheAmount);
                    }
                    else
                    {
                        sum = sum - Convert.ToDouble(b.CountForTheAmount);
                    }
                }
            }
            if (sum > 0)
                bo = true;
            else
                bo = false;
            return bo;
        }
        private bool Validation() //true - все норм false - ошибки
        {
            using (ClientEntities db = new ClientEntities())
            {
                string message = "\n";
                bool v = true;
                if (TheCostForTheAmountTxtBx.Enabled == false && CostPerPieceTxt.Text == "") { error.SetError(CostPerPieceTxt, "Заполните поле!"); message += "Стоимость за штуку\n"; v = false; }
                if (CostPerPieceTxt.Enabled == false && TheCostForTheAmountTxtBx.Text == "") { error.SetError(TheCostForTheAmountTxtBx, "Заполните поле!"); message += "Стоимость за минимальный объем\n"; v = false; }
                if (linkLabel1.Text == "") { error.SetError(linkLabel1, "Заполните поле!"); message += "Наименование материала\n"; v = false; }
                if (v == false)
                {
                    DialogResult result = MessageBox.Show(
                    "Заполните поля: " + message,
                    "Ошибка сохранения!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1);
                   // MessageBoxOptions.DefaultDesktopOnly);
                }
                return v;
            }
        }
    }
}
