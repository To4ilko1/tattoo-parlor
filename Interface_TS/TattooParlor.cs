using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Interface_TS
{
    public partial class TattooParlor : Form
    {
        public TattooParlor()
        {
            InitializeComponent();
        }
        private int status; //1-prosto forma 2-dobavlenie uslugi v kabinet 3-add material in service in branch 4 - add material in service 5- add service to worker 6-add service to pay 7-add client to session 8-add service to session 9-add worker to service to session 10-add cabinet to service to session 11-search workinghour from worker 12-workerservices
        public int FormStatus
        {
            get { return status; }
            set { status = value; }
        }
        private int backid;
        public int BackId
        {
            get { return backid; }
            set { backid = value; }
        }
        private int materialid;//helpid
        public int MaterialId
        {
            get { return materialid; }
            set { materialid = value; }
        }
        private int branchid;//helpid
        public int BranchId
        {
            get { return branchid; }
            set { branchid = value; }
        }
        private int serviceid;//helpid
        public int ServiceId
        {
            get { return serviceid; }
            set { serviceid = value; }
        }
        private int cabinetid;//helpid
        public int CabinetId
        {
            get { return cabinetid; }
            set { cabinetid = value; }
        }
        private int clientid;//helpid
        public int ClientId
        {
            get { return clientid; }
            set { clientid = value; }
        }
        private int workerid;//helpid
        public int WorkerId
        {
            get { return workerid; }
            set { workerid = value; }
        }
        private DateTime timestart;//helpid
        public DateTime TimeStart
        {
            get { return timestart; }
            set { timestart = value; }
        }
        private DateTime timeend;//helpid
        public DateTime TimeEnd
        {
            get { return timeend; }
            set { timeend = value; }
        }
        private DateTime date;//helpid
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        private DateTime timestartforsearch=Convert.ToDateTime("1999-10-11");
        private DateTime timeendforsearch = Convert.ToDateTime("1999-10-11");
        private DateTime datepaysearch = Convert.ToDateTime("1999-10-11");
        private int maxpage;
        private int currentcountonpage = 10;
        private int currentpage;
        private void CheckCurrentStatus(int stat)
        {
            switch (stat)
            {           
                case 1:
                    currentpage = 1;
                    FillGridSessions(currentpage, currentcountonpage);
                    button10.Enabled = false;
                    label8.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button11.Enabled = false; }
                    else
                    { button11.Enabled = true; }
                
                    break;                   
                case 2:
                    //tabPage6-с услугами
                    FillGridServices(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddServiceBtn.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 3:
                    //tabPage8-с материалами
                    FillGridMaterials(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddMaterialBtn.Visible = false;
                    button29.Visible = false;
                    button30.Visible = false;
                    groupBox7.Visible = false;
                    label30.Visible = false;
                    break;
                case 4:
                    //tabPage8-с материалами
                    FillGridMaterials(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddMaterialBtn.Visible = false;
                    button29.Visible = false;
                    button30.Visible = false;
                    groupBox7.Visible = false;
                    label30.Visible = false;
                    break;
                case 5:
                    //tabPage6-с услугами
                    FillGridServices(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddServiceBtn.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 6:
                    //tabPage6-с услугами
                    FillGridServices(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddServiceBtn.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 7:
                    //tabPage2-с клиентами
                    FillGridClients(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddClientBtn.Visible = false;
                    button1.Visible = false;
                    button3.Visible = false;
                    label1.Visible = false;
                    groupBox1.Visible = false;
                    break;
                case 8:
                    //tabPage6-с услугами
                    FillGridServices(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddServiceBtn.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 9:
                    //tabPage1-с работниками
                    FillGridWorkers(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddWorkerBtn.Visible = false;
                    button16.Visible = false;
                    button17.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 10:
                    //tabPage4-с кабинетами
                    FillGridCabinets(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    AddCabinetBtn.Visible = false;
                    button13.Visible = false;
                    button14.Visible = false;
                    SearchCabinetBtn.Visible = false;
                    groupBox5.Visible = false;
                    break;
                case 11:
                    //tabPage10-с режимами работы
                    //FillGridWorkingHours(currentpage, currentcountonpage);
                    FillGridWithWorkingHoursForWorker(backid);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage4);
                    AddWorkerBtn.Visible = false;
                    button37.Visible = false;
                    button36.Visible = false;
                    label46.Visible = false;
                    WorkerHoursSearch.Visible = false;
                    groupBox10.Visible = false;
                    break;
                case 12:
                    //tabPage10-с режимами работы
                    //FillGridWorkingHours(currentpage, currentcountonpage);
                    FillGridWorkingHoursForWorker(backid);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage4);
                    AddCabinetBtn.Visible = false;
                    button37.Visible = false;
                    button36.Visible = false;
                    label46.Visible = false;
                    WorkerHoursSearch.Visible = false;
                    groupBox10.Visible = false;
                    break;
            }
        }
        private void TattooParlor_Load(object sender, EventArgs e)
        {
            FillGridSessions(currentpage, currentcountonpage);
            CheckCurrentStatus(FormStatus);
        }
        private void FillGridClients(int page, int countonpage)
        {
            using (ClientEntities db = new ClientEntities())
            {
                ClientsDataGridView.Rows.Clear();
                List<Client> clientlist = db.Client.Where(x => x.DeleteTime == null).ToList();
                maxpage = clientlist.Count() / countonpage;
                if (clientlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Client c in clientlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    ClientsDataGridView.Rows.Add(c.Id, c.SecondName, c.Name, c.LastName, c.ContactPhoneNumber);
                }
                ClientsDataGridView.AllowUserToAddRows = false;
                ClientsDataGridView.AllowUserToDeleteRows = false;
                ClientsDataGridView.AllowUserToOrderColumns = false;
                ClientsDataGridView.AllowUserToResizeRows = false;
                SearchClientLastName.Text = "";
                SearchClientName.Text = "";
                SearchClientSecondName.Text = "";
                SearchClientNumber.Text = "";
            }
        }
        private void FillGridWorkers(int page, int countonpage)
        {
            SearchWorkerName.Text = "";  //очищаем поля сортировки работников
            SearchWorkerLastName.Text = "";
            SearchWorkerSecondName.Text = "";
            SearchWorkerNumber.Text = "";
            SearchWorkerPosition.SelectedIndex = -1;
            SearchWorkerPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ExperienceTxtBx.Text = "";
            WorkersDataGridView.Rows.Clear();  //очищаем строки таблицы
            using (ClientEntities db = new ClientEntities())
            {
                if (FormStatus == 9)
                {
                    List<Worker> workerlist = db.Worker.Where(x => x.DeleteTime == null && x.BranchID == branchid).ToList();
                    foreach (Worker w in workerlist)
                    {
                        List<ServiceWorkers> sw = db.ServiceWorkers.Where(x => x.DeleteTime == null && x.WorkerID == w.Id && x.ServiceID == serviceid).ToList();
                        maxpage = sw.Count() / countonpage;
                        if (sw.Count() % countonpage != 0)
                        {
                            maxpage++;
                        }
                        foreach (ServiceWorkers s in sw.Skip((page - 1) * countonpage).Take(countonpage))
                        {
                            Worker temp = db.Worker.Find(s.WorkerID);
                            WorkersDataGridView.Rows.Add(temp.Id, temp.ContactPhoneNumber, temp.SecondName, temp.Name, temp.LastName, temp.Experience, temp.Position);
                        }
                    }

                  
                    //List<Worker> workerlist = db.Worker.Where(x => x.DeleteTime == null).ToList();
                    //foreach (Worker w in workerlist)
                    //{
                    //    if (db.Worker.Any(x=>x.BranchID.Equals(branchid) && x.Id.Equals(w.Id)) && db.ServiceWorkers.Any(x => x.ServiceID.Equals(serviceid) && x.WorkerID.Equals(w.Id)))
                    //    {
                    //        {
                    //            dataGridView1.Rows.Add(w.Id, w.ContactPhoneNumber, w.SecondName, w.Name, w.LastName, w.Experience, w.Position);
                    //        }
                    //    }
                    //    dataGridView1.AllowUserToAddRows = false;
                    //    dataGridView1.AllowUserToDeleteRows = false;
                    //    dataGridView1.AllowUserToOrderColumns = false;
                    //    dataGridView1.AllowUserToResizeRows = false;
                    //}
                }
                else
                {
                    List<Worker> workerlist = db.Worker.Where(x => x.DeleteTime == null).ToList();
                    maxpage = workerlist.Count() / countonpage;
                    if (workerlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Worker w in workerlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        WorkersDataGridView.Rows.Add(w.Id, w.ContactPhoneNumber, w.SecondName, w.Name, w.LastName, w.Experience, w.Position);
                    }

                }
                WorkersDataGridView.AllowUserToAddRows = false;
                WorkersDataGridView.AllowUserToDeleteRows = false;
                WorkersDataGridView.AllowUserToOrderColumns = false;
                WorkersDataGridView.AllowUserToResizeRows = false;
                List<Worker> workers = db.Worker.ToList();
                List<string> positions = new List<string>();
                foreach (Worker w in workers)
                {
                    SearchWorkerPosition.Items.Add(w.Position);//избавить от двойных повторений должностей (например два админа, зачем два раза пистаь админ в комбобоксе
                }
            }
        }
        private void FillGridBranches(int page, int countonpage)
        {
            using (ClientEntities db = new ClientEntities())
            {
                SearchBranchName.Text = "";
                SearchBranchNumber.Text = "";
                SearchBranchAddress.Text = "";
                SearchBranchCabinetsCount.Text = "";
                BranchesDataGridView.Rows.Clear();
                List<Branch> branchlist = db.Branch.Where(x => x.DeleteTime == null).ToList();
                maxpage = branchlist.Count() / countonpage;
                if (branchlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Branch b in branchlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    BranchesDataGridView.Rows.Add(b.Id, b.Address, b.Name, b.Phone, b.CountCabinets);
                }
                BranchesDataGridView.AllowUserToAddRows = false;
                BranchesDataGridView.AllowUserToDeleteRows = false;
                BranchesDataGridView.AllowUserToOrderColumns = false;
                BranchesDataGridView.AllowUserToResizeRows = false;
            }
        }
        private void FillGridCabinets(int page, int countonpage)
        {
            CabinetsDataGridView.Rows.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                CabinetNameTxtBx.Text = "";
                CabinetDescrTxtBx.Text = "";
                CabinetBranchCmbBx.SelectedIndex = -1;
                CabinetBranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                CabinetBranchCmbBx.Items.Clear();
                List<Branch> lb = db.Branch.Where(x => x.DeleteTime == null).ToList();
                foreach (Branch b in lb)
                {
                    CabinetBranchCmbBx.Items.Add(b.Name);
                }
                if (status == 10)
                {
                    List<Cabinet> cabinetlist = db.Cabinet.Where(x => x.DeleteTime == null && x.BranchID == branchid).ToList();
                    maxpage = cabinetlist.Count() / countonpage;
                    if (cabinetlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Cabinet c in cabinetlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        CabinetsDataGridView.Rows.Add(c.Id, db.Branch.Find(c.BranchID).Name, c.Description, c.Name);
                    }
                }
                else
                {
                    List<Cabinet> cabinetlist = db.Cabinet.Where(x => x.DeleteTime == null).ToList();
                    maxpage = cabinetlist.Count() / countonpage;
                    if (cabinetlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Cabinet c in cabinetlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        Branch temp = db.Branch.Find(c.BranchID);
                        CabinetsDataGridView.Rows.Add(c.Id, temp.Name, c.Description, c.Name);
                    }
                }
            }
            CabinetsDataGridView.AllowUserToAddRows = false;
            CabinetsDataGridView.AllowUserToDeleteRows = false;
            CabinetsDataGridView.AllowUserToOrderColumns = false;
            CabinetsDataGridView.AllowUserToResizeRows = false;
        }
        private void FillGridMaterials(int page, int countonpage)
        {
            MaterialNameTxtBx.Text = "";
            DescriptionTxtBx.Text = "";
            SupplierTxtBx.Text = "";
            MaterialPriceMaxGrTxtBx.Text = "";
            MaterialPriceMinGrTxtBx.Text = "";
            MaterialPriceMaxTxtBx.Text = "";
            MaterialPriceMinTxtBx.Text = "";
            using (ClientEntities db = new ClientEntities())
            {
                List<Session> session = db.Session.Where(x => x.DeleteTime == null).ToList();

                //foreach (Session s in session)
                //{
                //    //if (s.ReduceMaterial == false)
                //    //    b = true;
                //}
                //  if (!b) ReduceMaterialBtn.Enabled = false;
                MaterialsDataGridView.Rows.Clear();
                List<Material> materiallist = db.Material.Where(x => x.DeleteTime == null).ToList();
                maxpage = materiallist.Count() / countonpage;
                if (materiallist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Material m in materiallist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    MaterialsDataGridView.Rows.Add(m.Id, m.Name, m.TheCostForTheAmount, m.CostPerPiece, m.Description, m.NameOfSupplier);
                }
                MaterialsDataGridView.AllowUserToAddRows = false;
                MaterialsDataGridView.AllowUserToDeleteRows = false;
                MaterialsDataGridView.AllowUserToOrderColumns = false;
                MaterialsDataGridView.AllowUserToResizeRows = false;
            }
        }
        private void FillGridPays(int page, int countonpage)
        {
            datepaysearch = Convert.ToDateTime("1999-10-11");
            PayPriceMaxTxtBx.Text = "";
            PayPriceMinTxtBx.Text = "";
            PayClientLNTxtBx.Text = "";
            PayClientNameTxtBx.Text = "";
            PayClientSNTxtBx.Text = "";
            PayWorkerLNTxtBx.Text = "";
            PayWorkerNameTxtBx.Text = "";
            PayWorkerSNTxtBx.Text = "";
            using (ClientEntities db = new ClientEntities())
            {
                PaysDataGridView.Rows.Clear();
                List<Pay> paylist = db.Pay.Where(x => x.DeleteTime == null).ToList();
                maxpage = paylist.Count() / countonpage;
                if (paylist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Pay p in paylist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    DateTime dtm = Convert.ToDateTime(p.Date);
                    string d = dtm.ToShortDateString();
                    PaysDataGridView.Rows.Add(p.Id, p.Client.SecondName + ' ' + p.Client.Name + ' ' + p.Client.LastName, d, p.Price, p.SessionID, p.Worker.SecondName + ' ' + p.Worker.Name + ' ' + p.Worker.LastName);
                }
                PaysDataGridView.AllowUserToAddRows = false;
                PaysDataGridView.AllowUserToDeleteRows = false;
                PaysDataGridView.AllowUserToOrderColumns = false;
                PaysDataGridView.AllowUserToResizeRows = false;
            }
        }
        private void FillGridServices(int page, int countonpage)
        {
            ServiceNameTxtBx.Text = "";
            MinTimeInMinTxtBx.Text = "";
            MaxTimeInMinTxtBx.Text = "";
            PriceServiceMaxTxtBx.Text = "";
            PriceServiceMinTxtBx.Text = "";
            WorkersCountTxtBx.Text = "";
            ServicesDataGridView.Rows.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                List<Service> servicelist = new List<Service>();
                if (status == 8)
                {
                    List<CabinetServices> cabser = db.CabinetServices.Where(x => x.DeleteTime == null && x.CabinetID == cabinetid).ToList();
                    maxpage = cabser.Count() / countonpage;
                    if (cabser.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (CabinetServices c in cabser.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        Service temp = db.Service.Where(x => x.DeleteTime == null && x.Id == c.ServiceID).FirstOrDefault();
                        servicelist.Add(temp);
                    }
                }
                else
                {
                    servicelist = db.Service.Where(x => x.DeleteTime == null).ToList();
                    maxpage = servicelist.Count() / countonpage;
                    if (servicelist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                }
                foreach (Service s in servicelist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    ServicesDataGridView.Rows.Add(s.Id, s.CountWorker, s.Time, s.Name, s.Price);
                }
            }
            ServicesDataGridView.AllowUserToAddRows = false;
            ServicesDataGridView.AllowUserToDeleteRows = false;
            ServicesDataGridView.AllowUserToOrderColumns = false;
            ServicesDataGridView.AllowUserToResizeRows = false;
        }
        //private void FillGridSessions()
        //{
        //    using (ClientEntities db = new ClientEntities())
        //    {
        //        BranchCmbBx.Items.Clear();
        //        SessionsDataGridView.Rows.Clear();
        //        List<Session> sessionlist = db.Session.Where(x => x.DeleteTime == null).ToList();
        //        foreach (Session s in sessionlist)
        //        {
        //            DateTime temp1 = Convert.ToDateTime(s.Date);
        //            string dt = temp1.ToShortDateString();
        //            DateTime temp = Convert.ToDateTime(s.TimeStart);
        //            string ts = temp.ToShortTimeString();
        //            temp = Convert.ToDateTime(s.TimeEnd);
        //            string te = temp.ToShortTimeString();
        //            // List<SessionWorkers> temp = db.SessionWorkers.Where(x => x.SessionID == s.Id).ToList();
        //            SessionsDataGridView.Rows.Add(s.Id, db.Client.Find(s.ClientID).Name, s.CountWorker, db.Branch.Find(s.BranchID).Name, dt, ts, te, s.Price);
        //        }
        //        SessionsDataGridView.AllowUserToAddRows = false;
        //        SessionsDataGridView.AllowUserToDeleteRows = false;
        //        SessionsDataGridView.AllowUserToOrderColumns = false;
        //        SessionsDataGridView.AllowUserToResizeRows = false;
        //        List<Branch> branches = db.Branch.ToList();
        //        foreach (Branch b in branches)
        //        {
        //            BranchCmbBx.Items.Add(b.Name);
        //        }
        //        BranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        //        BranchCmbBx.SelectedIndex = -1;
        //    }
        //}
        private void FillGridSessions(int page, int countonpage)
        {
            using (ClientEntities db = new ClientEntities())
            {
                timestartforsearch = Convert.ToDateTime("1999-10-11");
                timeendforsearch = Convert.ToDateTime("1999-10-11");
                ClientSecondNameTxtBx.Text = "";
                ClientNameTxtBx.Text = "";
                ClientLastNameTxtBx.Text = "";
                BranchCmbBx.SelectedIndex = -1;
                BranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
              //  DateStartSessionDtTm.Value = DateTime.Now;
              //  DateEndSessionDtTm.Value = DateTime.Now;
              //  TimeStartSessionDtTm.Value = DateTime.Now;
              //  TimeEndSessionDtTm.Value = DateTime.Now;
                CountWorkersTxtBx.Text = "";
                BranchCmbBx.Items.Clear();
                SessionsDataGridView.Rows.Clear();
                List<Session> sessionlist = db.Session.Where(x => x.DeleteTime == null).ToList();
                maxpage = sessionlist.Count() / countonpage;
                if (sessionlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Session s in sessionlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    DateTime temp1 = Convert.ToDateTime(s.Date);
                    string dt = temp1.ToShortDateString();
                    DateTime temp = Convert.ToDateTime(s.TimeStart);
                    string ts = temp.ToShortTimeString();
                    temp = Convert.ToDateTime(s.TimeEnd);
                    string te = temp.ToShortTimeString();
                    // List<SessionWorkers> temp = db.SessionWorkers.Where(x => x.SessionID == s.Id).ToList();
                    SessionsDataGridView.Rows.Add(s.Id, db.Client.Find(s.ClientID).Name, s.CountWorker, db.Branch.Find(s.BranchID).Name, dt, ts, te, s.Price);
                }
                SessionsDataGridView.AllowUserToAddRows = false;
                SessionsDataGridView.AllowUserToDeleteRows = false;
                SessionsDataGridView.AllowUserToOrderColumns = false;
                SessionsDataGridView.AllowUserToResizeRows = false;
                List<Branch> branches = db.Branch.ToList();
                foreach (Branch b in branches)
                {
                    BranchCmbBx.Items.Add(b.Name);
                }
            }
        }
        private void FillGridWorkingHoursForWorker(int workid)
        {
            using (ClientEntities db = new ClientEntities())
            {
                dataGridView9.Rows.Clear();
                var temp = db.WorkingHour.Where(x => x.DeleteTime == null && x.WorkerID == workid);
                List<WorkingHour> workinghourslist = temp.ToList();
                foreach (WorkingHour w in workinghourslist)
                {
                    DateTime s = Convert.ToDateTime(w.TimeStart);
                    DateTime e = Convert.ToDateTime(w.TimeEnd);
                    dataGridView9.Rows.Add(w.Id, Convert.ToString(s), Convert.ToString(s.TimeOfDay), Convert.ToString(e.TimeOfDay), db.Worker.Find(w.WorkerID).Name);
                }
            }
        }
        private void FillGridWorkingHours(int page, int countonpage)
        {
            SearchWorkerWorkinHoursCmbBx.SelectedIndex = -1;
            SearchWorkerWorkinHoursCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            using (ClientEntities db = new ClientEntities())
            {
                dataGridView9.Rows.Clear();
                List<Worker> ww = db.Worker.ToList();
                foreach (Worker w in ww)
                {
                   SearchWorkerWorkinHoursCmbBx.Items.Add(w.SecondName+' '+w.Name+' '+w.LastName);
                }
                SearchWorkerWorkinHoursCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                SearchWorkerWorkinHoursCmbBx.SelectedIndex = -1;
                if (status == 11)
                {
                    List<WorkingHour> workinghourlist = db.WorkingHour.Where(x => x.DeleteTime == null).ToList();
                    maxpage = workinghourlist.Count() / countonpage;
                    if (workinghourlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (WorkingHour w in workinghourlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        if (db.WorkingHour.Any(x => x.WorkerID == BackId))
                        {
                            dataGridView9.Rows.Add(w.Id, w.Branch.Name, w.TimeStart, w.TimeEnd, w.Worker.LastName + ' ' + w.Worker.Name + ' ' + w.Worker.SecondName);
                        }
                    }
                }
                else
                {
                    List<WorkingHour> workinghourlist = db.WorkingHour.Where(x => x.DeleteTime == null).ToList();
                    dataGridView9.Rows.Clear();
                    var groupbyworkerid = from w in db.WorkingHour.Where(x=>x.DeleteTime==null)
                                      group w by w.WorkerID;
                    foreach (var g in groupbyworkerid)
                    {
                        dataGridView9.Rows.Add(db.Worker.Find(g.Key).SecondName+' '+db.Worker.Find(g.Key).Name+' '+ db.Worker.Find(g.Key).LastName);
                        maxpage = g.Count() / countonpage;
                        if (g.Count() % countonpage != 0)
                        {
                            maxpage++;
                        }
                        foreach (var wc in g.Skip((page - 1) * countonpage).Take(countonpage))
                        {
                            DateTime s = Convert.ToDateTime(wc.TimeStart);
                            DateTime e = Convert.ToDateTime(wc.TimeEnd);
                            dataGridView9.Rows.Add(wc.Id,db.Branch.Find(wc.BranchID).Name, Convert.ToString(s.ToShortDateString()), Convert.ToString(s.ToShortTimeString()), Convert.ToString(e.ToShortTimeString()), (db.Worker.Find(wc.WorkerID).SecondName)+' '+(db.Worker.Find(wc.WorkerID).Name)+' '+(db.Worker.Find(wc.WorkerID).LastName));
                        }
                    }
                }
            }
            dataGridView9.AllowUserToAddRows = false;
            dataGridView9.AllowUserToDeleteRows = false;
            dataGridView9.AllowUserToOrderColumns = false;
            dataGridView9.AllowUserToResizeRows = false;
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с работниками
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (status == 9)
                {
                    bool b = false;
                    int temp = Convert.ToInt32(this.WorkersDataGridView.CurrentRow.Cells[0].Value);
                    Worker wor = db.Worker.Where(x => x.Id == temp && x.DeleteTime == null).FirstOrDefault();
                    string[] dateandtimeold = Convert.ToString(date).Split(' ');
                    string rightdate = dateandtimeold[0];
                    string[] dateandtimetsold = Convert.ToString(timestart).Split(' ');
                    string rightts = dateandtimetsold[1];
                    string[] dateandtimeteold = Convert.ToString(timeend).Split(' ');
                    string rightte = dateandtimeteold[1];
                    DateTime rightdateandts = Convert.ToDateTime(rightdate + ' ' + rightts);
                    DateTime  rightdateandte = Convert.ToDateTime(rightdate + ' ' + rightte);
                    // List<WorkingHour> whlist = db.WorkingHour.Where(x => (Convert.ToDateTime(timestart) > x.TimeStart && Convert.ToDateTime(timeend) < x.TimeEnd) || (Convert.ToDateTime(timestart) > x.TimeStart && Convert.ToDateTime(timeend) > x.TimeEnd) || (Convert.ToDateTime(timestart) < x.TimeStart && Convert.ToDateTime(timeend) < x.TimeEnd)|| (Convert.ToDateTime(timestart) < x.TimeStart && Convert.ToDateTime(timeend) > x.TimeEnd) && x.WorkerID == temp && x.DeleteTime==null).ToList();
                    List<WorkingHour> whlist = db.WorkingHour.Where(x => x.WorkerID == wor.Id && x.DeleteTime == null).ToList();//ошибка?
                    foreach (WorkingHour w in whlist)
                    {
                        if (w.TimeEnd > rightdateandte && w.TimeStart < Convert.ToDateTime(rightdateandts))
                        {
                            workerid = temp;
                            b = true;
                            this.Close();
                        }                           
                    }
                    if (!b)
                    {
                            MessageBox.Show("Работник:" + " " + db.Worker.Find(temp).Name + " " + "занят в это время, пожалуйста выберите другого!", "Тату салон");
                        }
                    }
                else
                {
                    WorkerCard Workercard = new WorkerCard();
                    int id = Convert.ToInt16(this.WorkersDataGridView.CurrentRow.Cells[0].Value);
                    Workercard.Currentid = id;
                    Workercard.ShowDialog();
                    FillGridWorkers(currentpage, currentcountonpage);
                    label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button8.Enabled = false; }
                    else
                    { button8.Enabled = true; }
                }
            }
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с услугами
        {
            using (ClientEntities db = new ClientEntities())
            {
                int temp = Convert.ToInt32(this.ServicesDataGridView.CurrentRow.Cells[0].Value);
                int c = status;
                switch (c)
                {
                    case 2:
                        if (!db.CabinetServices.Any(x => x.CabinetID.Equals(backid) && x.ServiceID.Equals(temp) && x.DeleteTime == null))
                        {
                            serviceid = temp;
                            this.Close();
                        }
                        else MessageBox.Show("Данная услуга уже добавлена.", "Тату салон");
                        break;
                    case 5:
                        if (!db.ServiceWorkers.Any(x => x.WorkerID.Equals(backid) && x.ServiceID.Equals(temp) && x.DeleteTime == null))
                        {
                            serviceid = temp;
                            this.Close();
                        }
                        else MessageBox.Show("Данная услуга уже добавлена.", "Тату салон");
                        break;
                    case 6:
                        if (!db.SessionServices.Any(x => x.SessionID.Equals(backid) && x.ServiceID.Equals(temp) && x.DeleteTime == null))
                        {
                            backid = temp;
                            MessageBox.Show("Данная услуга успешно добавлена.", "Тату салон");
                        }
                        else MessageBox.Show("Данная услуга уже добавлена.", "Тату салон");
                        break;
                    case 8:
                        serviceid = temp;
                        this.Close();
                        break;
                    default:
                        ServiceCard Servicecard = new ServiceCard();
                        Servicecard.Currentid = temp;
                        Servicecard.ShowDialog();
                        FillGridServices(currentpage, currentcountonpage);
                        label21.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                        if (currentpage == maxpage)
                        { button17.Enabled = false; }
                        else
                        { button17.Enabled = true; }
                        break;
                }
            }
        }
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с клиентами
        {
            int temp = Convert.ToInt32(this.ClientsDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                if (status == 7)
                {
                    clientid = temp;////////////////////////////
                    this.Close();
                }
                else
                {
                    ClientCard Clientcard = new ClientCard();
                    Clientcard.Currentid = temp;
                    Clientcard.ShowDialog();
                    FillGridClients(currentpage, currentcountonpage);
                    label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button3.Enabled = false; }
                    else
                    { button3.Enabled = true; }
                }
            }
        }
        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с сеансами
        {
            SessionCard Sessioncard = new SessionCard();
            int id = Convert.ToInt16(this.SessionsDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                Sessioncard.Currentid = id;
                Sessioncard.ShowDialog();
                FillGridSessions(currentpage, currentcountonpage);
            }
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с платежами
        {
            PayCard Paycard = new PayCard();
            int id = Convert.ToInt16(this.PaysDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                Paycard.Currentid = id;
                Paycard.ShowDialog();
                FillGridPays(currentpage, currentcountonpage);
                label44.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button6.Enabled = false; }
                else
                { button6.Enabled = true; }
            }
        }
        private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с кабинетами
        {
            int temp = Convert.ToInt32(this.CabinetsDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                if (status == 10)
                {
                    cabinetid = temp;
                    this.Close();
                }
                else
                {
                    CabinetCard Cabinetcard = new CabinetCard();
                    Cabinetcard.Currentid = temp;
                    Cabinetcard.ShowDialog();
                    FillGridCabinets(currentpage, currentcountonpage);
                    label63.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button14.Enabled = false; }
                    else
                    { button14.Enabled = true; }
                    
                }
            }
        }
        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с филиалами
        {
            BranchCard Branchcard = new BranchCard();
            int id = Convert.ToInt16(this.BranchesDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                Branchcard.Currentid = id;
                Branchcard.ShowDialog();
                FillGridBranches(currentpage, currentcountonpage);
                label22.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button20.Enabled = false; }
                else
                { button20.Enabled = true; }                
            }
        }
        private void dataGridView8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//двойной клик по таблице с материалами
        {
            int temp = Convert.ToInt16(this.MaterialsDataGridView.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                int c = status;
                switch (c)
                {
                    case 3:
                        materialid = temp;
                        this.Close();
                        break;
                    case 4:
                        if (!db.ServiceMaterials.Any(x => x.ServiceID.Equals(backid) && x.MaterialID.Equals(temp) && x.DeleteTime == null))
                        {
                            materialid = temp;
                            this.Close();
                        }
                        else MessageBox.Show("Данный материал уже добавлен.", "Тату салон");
                        break;
                    default:
                        MaterialCard Materialcard = new MaterialCard();
                        Materialcard.Currentid = temp;
                        Materialcard.ShowDialog();
                        FillGridMaterials(currentpage, currentcountonpage);
                        label30.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                        if (currentpage == maxpage)
                        { button30.Enabled = false; }
                        else
                        { button30.Enabled = true; }                       
                        break;
                }
            }
        }
        private void dataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkingHourCard Workinghourcard = new WorkingHourCard();
            int id = Convert.ToInt16(this.dataGridView9.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                Workinghourcard.Currentid = id;
                Workinghourcard.ShowDialog();
                FillGridWorkingHours(currentpage, currentcountonpage);
                label46.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button37.Enabled = false; }
                else
                { button37.Enabled = true; }
            }
        }
        private void AddClientBtn_Click_1(object sender, EventArgs e)
        {
            ClientEdit clientedit = new ClientEdit();
            clientedit.Name = "Новый клиент";
            clientedit.ShowDialog();
            FillGridClients(currentpage, currentcountonpage);
        }
        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            WorkerEdit workeredit = new WorkerEdit();
            workeredit.Name = "Новый сотрудник";
            workeredit.ShowDialog();
            FillGridWorkers(currentpage, currentcountonpage);
        }
        private void AddBranchBtn_Click(object sender, EventArgs e)
        {
            BranchEdit branchedit = new BranchEdit();
            branchedit.Name = "Новый филиал";
            branchedit.ShowDialog();
            FillGridBranches(currentpage, currentcountonpage);
        }
        private void AddCabinetBtn_Click(object sender, EventArgs e)
        {
            CabinetEdit cabinetedit = new CabinetEdit();
            cabinetedit.Name = "Новый кабинет";
            cabinetedit.ShowDialog();
            FillGridCabinets(currentpage, currentcountonpage);
        }
        private void AddMaterialBtn_Click(object sender, EventArgs e)
        {
            MaterialEdit materialedit = new MaterialEdit();
            materialedit.Name = "Новый материал";
            materialedit.ShowDialog();
            FillGridMaterials(currentpage, currentcountonpage);
        }
        private void AddSessionBtn_Click(object sender, EventArgs e)
        {
            SessionEdit sessionedit = new SessionEdit();
            sessionedit.Name = "Новый сеанс";
            sessionedit.ShowDialog();
            FillGridSessions(currentpage, currentcountonpage);
        }
        private void AddPayBtn_Click(object sender, EventArgs e)
        {
            PayCard paycard = new PayCard();
            paycard.Name = "Новый платеж";
            paycard.ShowDialog();
            FillGridPays(currentpage, currentcountonpage);
        }
        private void AddServiceBtn_Click(object sender, EventArgs e)
        {
            ServiceEdit serviceedit = new ServiceEdit();
            serviceedit.Name = "Новая услуга";
            serviceedit.ShowDialog();
            FillGridServices(currentpage, currentcountonpage);
        }
        private void AddWorkingHourBtn_Click(object sender, EventArgs e)
        {
            WorkingHourEdit workinghouredit = new WorkingHourEdit();
            workinghouredit.ShowDialog();
            FillGridWorkingHours(currentpage, currentcountonpage);
            label46.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button37.Enabled = false; }
            else
            { button37.Enabled = true; }
        }
        private void SearchClientBtn_Click(object sender, EventArgs e)
        {
            ClientsDataGridView.Rows.Clear();
            string name = "";
            string phone = "";
            string lastname = "";
            string secondname = "";
            if (SearchClientName.Text != "") name = Char.ToUpper(SearchClientName.Text[0]) + SearchClientName.Text.Substring(1);
            if (SearchClientSecondName.Text != "") secondname = Char.ToUpper(SearchClientSecondName.Text[0]) + SearchClientSecondName.Text.Substring(1);
            if (SearchClientLastName.Text != "") lastname = Char.ToUpper(SearchClientLastName.Text[0]) + SearchClientLastName.Text.Substring(1);
            if (SearchClientNumber.Text != "") phone = SearchClientNumber.Text;
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                    string commandText = @"SELECT * FROM Client WHERE (Client.Name LIKE '%" + name + "%') AND (Client.SecondName LIKE '%" + secondname + "%') AND (Client.LastName LIKE '%" + lastname + "%') AND Client.ContactPhoneNumber LIKE '%" + phone + "%' AND Client.DeleteTime is null";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[3].ToString();
                        data[data.Count - 1][2] = reader[4].ToString();
                        data[data.Count - 1][3] = reader[2].ToString();
                        data[data.Count - 1][4] = reader[1].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        ClientsDataGridView.Rows.Add(s);
                    Connect.Close();               
            }
        }
        private void SearchWorkerBtn_Click(object sender, EventArgs e)
        {
            WorkersDataGridView.Rows.Clear();
            string secondname = "";
            string name = "";
            string lastname = "";
            string str1 = "";
            if (SearchWorkerName.Text != "") name = Char.ToUpper(SearchWorkerName.Text[0]) + SearchWorkerName.Text.Substring(1);
            if (SearchWorkerLastName.Text != "") lastname = Char.ToUpper(SearchWorkerLastName.Text[0]) + SearchWorkerLastName.Text.Substring(1);
            if (SearchWorkerSecondName.Text != "") secondname = Char.ToUpper(SearchWorkerSecondName.Text[0]) + SearchWorkerSecondName.Text.Substring(1);
            if (SearchWorkerPosition.Text != "") str1 = Char.ToUpper(SearchWorkerPosition.Text[0]) + SearchWorkerPosition.Text.Substring(1);
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT * FROM Worker WHERE Worker.Name LIKE '%" + name + "%' AND Worker.SecondName LIKE '%"+ secondname + "%' AND Worker.LastName LIKE '%"+lastname+"%' AND Worker.Position LIKE '%" + str1 + "%' AND Worker.ContactPhoneNumber LIKE '%" + SearchWorkerNumber.Text + "%' AND Worker.Experience LIKE '%"+ExperienceTxtBx.Text+"%' AND Worker.DeleteTime is null"; //AND Branch.CountCabinets LIKE '%" + SearchBranchCabinetsCount.Text + "%'";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                DataSet dataSet = new DataSet();
                DataTable table = dataSet.Tables.Add("Table");
                IDataReader reader = Command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[7]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[3].ToString();
                    data[data.Count - 1][3] = reader[4].ToString();
                    data[data.Count - 1][4] = reader[2].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }
                reader.Close();
                foreach (string[] s in data)
                    WorkersDataGridView.Rows.Add(s);
            
                Connect.Close();
            
            }
        }
        private void SearchBranchBtn_Click(object sender, EventArgs e)
        {
            BranchesDataGridView.Rows.Clear();
            string str = "";
            string str1 = "";
            if (SearchBranchName.Text != "") str = Char.ToUpper(SearchBranchName.Text[0]) + SearchBranchName.Text.Substring(1);
            if (SearchBranchAddress.Text!="") str1 = Char.ToUpper(SearchBranchAddress.Text[0]) + SearchBranchAddress.Text.Substring(1);
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT * FROM Branch WHERE Branch.Name LIKE '%" + str + "%' AND Branch.Address LIKE '%" + str1 + "%' AND Branch.Phone LIKE '%" + SearchBranchNumber.Text + "%' AND Branch.CountCabinets LIKE '%" + SearchBranchCabinetsCount.Text + "%'";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                DataSet dataSet = new DataSet();
                DataTable table = dataSet.Tables.Add("Table");
                IDataReader reader = Command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[5]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[5].ToString();
                }
                reader.Close();
                foreach (string[] s in data)
                    BranchesDataGridView.Rows.Add(s);
                Connect.Close();
            }
        }    
        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            currentpage = 1;
            switch (tabControl1.SelectedTab.Text)
            {
                case "Клиенты":
                    FillGridClients(currentpage, currentcountonpage);
                    button1.Enabled = false;
                    label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button3.Enabled = false; }
                    else
                    { button3.Enabled = true; }
                    break;
                //currentpage = 1;
                //FillGridClients(currentpage, currentcountonpage);
                //button4.Enabled = false;
                //label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                //if (currentpage == maxpage)
                //{ button5.Enabled = false; }
                //else
                //{ button5.Enabled = true; }
                //break;
                case "Сотрудники":
                    FillGridWorkers(currentpage, currentcountonpage);
                    button7.Enabled = false;
                    label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button8.Enabled = false; }
                    else
                    { button8.Enabled = true; }
                    break;
                case "Филиалы":
                    FillGridBranches(currentpage, currentcountonpage);
                    button19.Enabled = false;
                    label22.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button20.Enabled = false; }
                    else
                    { button20.Enabled = true; }
                    break;
                case "Кабинеты":
                    FillGridCabinets(currentpage, currentcountonpage);
                    button13.Enabled = false;
                    label63.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button14.Enabled = false; }
                    else
                    { button14.Enabled = true; }
                    break;
                case "Материалы":
                    FillGridMaterials(currentpage, currentcountonpage);
                    button29.Enabled = false;
                    label30.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button30.Enabled = false; }
                    else
                    { button30.Enabled = true; }
                    break;
                case "Сеансы":
                    //FillGridSessions();
                    //break;

                    //currentpage = 1;
                    FillGridSessions(currentpage, currentcountonpage);
                    button10.Enabled = false;
                    label8.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button11.Enabled = false; }
                    else
                    { button11.Enabled = true; }
                    break;
                case "Услуги":
                    FillGridServices(currentpage, currentcountonpage);
                    button16.Enabled = false;
                    label21.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button17.Enabled = false; }
                    else
                    { button17.Enabled = true; }
                    break;
                case "Платежи":
                    FillGridPays(currentpage, currentcountonpage);
                    button4.Enabled = false;
                    label44.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button6.Enabled = false; }
                    else
                    { button6.Enabled = true; }
                    break;
                case "Режим работы":
                    FillGridWorkingHours(currentpage, currentcountonpage);
                    button36.Enabled = false;
                    label46.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button37.Enabled = false; }
                    else
                    { button37.Enabled = true; }
                    break;
                case "Статистика":
                    FillChartCmbx();
                    break;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Expenses ex = new Expenses();
            ex.ShowDialog();
        }
        private void FillChartCmbx()///////////////////////////сбросить дэйттаймпикеры оба
        {
            using (ClientEntities db = new ClientEntities())
            {
                label43.Visible = false;
                ProceedsTxtBx.Visible = false;
                ChartWorkerCmbBx.Items.Clear();
                ChartServiceCmbBx.Items.Clear();
                ChartBranchCmbBx.Items.Clear();
                ChartServiceCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                ChartWorkerCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                ChartBranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                List<Worker> lw = db.Worker.Where(x => x.DeleteTime == null).ToList();
                foreach (Worker w in lw)
                {
                    ChartWorkerCmbBx.Items.Add(w.SecondName + ' ' + w.Name + ' ' + w.LastName);
                }
                List<Service> ls = db.Service.Where(x => x.DeleteTime == null).ToList();
                foreach (Service s in ls)
                {
                    ChartServiceCmbBx.Items.Add(s.Name);
                }
                List<Branch> lb = db.Branch.Where(x => x.DeleteTime == null).ToList();
                foreach (Branch b in lb)
                {
                    ChartBranchCmbBx.Items.Add(b.Name);
                }
            }
        }
        private void BuildChart(Worker worker)
        {
            using (ClientEntities db = new ClientEntities())
            {
                string title = worker.SecondName+' '+worker.Name+' '+worker.LastName;
                //chart1.Titles.Add(title);
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum = 0;
                double sum1 = 0;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                List<SessionServices> workerservices = db.SessionServices.Where(x => x.WorkerID == worker.Id && x.DeleteTime==null).ToList();///////////
                foreach (SessionServices s in workerservices)
                {
                    if (!dic.ContainsKey(Convert.ToInt16(s.ServiceID)))
                    {
                        dic.Add(Convert.ToInt16(s.ServiceID), 1);
                    }
                    else
                    {
                        dic[Convert.ToInt16(s.ServiceID)] = dic[Convert.ToInt16(s.ServiceID)] + 1;
                    }
                }
                foreach (KeyValuePair<int, int> d in dic)
                {
                    Service ser = db.Service.Where(x => x.Id == d.Key && x.DeleteTime == null).FirstOrDefault();
                    sum1 = Convert.ToDouble(ser.Price) * d.Value;
                    sum = sum + sum1;
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(ser.Name, sum1);
                }
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Service service)///
        {
            using (ClientEntities db = new ClientEntities())
            {
                string title = service.Name;
                //chart1.Titles.Add(title);
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum = 0;
                double sum1 = 0;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                List<SessionServices> ss = db.SessionServices.Where(x => x.ServiceID == service.Id && x.DeleteTime == null).ToList();
                foreach (SessionServices p in ss)
                {
                    if (!dic.ContainsKey(Convert.ToInt16(p.WorkerID)))
                    {
                        dic.Add(Convert.ToInt16(p.WorkerID), 1);
                    }
                    else
                    {
                        dic[Convert.ToInt16(p.WorkerID)] = dic[Convert.ToInt16(p.WorkerID)] + 1;
                    }
                }
                foreach (KeyValuePair<int, int> d in dic)
                {
                    Worker wor = db.Worker.Where(x => x.Id == d.Key && x.DeleteTime == null).FirstOrDefault();
                    sum1 = Convert.ToDouble(service.Price) * d.Value;
                    sum = sum + sum1;
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(wor.SecondName + ' ' + Char.ToUpper(wor.Name[0]) + ". " + Char.ToUpper(wor.LastName[0]) + ". ", sum1);
                    
                }
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Branch branch)
        {
            using (ClientEntities db = new ClientEntities())
            {
                string title = branch.Name;
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum = 0;
                double sum1 = 0;
                Dictionary<int,int> dic= new Dictionary<int, int>();
                List<Session> sessioninbranch = db.Session.Where(x => x.BranchID == branch.Id).ToList();///////////
                foreach (Session p in sessioninbranch)
                {
                   List<SessionServices> temp = db.SessionServices.Where(x => x.SessionID == p.Id && x.DeleteTime == null).ToList();
                    foreach (SessionServices s in temp)
                    {
                        if(!dic.ContainsKey(Convert.ToInt16(s.ServiceID)))
                        {
                            dic.Add(Convert.ToInt16(s.ServiceID), 1);
                        }
                        else
                        {
                            dic[Convert.ToInt16(s.ServiceID)] = dic[Convert.ToInt16(s.ServiceID)] + 1;
                        }
                    }
                }
                foreach (KeyValuePair<int, int> d in dic)
                {
                    Service ser = db.Service.Where(x => x.Id == d.Key && x.DeleteTime == null).FirstOrDefault();
                    sum1 = Convert.ToDouble(ser.Price)*d.Value;
                    sum = sum + sum1;
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(ser.Name, sum1);
                }

                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Service service,Branch branch)
        {
            using (ClientEntities db = new ClientEntities())
            {
               // chart1.Titles[0].Text = "";
                string title = branch.Name;
               // chart1.Titles.Add(title);
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum = 0;
                List<SessionServices> sas = new List<SessionServices>();
                List<Session> sessioninbranch = db.Session.Where(x => x.BranchID == branch.Id && x.DeleteTime == null).ToList();
                foreach(Session s in sessioninbranch)
                {
                    sas = db.SessionServices.Where(x => x.SessionID == s.Id && x.DeleteTime == null).ToList();
                }
                foreach (SessionServices s in sas)
                {
                    Service temp = db.Service.Where(x => x.Id == s.ServiceID && x.DeleteTime == null).FirstOrDefault();
                    sum = sum + Convert.ToDouble(temp.Price);
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(service.Name, service.Price);
                }
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Worker worker, Branch branch)
        {
            using (ClientEntities db = new ClientEntities())
            {
                string title = branch.Name;
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum = 0;
                List<SessionServices> workerservices = db.SessionServices.Where(x => x.WorkerID == worker.Id).ToList();///////////
                foreach (SessionServices s in workerservices)
                {
                    Service temp = db.Service.Where(x => x.Id == s.ServiceID).FirstOrDefault();
                    sum = sum + Convert.ToDouble(temp.Price);
                }
                this.chart1.Series["Заработано (руб.)"].Points.AddXY(worker.SecondName + ' ' + worker.Name + ' ' + worker.LastName, sum);
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Worker worker,Service service)
        {
            using (ClientEntities db = new ClientEntities())
            {
                chart1.Titles[0].Text = "";
                string title = service.Name;
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum1 = 0;
                double sum = 0;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                List<SessionServices> ss = db.SessionServices.Where(x => x.ServiceID == service.Id && x.WorkerID==worker.Id && x.DeleteTime == null).ToList();
                foreach (SessionServices p in ss)
                {
                    if (!dic.ContainsKey(Convert.ToInt16(p.WorkerID)))
                    {
                        dic.Add(Convert.ToInt16(p.WorkerID), 1);
                    }
                    else
                    {
                        dic[Convert.ToInt16(p.WorkerID)] = dic[Convert.ToInt16(p.WorkerID)] + 1;
                    }
                    //    sum = sum + Convert.ToDouble(service.Price);
                    //    Worker temp = db.Worker.Where(x => x.Id == p.WorkerID).FirstOrDefault();
                    //    string name = temp.Name;
                    //    string lastname = temp.LastName;
                    //    char n = Char.ToUpper(name[0]);
                    //    char ln = Char.ToUpper(lastname[0]);
                    //    this.chart1.Series["Заработано (руб.)"].Points.AddXY(temp.SecondName + ' ' + n + ". " + ln + ". ", service.Price);
                    //}
                }
                foreach (KeyValuePair<int, int> d in dic)
                {
                    sum1 = Convert.ToDouble(service.Price) * d.Value;
                    sum = sum + sum1;
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(worker.SecondName + ' ' + Char.ToUpper(worker.Name[0]) + ". " + Char.ToUpper(worker.LastName[0]) + ". ", sum1);

                }
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void BuildChart(Branch branch, Worker worker, Service service)
        {
            using (ClientEntities db = new ClientEntities())
            {
                chart1.Titles[0].Text = "";
                string title = branch.Name+','+service.Name;
                chart1.Titles[0].Text = title;
                chart1.Titles[0].Font = new Font("Utopia", 16);
                double sum1 = 0;
                double sum = 0;
                Dictionary<int, int> dic = new Dictionary<int, int>();
                List<SessionServices> ss = new List<SessionServices>();
                List<Session> temp = db.Session.Where(x => x.BranchID == branch.Id && x.DeleteTime == null).ToList();
                foreach (Session ses in temp)
                {
                    ss = db.SessionServices.Where(x => x.SessionID == ses.Id && x.ServiceID == service.Id && x.WorkerID == worker.Id && x.DeleteTime == null).ToList();
                }
                foreach (SessionServices p in ss)
                {
                    if (!dic.ContainsKey(Convert.ToInt16(p.WorkerID)))
                    {
                        dic.Add(Convert.ToInt16(p.WorkerID), 1);
                    }
                    else
                    {
                        dic[Convert.ToInt16(p.WorkerID)] = dic[Convert.ToInt16(p.WorkerID)] + 1;
                    }
                }
                foreach (KeyValuePair<int, int> d in dic)
                {
                    sum1 = Convert.ToDouble(service.Price) * d.Value;
                    sum = sum + sum1;
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(worker.SecondName + ' ' + Char.ToUpper(worker.Name[0]) + ". " + Char.ToUpper(worker.LastName[0]) + ". ", sum1);

                }
                ProceedsTxtBx.Text = Convert.ToString(sum);
            }
        }
        private void SearchChartBtn_Click(object sender, EventArgs e)
        {
            label43.Visible = true;
            ProceedsTxtBx.Visible = true;
            string title = "r";
            chart1.Series[0].Points.Clear();
            if (chart1.Titles.Count == 0)
            {
                chart1.Titles.Add(title);
            }
            chart1.Titles[0].Text = "";
            using (ClientEntities db = new ClientEntities())
            {
                if (ChartWorkerCmbBx.Text!="" && ChartServiceCmbBx.Text!="" && ChartBranchCmbBx.Text=="")
                {
                    string[] fio = ChartWorkerCmbBx.Text.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Worker worker = db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname && x.DeleteTime == null).FirstOrDefault();
                    string servicename = ChartServiceCmbBx.Text;
                    Service service = db.Service.Where(x => x.Name == servicename && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(worker, service);
                }
                if (ChartWorkerCmbBx.Text != "" && ChartServiceCmbBx.Text != "" && ChartBranchCmbBx.Text != "")
                {
                    string servicename = ChartServiceCmbBx.Text;
                    Service service = db.Service.Where(x => x.Name == servicename && x.DeleteTime == null).FirstOrDefault();
                    string branchname = ChartBranchCmbBx.Text;
                    string[] fio = ChartWorkerCmbBx.Text.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Worker worker = db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname && x.DeleteTime == null).FirstOrDefault();
                    Branch branch = db.Branch.Where(x => x.Name == branchname && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(branch,worker,service);
                }
                if (ChartWorkerCmbBx.Text != "" && ChartServiceCmbBx.Text == "" && ChartBranchCmbBx.Text != "")
                {
                    string[] fio = ChartWorkerCmbBx.Text.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Worker worker = db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname && x.DeleteTime == null).FirstOrDefault();
                    string branchname = ChartBranchCmbBx.Text;
                    Branch branch = db.Branch.Where(x => x.Name == branchname && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(worker, branch);
                }
                if (ChartWorkerCmbBx.Text == "" && ChartServiceCmbBx.Text != "" && ChartBranchCmbBx.Text != "")
                {
                    string branchname = ChartBranchCmbBx.Text;
                    Branch branch = db.Branch.Where(x => x.Name == branchname && x.DeleteTime == null).FirstOrDefault();
                    string servicename = ChartServiceCmbBx.Text;
                    Service service = db.Service.Where(x => x.Name == servicename && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(service, branch);
                }
                    if (ChartWorkerCmbBx.Text != "" && ChartServiceCmbBx.Text == "" && ChartBranchCmbBx.Text == "")
                {
                    string[] fio = ChartWorkerCmbBx.Text.Split(' ');
                    string secondname = fio[0];
                    string name = fio[1];
                    string lastname = fio[2];
                    Worker worker = db.Worker.Where(x => x.SecondName == secondname && x.Name == name && x.LastName == lastname && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(worker);
                }
                if (ChartWorkerCmbBx.Text == "" && ChartServiceCmbBx.Text != "" && ChartBranchCmbBx.Text == "")
                {
                    string servicename = ChartServiceCmbBx.Text;
                    Service service = db.Service.Where(x => x.Name == servicename && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(service);
                }
                if (ChartWorkerCmbBx.Text == "" && ChartServiceCmbBx.Text == "" && ChartBranchCmbBx.Text != "")
                {
                    string branchname = ChartBranchCmbBx.Text;
                    Branch branch = db.Branch.Where(x => x.Name == branchname && x.DeleteTime == null).FirstOrDefault();
                    BuildChart(branch);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                int branchid;
                int materialid;
                double countperpiece = -1;
                double countfortheamount = -1;   
                List<Session> sessionlist = db.Session.Where(x => x.DeleteTime == null && x.ReduceMaterial == false).ToList();
                foreach (Session session in sessionlist)
                {
                    branchid = Convert.ToInt16(session.BranchID);
                    List<SessionServices>sessionserviceslist = db.SessionServices.Where(x => x.SessionID == session.Id).ToList();
                    foreach (SessionServices sessionservices in sessionserviceslist)
                    {
                        List<ServiceMaterials> servicematerialslist = db.ServiceMaterials.Where(s => s.ServiceID == sessionservices.ServiceID).ToList();
                        foreach (ServiceMaterials servicematerials in servicematerialslist)
                        {
                            materialid = Convert.ToInt16(servicematerials.MaterialID);
                            if (db.Material.Find(materialid).CostPerPiece == null)
                            {
                                countperpiece = -1;
                                countfortheamount = Convert.ToDouble(servicematerials.CountForTheAmount);
                            }
                            if (db.Material.Find(materialid).TheCostForTheAmount == null)
                            {
                                countfortheamount = -1;
                                countperpiece = Convert.ToDouble(servicematerials.CountPerPiece);
                            }
                            BranchMaterials bm = new BranchMaterials();
                            bm.BranchID = branchid;
                            bm.MaterialID = materialid;
                            if (countperpiece == -1)
                            {
                                bm.CountPerPiece = null;
                                bm.CountForTheAmount = countfortheamount;
                            }
                            if (countfortheamount == -1)
                            {
                                bm.CountPerPiece = countperpiece;
                                bm.CountForTheAmount = null;
                            }
                            bm.Date = DateTime.Now;
                            bm.AddOrDelete = false;
                            db.BranchMaterials.Add(bm);
                        }
                    }
                    session.ReduceMaterial = true;
                }
                db.SaveChanges();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ExpensesByServices exp = new ExpensesByServices();
            exp.ShowDialog();
        }
        private void DateStartSessionDtTm_ValueChanged(object sender, EventArgs e)
        {
            timestartforsearch = DateStartSessionDtTm.Value;
        }
        private void DateEndSessionDtTm_ValueChanged(object sender, EventArgs e)
        {
            timeendforsearch = DateEndSessionDtTm.Value;
        }
        private void SearchSessionBtn_Click(object sender, EventArgs e)
        {
            SessionsDataGridView.Rows.Clear();
            string secondname = "";
            string name = "";
            string lastname = "";
            string countworker = "";
            if (ClientSecondNameTxtBx.Text != "") secondname = Char.ToUpper(ClientSecondNameTxtBx.Text[0]) + ClientSecondNameTxtBx.Text.Substring(1);
            if (ClientNameTxtBx.Text != "") name = Char.ToUpper(ClientNameTxtBx.Text[0]) + ClientNameTxtBx.Text.Substring(1);
            if (ClientLastNameTxtBx.Text != "") lastname = Char.ToUpper(ClientLastNameTxtBx.Text[0]) + ClientLastNameTxtBx.Text.Substring(1);
            if (CountWorkersTxtBx.Text != "") countworker = CountWorkersTxtBx.Text;//+"AND Session.TimeStart>='' AND Session.TimeEnd<='' AND Session.Date>='' AND Session.Date<=''";
            string dtstart = Convert.ToString(timestartforsearch);
            string[] datewithtime = dtstart.Split(' ');
            string[] date = datewithtime[0].Split('.');
            string result = date[2] + '-' + date[1] + '-' + date[0];//2018-12-05
            string dtend = Convert.ToString(timeendforsearch);
            string[] datewithtime1 = dtend.Split(' ');
            string[] date1 = datewithtime1[0].Split('.');
            string result1 = date1[2] + '-' + date1[1] + '-' + date1[0];//2018-12-05
            if (result != "1999-10-11" || result1 != "1999-10-11")
            {               
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    string dtstart1 = Convert.ToString(DateStartSessionDtTm.Value.AddDays(-1));
                    string[] datewithtime2 = dtstart1.Split(' ');
                    string[] date2 = datewithtime2[0].Split('.');
                    string resultstart = date2[2] + '-' + date2[1] + '-' + date2[0];//2018-12-05
                    string dtend1 = Convert.ToString(DateEndSessionDtTm.Value.AddDays(1));
                    string[] datewithtime3 = dtend1.Split(' ');
                    string[] date3 = datewithtime3[0].Split('.');
                    string resultend = date3[2] + '-' + date3[1] + '-' + date3[0];//2018-12-05
                    string commandText = @"SELECT Session.Id as ID,Client.Name as Client, Session.CountWorker as CountWorker, Branch.Name as Branch,Session.Date as Date, Session.TimeStart as Timestart,Session.TimeEnd as TimeEnd, Session.Price as Prise FROM [Session] 
                    inner join [Client] on session.ClientID=Client.Id
                    inner join [Branch] on Session.BranchID=Branch.Id
                    WHERE Session.Date BETWEEN '" + resultstart + "' AND '" + resultend + "' AND Client.Name LIKE '%" + name + "%' AND Client.LastName LIKE '%" + lastname + "%' AND Client.SecondName LIKE '%" + secondname + "%' AND Branch.Name LIKE '%" + BranchCmbBx.Text + "%' AND Session.CountWorker LIKE '%" + CountWorkersTxtBx.Text + "%' AND Session.DeleteTime is null";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[8]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        SessionsDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
            else
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    string commandText = @"SELECT Session.Id as ID,Client.Name as Client, Session.CountWorker as CountWorker, Branch.Name as Branch,Session.Date as Date, Session.TimeStart as Timestart,Session.TimeEnd as TimeEnd, Session.Price as Prise FROM [Session] 
                inner join [Client] on session.ClientID=Client.Id
                inner join [Branch] on Session.BranchID=Branch.Id
                WHERE Client.Name LIKE '%" + name + "%' AND Client.LastName LIKE '%" + lastname + "%' AND Client.SecondName LIKE '%" + secondname + "%' AND Branch.Name LIKE '%" + BranchCmbBx.Text + "%' AND Session.CountWorker LIKE '%" + CountWorkersTxtBx.Text + "%' AND Session.DeleteTime is null";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[8]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                        data[data.Count - 1][6] = reader[6].ToString();
                        data[data.Count - 1][7] = reader[7].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        SessionsDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
        }

        private void SearchServiceBtn_Click(object sender, EventArgs e)
        {
            ServicesDataGridView.Rows.Clear();
            string str = "";
            string minprice = "";
            string maxprice = "";
            string mintimeinmin = "";
            string maxtimeinmin = "";
            string countworker = "";
            if (PriceServiceMinTxtBx.Text != "") minprice = PriceServiceMinTxtBx.Text;            
            if (PriceServiceMaxTxtBx.Text != "") maxprice = PriceServiceMaxTxtBx.Text;            
            if (WorkersCountTxtBx.Text != "") countworker = WorkersCountTxtBx.Text;
            if (ServiceNameTxtBx.Text != "") str = Char.ToUpper(ServiceNameTxtBx.Text[0]) + ServiceNameTxtBx.Text.Substring(1);
            if (MinTimeInMinTxtBx.Text != "") mintimeinmin = MinTimeInMinTxtBx.Text;
            if (MaxTimeInMinTxtBx.Text != "") maxtimeinmin = MaxTimeInMinTxtBx.Text;
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                if ((PriceServiceMinTxtBx.Text == "") && (PriceServiceMaxTxtBx.Text == "") && (MinTimeInMinTxtBx.Text == "") && (MaxTimeInMinTxtBx.Text == ""))
                {
                    string commandText = @"SELECT Service.Id as IDD, Service.CountWorker as CountWorker, Service.Time as Time, Service.Name as Service, Service.Price as Price FROM Service  
                    WHERE Service.Name LIKE '%"+str+"%' AND Service.CountWorker like '%"+countworker+"%'";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        ServicesDataGridView.Rows.Add(s);
                    Connect.Close();
                }
                if ((PriceServiceMinTxtBx.Text == "") && (PriceServiceMaxTxtBx.Text == "") && (MinTimeInMinTxtBx.Text != "") && (MaxTimeInMinTxtBx.Text != ""))
                {
                    string commandText = @"SELECT Service.Id as IDD, Service.CountWorker as CountWorker, Service.Time as Time, Service.Name as Service, Service.Price as Price FROM Service 
                    WHERE Service.Name LIKE '%"+str+"%' AND Service.CountWorker like '%"+countworker+"%' AND Service.Time >= "+mintimeinmin+ " AND Service.Time <= " + maxtimeinmin + "";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        ServicesDataGridView.Rows.Add(s);
                    Connect.Close();
                }
                if ((PriceServiceMinTxtBx.Text != "") && (PriceServiceMaxTxtBx.Text != "") && (MinTimeInMinTxtBx.Text == "") && (MaxTimeInMinTxtBx.Text == ""))
                {
                    string commandText = @"SELECT Service.Id as IDD, Service.CountWorker as CountWorker, Service.Time as Time, Service.Name as Service, Service.Price as Price FROM Service 
                    WHERE Service.Name LIKE '%" + str + "%' AND Service.CountWorker like '%" + countworker + "%' AND Service.Price >= "+minprice+ " AND Service.Price <= " + maxprice + "";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        ServicesDataGridView.Rows.Add(s);
                    Connect.Close();
                }
                if ((PriceServiceMinTxtBx.Text != "") && (PriceServiceMaxTxtBx.Text != "") && (MinTimeInMinTxtBx.Text != "") && (MaxTimeInMinTxtBx.Text != ""))
                {
                    string commandText = @"SELECT Service.Id as IDD, Service.CountWorker as CountWorker, Service.Time as Time, Service.Name as Service, Service.Price as Price FROM Service  
                    WHERE Service.Name LIKE '%" + str + "%' AND Service.CountWorker LIKE '%" + countworker + "%' AND Service.Price >= " + minprice + " AND Service.Price <= " + maxprice + " AND Service.Time >= " + mintimeinmin + " AND Service.Time <= " + maxtimeinmin + "";  //+"AND Session.TimeStart>='' AND Session.TimeEnd<='' AND Session.Date>='' AND Session.Date<=''";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[5]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        ServicesDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
        }

        private void SearchMaterialBtn_Click(object sender, EventArgs e)
        {
            MaterialsDataGridView.Rows.Clear();
            string name = "";
            string supplier = "";
            string description = "";
            int minpriceperpiece = -1;
            int maxpriceperpiece = -1;
            int minpriceamount = -1;
            int maxpriceamount = -1;
            if (MaterialPriceMinTxtBx.Text != "") minpriceperpiece = Convert.ToInt16(MaterialPriceMinTxtBx.Text);
            if (MaterialPriceMaxTxtBx.Text != "") maxpriceperpiece = Convert.ToInt16(MaterialPriceMaxTxtBx.Text);
            if (MaterialPriceMinGrTxtBx.Text != "") minpriceamount = Convert.ToInt16(MaterialPriceMinGrTxtBx.Text);
            if (MaterialPriceMaxGrTxtBx.Text != "") maxpriceamount = Convert.ToInt16(MaterialPriceMaxGrTxtBx.Text);
            if (DescriptionTxtBx.Text != "") description = Char.ToUpper(DescriptionTxtBx.Text[0]) + DescriptionTxtBx.Text.Substring(1);
            if (SupplierTxtBx.Text != "") supplier = Char.ToUpper(SupplierTxtBx.Text[0]) + SupplierTxtBx.Text.Substring(1);
            if (MaterialNameTxtBx.Text != "") name = Char.ToUpper(MaterialNameTxtBx.Text[0]) + MaterialNameTxtBx.Text.Substring(1);
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                if ((MaterialPriceMinTxtBx.Text == "") && (MaterialPriceMaxTxtBx.Text == "") && (MaterialPriceMinGrTxtBx.Text == "") && (MaterialPriceMaxGrTxtBx.Text == ""))
                {
                    string commandText = @"SELECT Material.Id as ID,Material.Name as Material,Material.TheCostForTheAmount as Amount, Material.CostPerPiece as Piece,Material.Description as Desc, Material.NameOfSupplier as Supplier FROM Material 
                    WHERE Material.Name LIKE '%" + name + "%' AND Material.Description LIKE '%" + description + "%' AND Material.NameOfSupplier LIKE '%" + supplier + "%'";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        MaterialsDataGridView.Rows.Add(s);
                    Connect.Close();
                }

                if ((MaterialPriceMinTxtBx.Text == "") && (MaterialPriceMaxTxtBx.Text == "") && (MaterialPriceMinGrTxtBx.Text != "") && (MaterialPriceMaxGrTxtBx.Text != ""))
                {
                    string commandText = @"SELECT Material.Id as ID,Material.Name as Material,Material.TheCostForTheAmount as Amount, Material.CostPerPiece as Piece,Material.Description as Desc, Material.NameOfSupplier as Supplier FROM Material 
                    WHERE Material.Name LIKE '%" + name + "%' AND Material.Description LIKE '%" + description + "%' AND Material.NameOfSupplier LIKE '%" + supplier + "%' and Material.TheCostForTheAmount>="+minpriceamount+ " AND Material.TheCostForTheAmount<=" + maxpriceamount + "";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        MaterialsDataGridView.Rows.Add(s);
                    Connect.Close();
                }
                if ((MaterialPriceMinTxtBx.Text != "") && (MaterialPriceMaxTxtBx.Text != "") && (MaterialPriceMinGrTxtBx.Text == "") && (MaterialPriceMaxGrTxtBx.Text == ""))
                {
                    string commandText = @"SELECT Material.Id as ID,Material.Name as Material,Material.TheCostForTheAmount as Amount, Material.CostPerPiece as Piece,Material.Description as Desc, Material.NameOfSupplier as Supplier FROM Material 
                    WHERE Material.Name LIKE '%" + name + "%' AND Material.Description LIKE '%" + description + "%' AND Material.NameOfSupplier LIKE '%" + supplier + "%' and Material.CostPerPiece>="+minpriceperpiece+" AND Material.CostPerPiece<="+maxpriceperpiece+"";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        MaterialsDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
        }
        private void SearchPayBtn_Click(object sender, EventArgs e)
        {
            PaysDataGridView.Rows.Clear();
            string clientname = "";
            string clientsname = "";
            string clientlname = "";
            string workername = "";
            string workersname = "";
            string workerlname = "";
            double pricemin = 0;
            double pricemax = 0;
            string dateoppay = Convert.ToString(datepaysearch);
            string[] datewithtime = dateoppay.Split(' ');
            string[] date = datewithtime[0].Split('.');
            string res = date[2] + '-' + date[1] + '-' + date[0];//2018-12-05
           // string res
            if (PayWorkerNameTxtBx.Text != "") workername = Char.ToUpper(PayWorkerNameTxtBx.Text[0]) + PayWorkerNameTxtBx.Text.Substring(1);
            if (PayWorkerSNTxtBx.Text != "") workersname = Char.ToUpper(PayWorkerSNTxtBx.Text[0]) + PayWorkerSNTxtBx.Text.Substring(1);
            if (PayWorkerLNTxtBx.Text != "") workerlname = Char.ToUpper(PayWorkerLNTxtBx.Text[0]) + PayWorkerLNTxtBx.Text.Substring(1);
            if (PayClientNameTxtBx.Text != "") clientname = Char.ToUpper(PayClientNameTxtBx.Text[0]) + PayClientNameTxtBx.Text.Substring(1);
            if (PayClientSNTxtBx.Text != "") clientsname = Char.ToUpper(PayClientSNTxtBx.Text[0]) + PayClientSNTxtBx.Text.Substring(1);
            if (PayClientLNTxtBx.Text != "") clientlname = Char.ToUpper(PayClientLNTxtBx.Text[0]) + PayClientLNTxtBx.Text.Substring(1);
            if (PayPriceMaxTxtBx.Text != "") pricemax = Convert.ToDouble(PayPriceMaxTxtBx.Text);
            if (PayPriceMinTxtBx.Text != "") pricemin = Convert.ToDouble(PayPriceMinTxtBx.Text);


            if ((PayPriceMaxTxtBx.Text == "") && (PayPriceMinTxtBx.Text == "") && (res != "1999-10-11"))
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    DateTime nextday = Convert.ToDateTime(res).AddDays(1);
                    string nextdy = Convert.ToString(nextday);
                    string[] next = nextdy.Split(' ');
                    string[] nextdate = next[0].Split('.');
                    string nextres = nextdate[2] + '-' + nextdate[1] + '-' + nextdate[0];//2018-12-05
                    string commandText = @"SELECT Pay.Id as ID, Client.Name as Client, Pay.Date as Date, Pay.Price as Price, Pay.SessionID as Session,Worker.Name as Worker FROM Pay 
                    Inner Join Worker on Pay.WorkerID = Worker.Id
                    Inner Join Client on Pay.ClientID = Client.Id
                    WHERE Worker.Name LIKE '%" + workername + "%' AND Pay.Date>= '" + res + "' AND Pay.Date < '" + nextres + "' AND Worker.SecondName LIKE '%" + workersname + "%' AND Worker.LastName LIKE '%" + workerlname + "%' AND Client.Name LIKE '%" + clientname + "%' AND Client.SecondName LIKE '%" + clientsname + "%' AND Client.LastName LIKE '%" + clientlname + "%'";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        PaysDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
            if ((PayPriceMaxTxtBx.Text == "") && (PayPriceMinTxtBx.Text == "") && (res == "1999-10-11"))
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    string commandText = @"SELECT Pay.Id as ID, Client.Name as Client, Pay.Date as Date, Pay.Price as Price, Pay.SessionID as Session,Worker.Name as Worker FROM Pay 
                    Inner Join Worker on Pay.WorkerID = Worker.Id
                    Inner Join Client on Pay.ClientID = Client.Id
                    WHERE Worker.Name LIKE '%" + workername + "%' AND Worker.SecondName LIKE '%" + workersname + "%' AND Worker.LastName LIKE '%" + workerlname + "%' AND Client.Name LIKE '%" + clientname + "%' AND Client.SecondName LIKE '%" + clientsname + "%' AND Client.LastName LIKE '%" + clientlname + "%'";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        PaysDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
            if ((PayPriceMaxTxtBx.Text != "") && (PayPriceMinTxtBx.Text != "") && (res == "1999-10-11"))
            {
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    string commandText = @"SELECT Pay.Id as ID, Client.Name as Client, Pay.Date as Date, Pay.Price as Price, Pay.SessionID as Session,Worker.Name as Worker FROM Pay 
                    Inner Join Worker on Pay.WorkerID = Worker.Id
                    Inner Join Client on Pay.ClientID = Client.Id
                    WHERE Worker.Name LIKE '%" + workername + "%' AND Worker.SecondName LIKE '%" + workersname + "%' AND Worker.LastName LIKE '%" + workerlname + "%' AND Client.Name LIKE '%" + clientname + "%' AND Client.SecondName LIKE '%" + clientsname + "%' AND Client.LastName LIKE '%" + clientlname + "%' AND Pay.Price >= " + pricemin + " AND Pay.Price <= " + pricemax + "";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        PaysDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
            if (((PayPriceMaxTxtBx.Text != "") && (PayPriceMinTxtBx.Text == ""))||((PayPriceMaxTxtBx.Text == "") && (PayPriceMinTxtBx.Text != "")))
            {
                MessageBox.Show("Введите весь диапазон цен.", "Тату салон");
                FillGridPays(currentpage, currentcountonpage);
            }
            if ((res != "1999-10-11") && (PayPriceMaxTxtBx.Text != "") && (PayPriceMinTxtBx.Text != ""))
            {
                DateTime nextday = Convert.ToDateTime(res).AddDays(1);
                string nextdy = Convert.ToString(nextday);
                string[] next = nextdy.Split(' ');
                string[] nextdate = next[0].Split('.');
                string nextres = nextdate[2] + '-' + nextdate[1] + '-' + nextdate[0];//2018-12-05
                using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
                {
                    string commandText = @"SELECT Pay.Id as ID, Client.Name as Client, Pay.Date as Date, Pay.Price as Price, Pay.SessionID as Session,Worker.Name as Worker FROM Pay 
                    Inner Join Worker on Pay.WorkerID = Worker.Id
                    Inner Join Client on Pay.ClientID = Client.Id
                    WHERE Worker.Name LIKE '%" + workername + "%' AND Pay.Date>= '"+res+"' AND Pay.Date < '"+nextres+"' AND Worker.SecondName LIKE '%" + workersname + "%' AND Worker.LastName LIKE '%" + workerlname + "%' AND Client.Name LIKE '%" + clientname + "%' AND Client.SecondName LIKE '%" + clientsname + "%' AND Client.LastName LIKE '%" + clientlname + "%' AND Pay.Price >= " + pricemin + " AND Pay.Price <= " + pricemax + "";
                    SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                    Connect.Open();
                    DataSet dataSet = new DataSet();
                    DataTable table = dataSet.Tables.Add("Table");
                    IDataReader reader = Command.ExecuteReader();
                    List<string[]> data = new List<string[]>();
                    while (reader.Read())
                    {
                        data.Add(new string[6]);
                        data[data.Count - 1][0] = reader[0].ToString();
                        data[data.Count - 1][1] = reader[1].ToString();
                        data[data.Count - 1][2] = reader[2].ToString();
                        data[data.Count - 1][3] = reader[3].ToString();
                        data[data.Count - 1][4] = reader[4].ToString();
                        data[data.Count - 1][5] = reader[5].ToString();
                    }
                    reader.Close();
                    foreach (string[] s in data)
                        PaysDataGridView.Rows.Add(s);
                    Connect.Close();
                }
            }
        }
        private void SearchCabinetBtn_Click(object sender, EventArgs e)
        {
            CabinetsDataGridView.Rows.Clear();
            string name = "";
            string descr = "";
            string br = "";
            if (CabinetNameTxtBx.Text != "") name = Char.ToUpper(CabinetNameTxtBx.Text[0]) + CabinetNameTxtBx.Text.Substring(1);
            if (CabinetDescrTxtBx.Text != "") descr = Char.ToUpper(CabinetDescrTxtBx.Text[0]) + CabinetDescrTxtBx.Text.Substring(1);
            if (CabinetBranchCmbBx.Text != "") br = Char.ToUpper(CabinetBranchCmbBx.Text[0]) + CabinetBranchCmbBx.Text.Substring(1);
            using (SQLiteConnection Connect = new SQLiteConnection(@"Data Source=C:\Users\Лиза\Documents\Visual Studio 2015\Projects\НОВАЯ ВЕРСИЯ\Interface_TS\Client.db; Version=3;")) // в строке указывается к какой базе подключаемся
            {
                string commandText = @"SELECT Cabinet.Id as ID, Branch.Name as Branch,Cabinet.Description as Description, Cabinet.Name as Cabinet FROM Cabinet 
                Inner join Branch on Cabinet.BranchID=Branch.Id 
                WHERE Cabinet.Name LIKE '%"+name+"%' AND Cabinet.Description LIKE '%"+descr+"%' AND Branch.Name LIKE '%"+ CabinetBranchCmbBx.Text + "%'";
                SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
                Connect.Open();
                DataSet dataSet = new DataSet();
                DataTable table = dataSet.Tables.Add("Table");
                IDataReader reader = Command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[4]);
                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                }
                reader.Close();
                foreach (string[] s in data)
                    CabinetsDataGridView.Rows.Add(s);
                Connect.Close();
            }
        }

        private void WorkerHoursSearch_Click(object sender, EventArgs e)
        {
            if (SearchWorkerWorkinHoursCmbBx.Text != "")
            {
                using (ClientEntities db = new ClientEntities())
                {
                    string[] FIO = SearchWorkerWorkinHoursCmbBx.Text.Split(' ');
                    string SN = FIO[0];
                    string name = FIO[1];
                    string LN = FIO[2];
                    dataGridView9.Rows.Clear();
                    Worker temp = db.Worker.Where(x => x.SecondName == SN && x.Name == name && x.LastName == LN).FirstOrDefault();
                    var groupbyworkerid = from w in db.WorkingHour.Where(x => x.WorkerID==temp.Id && x.DeleteTime==null)
                                      group w by w.WorkerID;
                    foreach (var g in groupbyworkerid)
                    {
                        dataGridView9.Rows.Add(db.Worker.Find(g.Key).SecondName+' '+db.Worker.Find(g.Key).Name+' '+ db.Worker.Find(g.Key).LastName);
                        foreach (var wc in g)
                        {
                            DateTime s = Convert.ToDateTime(wc.TimeStart);
                            DateTime er = Convert.ToDateTime(wc.TimeEnd);
                            dataGridView9.Rows.Add(wc.Id, db.Branch.Find(wc.BranchID).Name, Convert.ToString(s.ToShortDateString()), Convert.ToString(s.ToShortTimeString()), Convert.ToString(er.ToShortTimeString()), (db.Worker.Find(wc.WorkerID).SecondName) + ' ' + (db.Worker.Find(wc.WorkerID).Name) + ' ' + (db.Worker.Find(wc.WorkerID).LastName));
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button11.Enabled = false;
            }
            FillGridSessions(currentpage, currentcountonpage);
            label8.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button11.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button10.Enabled = false;
            }
            FillGridSessions(currentpage, currentcountonpage);
            label8.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button1.Enabled = false;
            }
            FillGridClients(currentpage, currentcountonpage);
            label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button3.Enabled = false;
            }
            FillGridClients(currentpage, currentcountonpage);
            label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button4.Enabled = false;
            }
            FillGridPays(currentpage, currentcountonpage);
            label44.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button6.Enabled = false;
            }
            FillGridPays(currentpage, currentcountonpage);
            label44.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button14.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button13.Enabled = false;
            }
            FillGridCabinets(currentpage, currentcountonpage);
            label63.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button13.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button14.Enabled = false;
            }
            FillGridCabinets(currentpage, currentcountonpage);
            label63.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button17.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button16.Enabled = false;
            }
            FillGridServices(currentpage, currentcountonpage);
            label21.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button16.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button17.Enabled = false;
            }
            FillGridServices(currentpage, currentcountonpage);
            label21.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button20.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button19.Enabled = false;
            }
            FillGridBranches(currentpage, currentcountonpage);
            label22.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button19.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button20.Enabled = false;
            }
            FillGridBranches(currentpage, currentcountonpage);
            label22.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button7.Enabled = false;
            }
            FillGridWorkers(currentpage, currentcountonpage);
            label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button7.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button8.Enabled = false;
            }
            FillGridWorkers(currentpage, currentcountonpage);
            label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button30.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button29.Enabled = false;
            }
            FillGridMaterials(currentpage, currentcountonpage);
            label30.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button29.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button30.Enabled = false;
            }
            FillGridMaterials(currentpage, currentcountonpage);
            label30.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button37.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button36.Enabled = false;
            }
            FillGridWorkingHours(currentpage, currentcountonpage);
            label46.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button36.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button37.Enabled = false;
            }
            FillGridWorkingHours(currentpage, currentcountonpage);
            label46.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }
        private void FillGridWithWorkingHoursForWorker(int workid)
        {
            using (ClientEntities db = new ClientEntities())
            {
                dataGridView9.Rows.Clear();
                var temp = db.WorkingHour.Where(x => x.DeleteTime == null && x.WorkerID == workid);
                List<WorkingHour> workinghourslist = temp.ToList();
                foreach (WorkingHour w in workinghourslist)
                {
                    DateTime s = Convert.ToDateTime(w.TimeStart);
                    DateTime e = Convert.ToDateTime(w.TimeEnd);
                    dataGridView9.Rows.Add(w.Id, db.Branch.Find(w.BranchID).Name, Convert.ToString(s), Convert.ToString(e.TimeOfDay), db.Worker.Find(w.WorkerID).Name);
                }
            }
        }

        private void ResetTheFilters_Click(object sender, EventArgs e)
        {
            FillGridSessions(currentpage, currentcountonpage);
        }

        private void ReserTheFiltersClientsBtn_Click(object sender, EventArgs e)
        {
            FillGridClients(currentpage, currentcountonpage);

        }

        private void ResetTheFiltersCabinetsBtn_Click(object sender, EventArgs e)
        {
            FillGridCabinets(currentpage, currentcountonpage);
        }

        private void ResetTheFiltersServicesBtn_Click(object sender, EventArgs e)
        {
            FillGridServices(currentpage, currentcountonpage);
        }
        private void ResetTheFiltersBranchesBtn_Click(object sender, EventArgs e)
        {
            FillGridBranches(currentpage, currentcountonpage);
        }

        private void ResetTheFiltersWorkersBtn_Click(object sender, EventArgs e)
        {
            FillGridWorkers(currentpage, currentcountonpage);
        }

        private void ResetTheFiltersMaterialsBtn_Click(object sender, EventArgs e)
        {
            FillGridMaterials(currentpage, currentcountonpage);
        }

        private void ResetTheFiltersWorkingHoursBtn_Click(object sender, EventArgs e)
        {
            FillGridWorkingHours(currentpage, currentcountonpage);
        }

        private void SearchClientNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PayPriceMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PayPriceMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MaxTimeInMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MinTimeInMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PriceServiceMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void PriceServiceMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void WorkersCountTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SearchBranchCabinetsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SearchBranchNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void SearchWorkerNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ExperienceTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MaterialPriceMinGrTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MaterialPriceMaxGrTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MaterialPriceMinTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MaterialPriceMaxTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void ResetTheFiltersChartBtn_Click(object sender, EventArgs e)
        {
            label43.Visible = false;
            ProceedsTxtBx.Visible = false;
            chart1.Series[0].Points.Clear();
            ChartServiceCmbBx.SelectedIndex = -1;
            ChartWorkerCmbBx.SelectedIndex = -1;
            ChartBranchCmbBx.SelectedIndex = -1;
            ChartServiceCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChartWorkerCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            ChartBranchCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FillGridPays(currentpage, currentcountonpage);
        }

        private void PayDateDtTm_ValueChanged(object sender, EventArgs e)
        {
            datepaysearch = PayDateDtTm.Value;
        }
    }
}

