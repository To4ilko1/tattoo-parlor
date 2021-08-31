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
    public partial class WorkerCard : Form
    {
        public WorkerCard()
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
                ServiceListLstBx.Items.Clear();
                List<ServiceWorkers> servicelist = db.ServiceWorkers.Where(x => x.DeleteTime == null && x.WorkerID == id).ToList();
                foreach (ServiceWorkers sw in servicelist)
                {
                    ServiceListLstBx.Items.Add(db.Service.Find(sw.ServiceID).Name);//db.Service.Find(ServiceID).Name);
                }
            }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Worker temp = db.Worker.Where(x => x.Id == this.id).FirstOrDefault<Worker>();
                FIOWLbl.Text = temp.SecondName+' '+temp.Name+' '+temp.LastName;
                PhoneWorkerNumberLbl.Text = temp.ContactPhoneNumber;
                WorkerBranchLbl.Text = temp.Branch.Name;
                WorkerPositionLbl.Text = temp.Position;
                WorkerTattooStyleLbl.Text = temp.TattooStyle;
                ExperienceLbl.Text = Convert.ToString(temp.Experience);
                CommentWTxtBox.ReadOnly = true;
                CommentWTxtBox.Text = temp.Comment;
                FillListBox();
            }
        }
        private void EditWorkerBtn_Click(object sender, EventArgs e)
        {
            WorkerEdit w = new WorkerEdit();
            w.Currentid = id;
            w.ShowDialog();
            Refresh1();
        }
        private void DeleteWorkerBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить работника?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Worker w = db.Worker.Where(x => x.Id == id).FirstOrDefault<Worker>();
                    w.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }               
            }
        }
        private void WorkerCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }

        private void WorkerWorkingHourBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                //// Worker temp = db.Worker.Where(x => x.Id == id).FirstOrDefault<Worker>();
                // WorkingHourCard WHC = new WorkingHourCard();
                // WHC.Currentid = id;
                // WHC.ShowDialog();
                //WorkingHourCard WH = new WorkingHourCard();
                //WH.WorkerId = id;
                //WH.ShowDialog();
                TattooParlor TP = new TattooParlor();
                TP.BackId = id;
                TP.FormStatus = 11;
                TP.ShowDialog();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            WorkerWorkingHour WWH = new WorkerWorkingHour();
            WWH.BackId = id;
            WWH.ShowDialog();
        }
    }
}

