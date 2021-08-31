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
    public partial class ServiceCard : Form
    {
        public ServiceCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        public void FillDataGridView()
        {
            using (ClientEntities db = new ClientEntities())
            {
                ServiceMaterialDataGrid.Rows.Clear();
                List<ServiceMaterials> sm = db.ServiceMaterials.Where(x => x.ServiceID == id).ToList();
                foreach (ServiceMaterials s in sm)
                {
                    Material mat = db.Material.Where(x => x.Id == s.MaterialID).FirstOrDefault<Material>();
                    ServiceMaterialDataGrid.Rows.Add(mat.Name, s.CountPerPiece, s.CountForTheAmount);
                }
                ServiceMaterialDataGrid.Enabled = false;
            }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Service temp = db.Service.Where(x => x.Id == this.id).FirstOrDefault<Service>();
                ServiceNameLbl.Text = temp.Name;
                ServicePriceLbl.Text = Convert.ToString(temp.Price);
                ServiceTimeLbl.Text = Convert.ToString(temp.Time);
                DescriptionTxt.Text = temp.Description;
                DescriptionTxt.ReadOnly = true;
                FillDataGridView();
            }
        }
        private void EditServiceBtn_Click(object sender, EventArgs e)
        {
            ServiceEdit serviceedit = new ServiceEdit();
            serviceedit.Currentid = id;
            serviceedit.ShowDialog();
            Refresh1();
        }
        private void DeleteServiceBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить услугу?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<CabinetServices> cs = db.CabinetServices.Where(x => x.ServiceID == id && x.DeleteTime == null).ToList();
                    foreach (CabinetServices service in cs)
                    {
                        service.DeleteTime = DateTime.Now;
                    }
                    List<ServiceMaterials> sm = db.ServiceMaterials.Where(x => x.ServiceID == id && x.DeleteTime == null).ToList();
                    foreach (ServiceMaterials service in sm)
                    {
                        service.DeleteTime = DateTime.Now;
                    }
                    List<ServiceWorkers> sw = db.ServiceWorkers.Where(x => x.ServiceID == id && x.DeleteTime == null).ToList();
                    foreach (ServiceWorkers service in sw)
                    {
                        service.DeleteTime = DateTime.Now;
                    }
                    List<SessionServices> ss = db.SessionServices.Where(x => x.ServiceID == id && x.DeleteTime == null).ToList();
                    foreach (SessionServices service in ss)
                    {
                        service.DeleteTime = DateTime.Now;
                    }
                    Service c = db.Service.Where(x => x.Id == id).FirstOrDefault<Service>();
                    c.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }
               
            }
        }
        private void ServiceCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
    }
}
