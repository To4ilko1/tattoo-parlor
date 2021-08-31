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
    public partial class AddMaterialCount : Form
    {
        public AddMaterialCount()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int serid;
        public int Serviceid
        {
            get { return serid; }
            set { serid = value; }
        }
        private int stat;
        public int Status
        {
            get { return stat; }
            set { stat = value; }
        }
        private bool saveornot;
        private int matid;
        public int Materialid
        {
            get { return matid; }
            set { matid = value; }
        }
        private void ChooseMaterial_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Refresh1();
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить материал";
              //  TP.MaterialId = id;
             //   matid = id;
                if (stat != 2)
                {
                    TP.FormStatus = 3;
                }
                else
                {
                    TP.FormStatus = 4;
                }            
                TP.ShowDialog();
                matid = TP.MaterialId;
                linkLabel1.Visible = true;
                if (db.Material.Find(TP.MaterialId) != null)
                {
                    linkLabel1.Text = db.Material.Find(TP.MaterialId).Name;
                    if (db.Material.Find(TP.MaterialId).CostPerPiece == null)
                    {
                        CostPerPieceTxtBx.Enabled = false;
                        TheCostForTheAmountTxtBx.Enabled = true;
                    }
                    if (db.Material.Find(TP.MaterialId).TheCostForTheAmount == null)
                    {
                        TheCostForTheAmountTxtBx.Enabled = false;
                        CostPerPieceTxtBx.Enabled = true;
                    }
                }
            }
        }
        private void SaveMaterialCountInBranch_Click(object sender, EventArgs e)
        {           
            using (ClientEntities db = new ClientEntities())
            {               
                if (Validation())
                {
                    if (stat != 2)
                    {
                        saveornot = true;
                        if (saveornot)
                        {
                            Material temp = db.Material.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Material>();
                            BranchMaterials b = new BranchMaterials();
                            b.MaterialID = db.Material.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Material>().Id;
                            b.BranchID = id;
                            if (TheCostForTheAmountTxtBx.Text != "") b.CountForTheAmount = Convert.ToDouble(TheCostForTheAmountTxtBx.Text);
                            else b.CountForTheAmount = null;
                            if (CostPerPieceTxtBx.Text != "") b.CountPerPiece = Convert.ToInt16(CostPerPieceTxtBx.Text);
                            else b.CountPerPiece = null;
                            b.Date = DateTime.Now;
                            b.AddOrDelete = true;
                            db.BranchMaterials.Add(b);
                            db.SaveChanges();
                            Refresh1();
                            
                        }
                    }
                    else
                    {
                        saveornot = true;//вдруг существует просто дэлит тайм не нуль
                        if (saveornot)
                        {
                            ServiceMaterials b = new ServiceMaterials();
                            b.MaterialID = matid;
                            b.ServiceID = serid;
                            if (TheCostForTheAmountTxtBx.Text != "")
                            {
                                b.CountForTheAmount = Convert.ToDouble(TheCostForTheAmountTxtBx.Text);
                            }
                            else
                            {
                                b.CountForTheAmount = null;
                            }
                            if (CostPerPieceTxtBx.Text != "")
                            {
                                b.CountPerPiece = Convert.ToInt16(CostPerPieceTxtBx.Text);
                            }
                            else
                            {
                                b.CountPerPiece = null;
                            }
                            if (!db.ServiceMaterials.Any(x => x.MaterialID.Equals(matid) && x.ServiceID.Equals(serid)))
                            {
                                db.ServiceMaterials.Add(b);
                            }
                            else
                            {
                                ServiceMaterials tem = db.ServiceMaterials.Where(x => x.ServiceID == serid && x.MaterialID == matid).FirstOrDefault();
                                tem.DeleteTime = null;
                                if (TheCostForTheAmountTxtBx.Text != "") tem.CountForTheAmount = Convert.ToDouble(TheCostForTheAmountTxtBx.Text);
                                else b.CountForTheAmount = null;
                                if (CostPerPieceTxtBx.Text != "") tem.CountPerPiece = Convert.ToInt16(CostPerPieceTxtBx.Text);
                                else b.CountPerPiece = null;
                            }
                            db.SaveChanges();
                            Refresh1();
                        }
                    }
                    this.Close();
                }
            }
        }
        private void Refresh1()
        {
            saveornot = false;
            linkLabel1.Text = "";
            CostPerPieceTxtBx.Text = "";
            TheCostForTheAmountTxtBx.Text = "";
            TheCostForTheAmountTxtBx.Clear();
            TheCostForTheAmountTxtBx.Enabled = false;
            CostPerPieceTxtBx.Clear();
            CostPerPieceTxtBx.Enabled = false;
            linkLabel1.Visible = false;
        }

        private void AddMaterialCount_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
        private bool Validation() //true - все норм false - ошибки
        {
            using (ClientEntities db = new ClientEntities())
            {
                string message = "\n";
                bool v = true;
                if (TheCostForTheAmountTxtBx.Enabled == false && CostPerPieceTxtBx.Text == "") { error.SetError(CostPerPieceTxtBx, "Заполните поле!"); message += "Стоимость за штуку\n"; v = false; }
                if (CostPerPieceTxtBx.Enabled == false && TheCostForTheAmountTxtBx.Text == "") { error.SetError(TheCostForTheAmountTxtBx, "Заполните поле!"); message += "Стоимость за минимальный объем\n"; v = false; }
             //   if (TheCostForTheAmountTxtBx.Enabled == false) { error.SetError(linkLabel1, "Заполните поле!"); message += "Наименование материала\n"; v = false; }
                if (linkLabel1.Text == "") { error.SetError(linkLabel1, "Заполните поле!"); message += "Наименование материала\n"; v = false; }
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
}
