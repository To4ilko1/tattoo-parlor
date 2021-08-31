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
    public partial class SessionCard : Form
    {
        public SessionCard()
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
                SessionServiceDataGrid.Rows.Clear();
                double sum = 0;
                List<SessionServices> sm = db.SessionServices.Where(x => x.SessionID == id && x.DeleteTime==null).ToList();
                foreach (SessionServices s in sm)
                {
                    DateTime temp;
                    Worker w = db.Worker.Where(x => x.Id == s.WorkerID && x.DeleteTime == null).FirstOrDefault<Worker>();
                    Service ser = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault<Service>();
                    sum = sum + Convert.ToDouble(ser.Price);
                    temp = Convert.ToDateTime(s.TimeStart);
                    string ts = temp.ToShortTimeString();
                    temp = Convert.ToDateTime(s.TimeEnd);
                    string te = temp.ToShortTimeString();
                    SessionServiceDataGrid.Rows.Add(ser.Name, s.Description,db.Cabinet.Find(s.CabinetID).Name, w.SecondName + ' ' + w.Name + ' ' + w.LastName, ser.Price, ts, te);
                }
                SessionServiceDataGrid.ReadOnly = true;
                PriceLbl.Text = Convert.ToString(sum);
            }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Session temp = db.Session.Where(x => x.Id == this.id).FirstOrDefault<Session>();
                BranchSessionLinkLabel.Text = temp.Branch.Name;
                ClientSessionLinkLabel.Text = temp.Client.SecondName+' '+temp.Client.Name+' '+temp.Client.LastName;
                DateSessionDtm.Value = Convert.ToDateTime(temp.Date);
                DateSessionDtm.Enabled = false;
                TimeStartDtm.Value = Convert.ToDateTime(temp.TimeStart);
                TimeStartDtm.Enabled = false;
                TimeEndDtm.Value = Convert.ToDateTime(temp.TimeEnd);
                TimeEndDtm.Enabled = false;
                FillDataGridView();
            }
        }
        private void EditSessionBtn_Click(object sender, EventArgs e)
        {
            SessionEdit sessionedit = new SessionEdit();
            sessionedit.Currentid = id;
            sessionedit.ShowDialog();
            Refresh1();            
        }
        private void DeleteSessionBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить сеанс?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    List<SessionServices> ss = db.SessionServices.Where(x => x.SessionID == id && x.DeleteTime == null).ToList();
                    foreach (SessionServices session in ss)
                    {
                        session.DeleteTime = DateTime.Now;
                    }
                    List<SessionWorkers> sm = db.SessionWorkers.Where(x => x.SessionID == id && x.DeleteTime == null).ToList();
                    foreach (SessionWorkers session in sm)
                    {
                        session.DeleteTime = DateTime.Now;
                    }
                    Session s = db.Session.Where(x => x.Id == id && x.DeleteTime == null).FirstOrDefault<Session>();
                    s.DeleteTime = System.DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        private void SessionCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
        private void BranchSessionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Branch temp = db.Branch.Where(x => x.Name == BranchSessionLinkLabel.Text).FirstOrDefault<Branch>();
                BranchCard BC = new BranchCard();
                BC.Currentid = Convert.ToInt16(temp.Id);
                BC.ShowDialog();
            }
        }
        private void ClientSessionLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                string[] fio = ClientSessionLinkLabel.Text.Split(' ');
                string secondname = fio[0];
                string name = fio[1];
                string lastname = fio[2];
                Client temp = db.Client.Where(x => x.SecondName == secondname && x.Name == name && x.LastName==lastname).FirstOrDefault<Client>();
                ClientCard CCl = new ClientCard();
                CCl.Currentid = Convert.ToInt16(temp.Id);
                CCl.ShowDialog();
            }
        }
    }
}
