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
    public partial class CabinetCard : Form
    {
        public CabinetCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        public void FillListBox()
        {
            using (ClientEntities db = new ClientEntities())
            {
                CabinetServicesListBx.Items.Clear();
                List<CabinetServices> cabinetlist = db.CabinetServices.Where(x => x.DeleteTime == null && x.CabinetID == id).ToList();
                foreach (CabinetServices cp in cabinetlist)
                {
                    CabinetServicesListBx.Items.Add(db.Service.Find(cp.ServiceID).Name);
                }
            }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Cabinet temp = db.Cabinet.Where(x => x.Id == this.id).FirstOrDefault<Cabinet>();
                CabinetNameLbl.Text = temp.Name;
                DescriptionLbl.Text = temp.Description;
                if (temp.BranchID != 0)
                    CabinetBranchLbl.Text = temp.Branch.Name;
                else CabinetBranchLbl.Text = "";
                FillListBox();
            }
        }
        private void EditCabinetBtn_Click(object sender, EventArgs e)
        {
            CabinetEdit ct = new CabinetEdit();
            ct.Currentid = id;
            ct.ShowDialog();
            Refresh1();
        }
        private void DeleteCabinetBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить услугу?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<CabinetServices> cs = db.CabinetServices.Where(x => x.CabinetID == id && x.DeleteTime == null).ToList();
                    foreach (CabinetServices cabinet in cs)
                    {
                        cabinet.DeleteTime = DateTime.Now;
                    }
                    Cabinet c = db.Cabinet.Where(x => x.Id == id).FirstOrDefault<Cabinet>();
                    c.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }
               
            }
        }
        private void CabinetCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
    }
}
