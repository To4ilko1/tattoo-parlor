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
    public partial class WorkingHourEdit : Form
    {
        private int stat; //1-prosto forma, 2-форма для редактирования одного расписания
        public int FormStat
        {
            get { return stat; }
            set { stat = value; }
        }
        //private int currentid; //1-prosto forma, 2-форма для редактирования одного расписания
        //public int CurrentId
        //{
        //    get { return currentid; }
        //    set { currentid = value; }
        //}
        public WorkingHourEdit()
        {
            InitializeComponent();
            WorkerCmbBx.Validating += WorkerCmbBx_Validating;
            BranchCmbBx.Validating += BranchCmbBx_Validating;
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        public void FillWorkerCmbx()
        {
            WorkerCmbBx.Items.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                foreach (Worker w in db.Worker.Where(x => x.DeleteTime == null).ToList())
                {
                    WorkerCmbBx.Items.Add(w.SecondName+' '+w.Name+' '+w.LastName);
                }
            }
            WorkerCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            WorkerCmbBx.SelectedIndex = 0;
        }
        public void FillBranchCmbx()
        {
            BranchCmbBx.Items.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                foreach (Branch b in db.Branch.Where(x => x.DeleteTime == null).ToList())
                {
                    BranchCmbBx.Items.Add(b.Name);
                }
            }
            BranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BranchCmbBx.SelectedIndex = 0;
        }
        private void Save()
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (FormStat == 2)
                {
                    string datestartandtime = Convert.ToString(DateStartDtm.Value);
                    string[] DateStart = datestartandtime.Split(' ');
                    string datestart = DateStart[0];
                    string dateandtimestart = Convert.ToString(TimeStartDtm.Value);
                    string[] TimeStart = dateandtimestart.Split(' ');
                    string timestart = TimeStart[1];
                    DateTime datestandtimest = Convert.ToDateTime(datestart + ' ' + timestart);
                    string dateandtimeend = Convert.ToString(TimeEndDtm.Value);
                    string[] TimeEnd = dateandtimeend.Split(' ');
                    string timeend = TimeEnd[1];
                    DateTime datestandtimeen = Convert.ToDateTime(datestart + ' ' + timeend);
                    DateTime dateend = DateEndDtm.Value;

                    SaveWorkingHour(id, Convert.ToInt16(db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>().Id), datestandtimest, datestandtimeen);
                }
                else
                {
                    if (radioButton1.Checked == true)
                    {
                        string datestartandtime = Convert.ToString(DateStartDtm.Value);
                        string[] DateStart = datestartandtime.Split(' ');
                        string datestart = DateStart[0];
                        string dateandtimestart = Convert.ToString(TimeStartDtm.Value);
                        string[] TimeStart = dateandtimestart.Split(' ');
                        string timestart = TimeStart[1];
                        DateTime datestandtimest = Convert.ToDateTime(datestart + ' ' + timestart);
                        string dateandtimeend = Convert.ToString(TimeEndDtm.Value);
                        string[] TimeEnd = dateandtimeend.Split(' ');
                        string timeend = TimeEnd[1];
                        DateTime datestandtimeen = Convert.ToDateTime(datestart + ' ' + timeend);
                        DateTime dateend = DateEndDtm.Value;
                        while (datestandtimest <= dateend)
                        {
                            string[] fio = WorkerCmbBx.Text.Split(' ');
                            string secondname = fio[0];
                            string name = fio[1];
                            string lastname = fio[2];
                            AddWorkingHour(db.WorkingHour.Count() + 1, Convert.ToInt16(db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname).FirstOrDefault<Worker>().Id), Convert.ToInt16(db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>().Id), datestandtimest, datestandtimeen);
                            datestandtimest = datestandtimest.AddDays(1);
                            datestandtimeen = datestandtimeen.AddDays(1);
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        DateTime start2 = TimeStartDtm.Value;
                        DateTime end2 = TimeEndDtm.Value;

                        for (int i = 0; i < Convert.ToInt16(numericUpDown1.Value); i++)
                        {
                            string[] fio = WorkerCmbBx.Text.Split(' ');
                            string secondname = fio[0];
                            string name = fio[1];
                            string lastname = fio[2];
                            AddWorkingHour(db.WorkingHour.Count() + 1, Convert.ToInt16(db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname).FirstOrDefault<Worker>().Id), Convert.ToInt16(db.Branch.Where(x => x.Name == BranchCmbBx.Text).FirstOrDefault<Branch>().Id), start2, end2);
                            start2 = start2.AddDays(1);
                            end2 = end2.AddDays(1);
                        }

                    }
                }
            }
            this.Close();
        }
        private void SaveWorkingHour(int id, int branchid, DateTime TS, DateTime TE)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHour wh = db.WorkingHour.Where(x => x.Id == id).FirstOrDefault<WorkingHour>();
                wh.BranchID = branchid;
                wh.TimeStart = TS;
                wh.TimeEnd = TE;
                wh.DeleteTime = null;
                db.SaveChanges();
            }          
        }
        private void AddWorkingHour(int id, int workerid, int branchid, DateTime TS, DateTime TE)
        {
            using (ClientEntities db = new ClientEntities())
            {
                WorkingHour c = new WorkingHour()
                {
                    Id = id,
                    WorkerID = workerid,
                    BranchID = branchid,
                    TimeStart = TS,
                    TimeEnd = TE
                };
                db.WorkingHour.Add(c);
                db.SaveChanges();
            }
        }
        private void WorkerCmbBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WorkerCmbBx.Text))
            {
                error1.SetError(WorkerCmbBx, "Не указан работник");
                SaveWorkingHourBtn.Enabled = false;
            }
            else
            {
                error1.Clear();
                SaveWorkingHourBtn.Enabled = true;
            }
        }
        private void BranchCmbBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(BranchCmbBx.Text))
            {
                error3.SetError(BranchCmbBx, "Не указан филиал");
                SaveWorkingHourBtn.Enabled = false;
            }
            else
            {
                error3.Clear();
                SaveWorkingHourBtn.Enabled = true;
            }
        }
        private void SaveWorkingHourBtn_Click(object sender, EventArgs e)
        {
           Save();
        }
        private void FillForm()
        {
            using (ClientEntities db = new ClientEntities())
            {
                FillWorkerCmbx();
                DateEndDtm.Enabled = false;
                numericUpDown1.Enabled = false;
                FillBranchCmbx();
                if (db.WorkingHour.Find(id) != null)
                {
                    WorkingHour temp = db.WorkingHour.Where(x => x.Id == id).FirstOrDefault<WorkingHour>();
                    WorkerCmbBx.Text = temp.Worker.SecondName+' '+temp.Worker.Name+' '+temp.Worker.LastName;
                    BranchCmbBx.Text = temp.Branch.Name;
                    TimeStartDtm.Value = Convert.ToDateTime(temp.TimeStart);
                    TimeEndDtm.Value = Convert.ToDateTime(temp.TimeEnd);
                    DateStartDtm.Value = Convert.ToDateTime(temp.TimeStart);
                }
                else
                {
                    SaveWorkingHourBtn.Enabled = false;
                    WorkingHour c = new WorkingHour();
                    c.Id = db.WorkingHour.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }
        private void FillFormForOneWH()
        {
            using (ClientEntities db = new ClientEntities())
            {              
                FillWorkerCmbx();
                WorkerCmbBx.Enabled = false;
                FillBranchCmbx();
                groupBox1.Visible = false;
                label3.Text = "Дата:";
                WorkingHour temp = db.WorkingHour.Where(x => x.Id == id).FirstOrDefault<WorkingHour>();
                WorkerCmbBx.Text = temp.Worker.SecondName + ' ' + temp.Worker.Name + ' ' + temp.Worker.LastName;
                BranchCmbBx.Text = temp.Branch.Name;
                TimeStartDtm.Value = Convert.ToDateTime(temp.TimeStart);
                TimeEndDtm.Value = Convert.ToDateTime(temp.TimeEnd);
                DateStartDtm.Value = Convert.ToDateTime(temp.TimeStart);
            }
        }
        private void WorkingHourEdit_Load(object sender, EventArgs e)
        {
            if (stat != 2)
            {
                FillForm();
            }
            else
            {
                this.Width = 286;
                this.Height = 254;
                SaveWorkingHourBtn.Location = new Point(185, 177);
                FillFormForOneWH();
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            radioButton2.Checked = false;
            DateEndDtm.Enabled = true;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            DateEndDtm.Enabled = false;
            radioButton1.Checked = false;
            numericUpDown1.Enabled = true;
        }
    }
}
