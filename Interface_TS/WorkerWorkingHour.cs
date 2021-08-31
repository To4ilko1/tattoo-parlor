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
    public partial class WorkerWorkingHour : Form
    {
        public WorkerWorkingHour()
        {
            InitializeComponent();
        }
        private int backid;
        public int BackId
        {
            get { return backid; }
            set { backid = value; }
        }
        public void FillDataGridView()
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkerWorkingHoursDataGrid.Rows.Clear();
                List<SessionServices> sm = db.SessionServices.Where(x => x.WorkerID == backid && x.DeleteTime == null).ToList();
                foreach (SessionServices s in sm)
                {
                    DateTime temp;
                    temp = Convert.ToDateTime(s.TimeStart);
                    string ts = temp.ToShortTimeString();
                    temp = Convert.ToDateTime(s.TimeEnd);
                    string te = temp.ToShortTimeString();
                    Worker w = db.Worker.Find(backid);
                    Service ser = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault<Service>();
                    Cabinet cabtemp = db.Cabinet.Where(x => x.Id == s.CabinetID).FirstOrDefault<Cabinet>();
                    WorkerWorkingHoursDataGrid.Rows.Add(ser.Name, s.Description, cabtemp.Name, w.SecondName + ' ' + w.Name + ' ' + w.LastName, ser.Price, ts, te);
                }
                WorkerWorkingHoursDataGrid.ReadOnly = true;
            }
        }

        private void WorkerWorkingHour_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
    }
}
