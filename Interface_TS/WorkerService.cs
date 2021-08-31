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
    public partial class WorkerService : Form
    {
        public WorkerService()
        {
            InitializeComponent();
        }
        private int sessionid;
        public int SessionId
        {
            get { return sessionid; }
            set { sessionid = value; }
        }
        private int serviceid;//helpid
        public int ServiceId
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        private int workerid;//helpid
        public int WorkerId
        {
            get { return workerid; }
            set { workerid = value; }
        }
        private int SerId;
        private int WorId;
        private int CabId;
        private bool saveornot = false;//при false не сохранять, при true сохранять
        public bool SaveOrNot
        {
            get { return saveornot; }
            set { saveornot = value; }
        }
        private DateTime timestart;//helpid
        private DateTime date;//helpid
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public DateTime TimeStart1
        {
            get { return timestart; }
            set { timestart = value; }
        }
        private DateTime timeend;//helpid
        public DateTime TimeEnd1
        {
            get { return timeend; }
            set { timeend = value; }
        }
        private string comment;//helpid
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        private int cabinetid;//helpid
        public int CabinetId
        {
            get { return cabinetid; }
            set { cabinetid = value; }
        }
        private int branchid;//helpid
        public int BranchId
        {
            get { return branchid; }
            set { branchid = value; }
        }
        private void FillForm()
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkerLinkLbl.Text = "";
                ServiceLinkLbl.Text = "";
                CabinetLinkLbl.Text = "";
                saveornot = false;
                TimeStartDtm.Format = DateTimePickerFormat.Time;
                TimeStartDtm.ShowUpDown = true;
                TimeStartDtm.Enabled = false;
                TimeStartDtm.Value = date;
                TimeEndDtm.Format = DateTimePickerFormat.Time;
                TimeEndDtm.ShowUpDown = true;
                TimeEndDtm.Enabled = false;
                TimeEndDtm.Value = date;
                CommentToServiceTxt.ReadOnly = true;
                ServiceLinkLbl.Visible = false;
                WorkerLinkLbl.Visible = false;
                CabinetLinkLbl.Visible = false;             
                ChooseWorkerToServiceBtn.Visible = false;
                ChooseCabinetToServiceBtn.Visible = true;
                ChooseServiceToWorkerBtn.Visible = false;
            }
        }
        private void WorkerService_Load(object sender, EventArgs e)
        {
            FillForm();
        }
        private void ChooseCabinetToServiceBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить кабинет";
                TP.BackId = sessionid;////////////////////не нужен
                TP.FormStatus = 10;
              //  TP.ServiceId = SerId;
                TP.BranchId = branchid;
                TP.ShowDialog();
                CabId = TP.CabinetId;
                if (CabId != 0)
                {
                    CabinetLinkLbl.Visible = true;
                    CabinetLinkLbl.Text = db.Cabinet.Find(CabId).Name;
                    ChooseServiceToWorkerBtn.Visible = true;
                }
            }
        }
        private void ChooseServiceToWorkerBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить услугу";
                TP.BackId = sessionid;//////////////////не нужно???
                TP.CabinetId = CabId;
                TP.FormStatus = 8;
                TP.ShowDialog();
                SerId = TP.ServiceId;
                if (SerId != 0)
                {
                    ServiceLinkLbl.Visible = true;
                    ServiceLinkLbl.Text = db.Service.Find(SerId).Name;
                    TimeEndDtm.Value = TimeStartDtm.Value.AddMinutes(Convert.ToDouble(db.Service.Find(SerId).Time));
                    TimeStartDtm.Enabled = true;
                    TimeEndDtm.Enabled = false;
                    CommentToServiceTxt.ReadOnly = false;
                    ChooseWorkerToServiceBtn.Visible = true;
                }
            }
        }

        private void ChooseWorkerToServiceBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить мастера";
                TP.BackId = sessionid;////////////////////////
                TP.TimeStart = TimeStartDtm.Value;
                TP.TimeEnd = TimeEndDtm.Value;
                TP.Date = date;
                TP.FormStatus = 9;
                TP.ServiceId = SerId;
                TP.BranchId = branchid;
                TP.ShowDialog();
                WorId = TP.WorkerId;
                if (WorId != 0)
                {
                    WorkerLinkLbl.Visible = true;
                    WorkerLinkLbl.Text = db.Worker.Find(WorId).SecondName + ' ' + db.Worker.Find(WorId).Name + ' ' + db.Worker.Find(WorId).LastName;
                    ChooseCabinetToServiceBtn.Visible = true;
                }
            }
        }

        private void SaveWorkerToServiceBtn_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
        private void SaveForm()
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    serviceid = SerId;
                    workerid = WorId;
                    cabinetid = CabId;
                    timestart = TimeStartDtm.Value;
                    timeend = TimeEndDtm.Value;
                    comment = CommentToServiceTxt.Text;
                    saveornot = true;
                    this.Close();
                }
            }
        }

        private void TimeStartDtm_ValueChanged(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (SerId!=0)
                TimeEndDtm.Value = TimeStartDtm.Value.AddMinutes(Convert.ToDouble(db.Service.Find(SerId).Time));
                else
                {
                    TimeEndDtm.Value = TimeStartDtm.Value;
                }
            }

        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (WorkerLinkLbl.Text == "") { error.SetError(WorkerLinkLbl, "Заполните поле!"); message += "Мастер \n"; v = false; }
            if (ServiceLinkLbl.Text == "") { error.SetError(ServiceLinkLbl, "Заполните поле!"); message += "Услуга \n"; v = false; }
            if (CabinetLinkLbl.Text == "") { error.SetError(CabinetLinkLbl, "Заполните поле!"); message += "Кабинет \n"; v = false; }
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