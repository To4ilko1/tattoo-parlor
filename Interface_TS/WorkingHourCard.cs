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
    public partial class WorkingHourCard : Form
    {
        public WorkingHourCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        public int workerid;
        public int WorkerId
        {
            get { return workerid; }
            set { workerid = value; }
        }

        private void FillForm(WorkingHour wh)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHourWorkerLbl.Text = wh.Worker.SecondName + ' ' + wh.Worker.Name + ' ' + wh.Worker.LastName; ;
                WorkingHourBranchNameLbl1.Text = wh.Branch.Name;
                WorkingHourTimeStartLbl.Text= Convert.ToString(wh.TimeStart);
                WorkingHourTimeEndLbl.Text = Convert.ToString(wh.TimeEnd);
            }
        }
        private void EditWorkingHourBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHourEdit WHE = new WorkingHourEdit();
                WHE.Currentid = id;
                WHE.FormStat = 2;
                WHE.ShowDialog();
                FillForm(db.WorkingHour.Find(id));
            }
        }
        private void DeleteWorkingHourBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHour c = db.WorkingHour.Where(x => x.Id == id).FirstOrDefault<WorkingHour>();
                c.DeleteTime = DateTime.Now;
                db.SaveChanges();
                this.Close();
            }
        }
        private void WorkingHourCard_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHour temp = db.WorkingHour.Where(x => x.Id == id).FirstOrDefault<WorkingHour>();
                FillForm(temp);
            }
        }
    }
}
