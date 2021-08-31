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
    public partial class SessionEdit : Form
    {
        public SessionEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int serviceid;
        private int workerid;
        private int cabinetid;
        private DateTime datestart;
        private DateTime timestart;
        private DateTime timeend;
        private string comment;

        private bool CountStr()
        {
            int countrows = SessionServiceDataGrid1.Rows.Count;
            if (countrows > 1)
                return true;
            else return false;
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            int count = SessionServiceDataGrid1.Rows.Count;
            if (ClientLbl.Text == "") { error.SetError(ClientLbl, "Заполните поле!"); message += "Клиент \n"; v = false; }
            if (BranchCmbBx.Text == "") { error.SetError(BranchCmbBx, "Заполните поле!"); message += "Филиал \n"; v = false; }
            if (count == 1) { error.SetError(SessionServiceDataGrid1, "Заполните поле!"); message += "Услуги \n"; v = false; }
            //if (sexM.IsChecked == false && sexW.IsChecked == false) {/* error.SetError(tbPhone, "Заполните поле!");*/ message += "Пол \n"; v = false; }
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
        public bool StateSave = false;//true - сеанс уже существует, false - новый сеанс
        public void FillDataGridView()
        {
            using (ClientEntities db = new ClientEntities())
            {
                SessionServiceDataGrid1.Rows.Clear();
                double sum = 0;
                List<SessionServices> sm = db.SessionServices.Where(x => x.SessionID == id && x.DeleteTime == null).ToList();
                foreach (SessionServices s in sm)
                {
                    DateTime temp;
                    temp = Convert.ToDateTime(s.TimeStart);
                    string ts = temp.ToShortTimeString();
                    temp = Convert.ToDateTime(s.TimeEnd);
                    string te = temp.ToShortTimeString();
                    Worker w = db.Worker.Where(x => x.Id == s.WorkerID && x.DeleteTime == null).FirstOrDefault<Worker>();
                    Service ser = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault<Service>();
                    List<ServiceMaterials> serm = db.ServiceMaterials.Where(x => x.ServiceID == ser.Id).ToList();
                    sum = sum + Convert.ToDouble(ser.Price);
                    Cabinet cabtemp = db.Cabinet.Where(x => x.Id == s.CabinetID).FirstOrDefault<Cabinet>();
                    SessionServiceDataGrid1.Rows.Add(ser.Name, s.Description, cabtemp.Name, w.SecondName + ' ' + w.Name + ' ' + w.LastName, ser.Price, ts, te);
                }
                SessionServiceDataGrid1.ReadOnly = true;
                Price1Lbl.Text = Convert.ToString(sum);
            }
        }
        //public void FillDataGridView(SessionServices ss)
        //{
        //    using (ClientEntities db = new ClientEntities())
        //    {
        //        SessionServiceDataGrid1.Rows.Clear();
        //        double sum = 0;
        //        List<SessionServices> sm = db.SessionServices.Where(x => x.SessionID == id && x.DeleteTime == null).ToList();
        //        foreach (SessionServices s in sm)
        //        {
        //            DateTime temp;
        //            temp = Convert.ToDateTime(s.TimeStart);
        //            string ts = temp.ToShortTimeString();
        //            temp = Convert.ToDateTime(s.TimeEnd);
        //            string te = temp.ToShortTimeString();
        //            Worker w = db.Worker.Where(x => x.Id == s.WorkerID && x.DeleteTime == null).FirstOrDefault<Worker>();
        //            Service ser = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault<Service>();
        //            List<ServiceMaterials> serm = db.ServiceMaterials.Where(x => x.ServiceID == ser.Id).ToList();
        //            sum = sum + Convert.ToDouble(ser.Price);
        //            Cabinet cabtemp = db.Cabinet.Where(x => x.Id == s.CabinetID).FirstOrDefault<Cabinet>();
        //            SessionServiceDataGrid1.Rows.Add(ser.Name, s.Description, cabtemp.Name, w.SecondName + ' ' + w.Name + ' ' + w.LastName, ser.Price, ts, te);
        //        }
        //        DateTime temp;
        //        temp = Convert.ToDateTime(s.TimeStart);
        //        string ts = temp.ToShortTimeString();
        //        temp = Convert.ToDateTime(s.TimeEnd);
        //        string te = temp.ToShortTimeString();
        //        Worker w = db.Worker.Where(x => x.Id == s.WorkerID && x.DeleteTime == null).FirstOrDefault<Worker>();
        //        Service ser = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault<Service>();
        //        List<ServiceMaterials> serm = db.ServiceMaterials.Where(x => x.ServiceID == ser.Id).ToList();
        //        sum = sum + Convert.ToDouble(ser.Price);
        //        Cabinet cabtemp = db.Cabinet.Where(x => x.Id == s.CabinetID).FirstOrDefault<Cabinet>();

        //        SessionServiceDataGrid1.Rows.Add(ss.Name, ss.Description, cabtemp.Name, w.SecondName + ' ' + w.Name + ' ' + w.LastName, ser.Price, ts, te);
            
        //    SessionServiceDataGrid1.ReadOnly = true;
        //        Price1Lbl.Text = Convert.ToString(sum);
        //    }
        //}
        private void SaveAllServices()
        {
            using (ClientEntities db = new ClientEntities())
            {
                int count = SessionServiceDataGrid1.Rows.Count-1;
                for (int i = 0; i < count; i++)
                {
                    string servicename = Convert.ToString(SessionServiceDataGrid1.Rows[i].Cells[0].Value);
                    Service temp = db.Service.Where(x => x.Name == servicename).FirstOrDefault<Service>();
                    string workername = Convert.ToString(SessionServiceDataGrid1.Rows[i].Cells[3].Value);
                    string[] fio = workername.Split(' ');
                    string SN = fio[0];
                    string N = fio[1];
                    string LN = fio[2];
                    Worker tempworker = db.Worker.Where(x =>x.SecondName==SN && x.Name == N && x.LastName == LN).FirstOrDefault<Worker>();
                    string cabinetname = Convert.ToString(SessionServiceDataGrid1.Rows[i].Cells[2].Value);
                    Cabinet tempcabinet = db.Cabinet.Where(x => x.Name == cabinetname).FirstOrDefault<Cabinet>();
                    
                    string comment1 = Convert.ToString(SessionServiceDataGrid1.Rows[i].Cells[1].Value);
                    DateTime TS = Convert.ToDateTime(SessionServiceDataGrid1.Rows[i].Cells[5].Value);
                    DateTime TE = Convert.ToDateTime(SessionServiceDataGrid1.Rows[i].Cells[6].Value);
                    SaveServicesAndWorkers(Convert.ToInt16(tempcabinet.BranchID), Convert.ToInt16(temp.Id), Convert.ToInt16(tempworker.Id), TS, TE, comment1, Convert.ToInt16(tempcabinet.Id), false);
                    Branch tem1 = db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>();
                    List<ServiceMaterials> servicematerials = db.ServiceMaterials.Where(x => x.ServiceID == temp.Id && x.DeleteTime == null).ToList();
                    foreach (ServiceMaterials sm in servicematerials)
                    {
                       // Material matid = db.Material.Find(sm.MaterialID);
                        BranchMaterials b = new BranchMaterials();
                        b.MaterialID = sm.MaterialID;
                        b.BranchID = tem1.Id;
                        b.ServiceID = sm.ServiceID;
                        if (sm.CountForTheAmount != null) b.CountForTheAmount = Convert.ToDouble(sm.CountForTheAmount);
                        else b.CountForTheAmount = null;
                        if (sm.CountPerPiece != null) b.CountPerPiece = Convert.ToInt16(sm.CountPerPiece);
                        else b.CountPerPiece = null;
                        b.Date = DateTime.Now;
                        b.AddOrDelete = false;
                        db.BranchMaterials.Add(b);
                        db.SaveChanges();
                    }
                }
            }
        }       
        private void FillDataGridView(int SerID, int WokID, DateTime TimeSt, DateTime TimeEn, string Comm,int CabID)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DateTime temp;
                temp = Convert.ToDateTime(TimeSt);
                string ts = temp.ToShortTimeString();
                temp = Convert.ToDateTime(TimeEn);
                string te = temp.ToShortTimeString();
                double sum = 0;
                Cabinet cabtemp = db.Cabinet.Where(x => x.Id == CabID).FirstOrDefault<Cabinet>();
                Worker w1 = db.Worker.Where(x => x.Id == WokID && x.DeleteTime == null).FirstOrDefault<Worker>();
                Service ser1 = db.Service.Where(x => x.Id == SerID && x.DeleteTime == null).FirstOrDefault<Service>();
                SessionServiceDataGrid1.Rows.Add(ser1.Name, Comm, cabtemp.Name, w1.SecondName + ' ' + w1.Name + ' ' + w1.LastName, ser1.Price, ts, te);
                sum = Convert.ToDouble(Price1Lbl.Text) + Convert.ToDouble(ser1.Price);
                SessionServiceDataGrid1.ReadOnly = true;
                Price1Lbl.Text = Convert.ToString(sum);
            }
        }
        private int CountWorkers()
        {
            int count = 0;
            using (ClientEntities db = new ClientEntities())
            {
                List<int> idworkers = new List<int>();
                int countrows = SessionServiceDataGrid1.Rows.Count - 1;
                for (int i = 0; i < countrows; i++)
                {
                    string workername = SessionServiceDataGrid1.Rows[i].Cells[3].Value.ToString();
                    string[] fio = workername.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Worker temp = db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname && x.DeleteTime == null).FirstOrDefault<Worker>();
                    if (idworkers.Contains(Convert.ToInt16(temp.Id)))
                        i++;
                    else idworkers.Add(Convert.ToInt16(temp.Id));
                }
                count = idworkers.Count;
            }
            return count;
        }
        public void Save(int ID_Session, int ID_Client, DateTime D, DateTime TS, DateTime TE, double price, int ID_Branch, int countworker)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Session session = db.Session.Where(c => c.Id == ID_Session).FirstOrDefault<Session>();
                session.ClientID = ID_Client;
                session.Date = D;
                session.TimeStart = TS;
                session.TimeEnd = TE;
                session.Price = price;
                session.BranchID = ID_Branch;
                session.CountWorker = countworker;
                db.SaveChanges();
            }
        }
        public void Add(int ID_Session, int ID_Client, DateTime D, DateTime TS, DateTime TE, double price, int ID_Branch, int countworker)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Session session = new Session()
                {
                    Id = ID_Session,
                    ClientID = ID_Client,
                    Date = D,
                    TimeStart = TS,
                    TimeEnd = TE,
                    Price = price,
                    BranchID = ID_Branch,
                    CountWorker = countworker,
                    ReduceMaterial = false
                };
                db.Session.Add(session);
                db.SaveChanges();
            }
        }
        private void SaveForm()
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    Branch tem1 = db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>();
                    string[] fio = ClientLbl.Text.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Client tem2 = db.Client.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname).FirstOrDefault<Client>();
                    if (db.Session.Find(id) == null)
                    {
                        Add(id, Convert.ToInt16(tem2.Id), DateDtm.Value, TimeStart.Value, TimeEnd.Value, Convert.ToDouble(Price1Lbl.Text), Convert.ToInt16(tem1.Id), CountWorkers());
                        Pay pay = new Pay();
                        pay.Id = id;
                        pay.ClientID = Convert.ToInt16(tem2.Id);
                        pay.Date = DateDtm.Value;
                        pay.Price = Convert.ToDouble(Price1Lbl.Text);
                        pay.Worker = db.Worker.Find(workerid);
                        pay.SessionID = id;
                        db.Pay.Add(pay);
                        SaveAllServices();
                        db.SaveChanges();
                    }
                    else
                    {
                        Save(id, Convert.ToInt16(tem2.Id), DateDtm.Value, TimeStart.Value, TimeEnd.Value,  Convert.ToDouble(Price1Lbl.Text), Convert.ToInt16(tem1.Id), CountWorkers());
                        SaveAllServices();
                    }
                    this.Close();
                }
            }
        }
        private void SaveSessionBtn_Click(object sender, EventArgs e)
        {
            SaveForm();
        }

        private void SessionEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Session.Find(id) != null)
                {
                    Session temp = db.Session.Where(x => x.Id == id).FirstOrDefault<Session>();
                    FillForm(temp);
                }
                else
                {
                    Session c = new Session();
                    c.Id = db.Session.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    FillForm();
                }
            }
        }
        private void FillBranchCmbx()/////////////////////////
        {
            using (ClientEntities db = new ClientEntities())
            {
                BranchCmbBx.Items.Clear();
                List<Branch> tempbranch = db.Branch.Where(x => x.DeleteTime == null).ToList();
                foreach (Branch b in tempbranch)
                {
                    BranchCmbBx.Items.Add(b.Name);
                }
                BranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            }
        }
        private void FillForm(Session session)
        {
            using (ClientEntities db = new ClientEntities())
            {
                FillBranchCmbx();
                BranchCmbBx.Text = session.Branch.Name;
                ClientLbl.Text = session.Client.SecondName + ' ' + session.Client.Name + ' ' + session.Client.LastName;
                DateDtm.Value = Convert.ToDateTime(session.Date);
                TimeStart.Format = DateTimePickerFormat.Time;
                TimeStart.ShowUpDown = true;
                TimeStart.Value = Convert.ToDateTime(session.TimeStart);
                TimeEnd.Format = DateTimePickerFormat.Time;
                TimeEnd.ShowUpDown = true;
                TimeEnd.Value = Convert.ToDateTime(session.TimeEnd);
                DateDtm.MinDate = DateTime.Now;
                Price1Lbl.Text = Convert.ToString(session.Price);
                FillDataGridView();
            }
        }
        private void FillForm()
        {
            using (ClientEntities db = new ClientEntities())
            {
                FillBranchCmbx();
                DateDtm.MinDate = DateTime.Now;
                TimeStart.Format = DateTimePickerFormat.Time;
                TimeStart.ShowUpDown = true;
                TimeEnd.Format = DateTimePickerFormat.Time;
                TimeEnd.ShowUpDown = true;
                if (DateDtm.Value == DateTime.Now)
                {
                    TimeStart.MinDate = DateTime.Now;
                    TimeEnd.MinDate = DateTime.Now;
                }
                BranchCmbBx.Text = db.Branch.Find(1).Name;
                ClientLbl.Text = "";
                ClientLbl.Visible = false;
                Price1Lbl.Text = Convert.ToString(0);
            }
        }
        private void AddServiceToSessionBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkerService ws = new WorkerService();
                ws.SessionId = id;
                Branch temp = db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>();
                ws.BranchId = Convert.ToInt16(temp.Id);
                ws.Date = DateDtm.Value;
                ws.ShowDialog();
                if (ws.SaveOrNot)
                {
                    serviceid = ws.ServiceId;
                    workerid = ws.WorkerId;
                    timestart = ws.TimeStart1;
                    timeend = ws.TimeEnd1;
                    comment = ws.Comment;
                    cabinetid = ws.CabinetId;
                    FillDataGridView(serviceid, workerid, timestart, timeend, comment, cabinetid);
                    FillDate(timestart,timeend);
                }
            }
        }
        private void FillDate(DateTime ts, DateTime te)
        {
            if (ts<TimeStart.Value)
            {
                TimeStart.Value = ts;
            }
            if (te > TimeEnd.Value)
            {
                TimeEnd.Value = te;
            }
        }
        public void SaveServicesAndWorkers(int ID_Branch, int ID_Service, int ID_Worker, DateTime TS, DateTime TE, string comment, int ID_Cabinet,bool paystate)//, DateTime DS, DateTime TS, DateTime TE, DateTime DE, double price, int ID_Branch, int countworker)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (!db.SessionServices.Any(x => x.SessionID.Equals(id) && x.ServiceID.Equals(ID_Service)))// && x.WorkerID.Equals(ID_Worker)))
                {
                    SessionServices sessionservices = new SessionServices()
                    {
                        SessionID = id,
                        ServiceID = ID_Service,
                        WorkerID = ID_Worker,
                        TimeStart = TS,
                        TimeEnd = TE,
                        Description = comment,
                        CabinetID = ID_Cabinet,
                        PayState = paystate
                    };
                    db.SessionServices.Add(sessionservices);
                }
                else
                {
                    SessionServices ss = db.SessionServices.Where(x => x.SessionID == id && x.ServiceID == ID_Service).FirstOrDefault<SessionServices>();
                    ss.WorkerID = ID_Worker;
                    ss.TimeStart = TS;
                    ss.TimeEnd = TE;
                    ss.Description = comment;
                    ss.CabinetID = ID_Cabinet;
                    ss.DeleteTime = null;
                }
                db.SaveChanges();
            }
        }
        private void DeleteServiceFromSessionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = Convert.ToString(this.SessionServiceDataGrid1.CurrentRow.Cells[0].Value);
                using (ClientEntities db = new ClientEntities())
                {
                    Service ser = db.Service.Where(x => x.Name == temp && x.DeleteTime == null).FirstOrDefault<Service>();
                    SessionServices ss = db.SessionServices.Where(x => x.DeleteTime == null && x.SessionID == id && x.ServiceID == ser.Id).FirstOrDefault<SessionServices>();
                    ss.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    FillDataGridView();
                }
            }
            catch
            {
                bool b = CountStr();
                if (!b)
                    MessageBox.Show("У сеанса нет услуг, которые можно удалить.", "Тату салон");
                else MessageBox.Show("Нажмите на услугу, которую хотите удалить.", "Тату салон");

            }
        }

        private void ChooseClientBtn_Click(object sender, EventArgs e)
        {
            TattooParlor TP = new TattooParlor();
            TP.Text = "Выбрать клиента";
            TP.BackId = id;
            TP.FormStatus = 7;
            TP.ShowDialog();
            int ClientID = TP.ClientId;
            using (ClientEntities db = new ClientEntities())
            {
                Client cl = db.Client.Find(ClientID);
                ClientLbl.Visible = true;
                ClientLbl.Text = cl.SecondName + ' ' + cl.Name + ' ' + cl.LastName;
            }
        }
    }
}
