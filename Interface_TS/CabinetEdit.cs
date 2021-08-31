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
    public partial class CabinetEdit : Form
    {
        public CabinetEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int backid;
        public int BackId////////////////////////////////
        {
            get { return backid; }
            set { backid = value; }
        }
        private bool CountStr()
        {
            int countrows = ServiceInCabinetListBx.Items.Count;
            if (countrows > 0)
                return true;
            else return false;
        }
        public void FillListBox()
        {
            using (ClientEntities db = new ClientEntities())
            {
                ServiceInCabinetListBx.Items.Clear();
                List<CabinetServices> cabinetlist = db.CabinetServices.Where(x => x.DeleteTime == null && x.CabinetID == id).ToList();
                foreach (CabinetServices cp in cabinetlist)
                {
                    ServiceInCabinetListBx.Items.Add(db.Service.Find(cp.ServiceID).Name);
                }
            }
        }
        public void FillListBox(int serid)///////////////////////////////////////////////////////////
        {
            using (ClientEntities db = new ClientEntities())
            {
                int count = ServiceInCabinetListBx.Items.Count;
                List<int> check = new List<int>();
                for (int i =0;i < count;i++)
                {
                   string pr = Convert.ToString(ServiceInCabinetListBx.Items[i]);
                   Service temp = db.Service.Where(x => x.Name == pr &&x.DeleteTime==null).FirstOrDefault<Service>();
                   check.Add(Convert.ToInt16(temp.Id));
                }
                if (!check.Equals(serid))
                {
                    Service ser = db.Service.Find(serid);
                    ServiceInCabinetListBx.Items.Add(ser.Name);
                }
            }
        }
        private void SaveServices()
        {
            using (ClientEntities db = new ClientEntities())
            {
                for (int i = 0; i < ServiceInCabinetListBx.Items.Count; i++)
                {
                    string srvc = ServiceInCabinetListBx.Items[i].ToString();
                    Service s = db.Service.Where(x => x.Name == srvc).FirstOrDefault<Service>();
                    if (!db.CabinetServices.Any(x => x.CabinetID.Equals(id) && x.ServiceID.Equals(s.Id)))
                    {
                        CabinetServices cs = new CabinetServices();
                        cs.ServiceID = s.Id;
                        cs.CabinetID = id;
                        db.CabinetServices.Add(cs);
                    }
                    else
                    {
                        CabinetServices cs = db.CabinetServices.Where(x => x.CabinetID == id && x.ServiceID == s.Id).FirstOrDefault<CabinetServices>();
                        cs.DeleteTime = null;
                    }
                    db.SaveChanges();
                }
            }
        }
        public void Save(int ID_Cabinet, int ID_Branch, string Description, string Name)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Cabinet cabinet = db.Cabinet.Where(c => c.Id == ID_Cabinet).FirstOrDefault<Cabinet>();
                cabinet.BranchID = ID_Branch;
                cabinet.Description = Description;
                cabinet.Name = Name;
                db.SaveChanges();
            }
        }
        public void Add(int ID_Cabinet, int ID_Branch, string Description, string Name)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Cabinet cabinet = new Cabinet()
                {
                    Id = ID_Cabinet,
                    BranchID = ID_Branch,
                    Description = Description,
                    Name = Name,
                };
                db.Cabinet.Add(cabinet);
                db.SaveChanges();
            }
        }
        private void SaveForm()
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    if (db.Cabinet.Find(id) == null)
                    {
                        Branch temp = db.Branch.Where(x => x.Name == comboBox1.Text).FirstOrDefault<Branch>();
                        Add(id, Convert.ToInt16(temp.Id), textBox2.Text, textBox1.Text);
                        SaveServices();
                        this.Close();
                    }
                    else
                    {
                        Branch temp = db.Branch.Where(x => x.Name == comboBox1.Text).FirstOrDefault<Branch>();
                        Save(id, Convert.ToInt16(temp.Id), textBox2.Text, textBox1.Text);
                        SaveServices();
                        this.Close();
                    }
                }
            }
        }
        private void SaveCabinetBtn_Click(object sender, EventArgs e)
        {
            SaveForm();
        }
        private void CabinetEdit_Load(object sender, EventArgs e)
        {
            List<Branch> tem = new List<Branch>();
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Cabinet.Find(id) != null)
                {
                    Cabinet temp = db.Cabinet.Where(x => x.Id == id).FirstOrDefault<Cabinet>();
                    textBox1.Text = temp.Name;
                    textBox2.Text = temp.Description;
                    Branch branch = db.Branch.Find(temp.BranchID);
                    comboBox1.Text = branch.Name;
                    comboBox1.Enabled = false;
                    FillListBox();
                }
                else
                {
                    comboBox1.Items.Clear();
                    Cabinet c = new Cabinet();
                    c.Id = db.Cabinet.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    tem = db.Branch.ToList();
                    comboBox1.Enabled = true;
                    comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;                  
                    foreach (Branch b in tem)
                    {
                        comboBox1.Items.Add(b.Name);
                    }
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            int count = ServiceInCabinetListBx.Items.Count;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "Наименование \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Описание \n"; v = false; }
            if (comboBox1.Text == "") { error.SetError(comboBox1, "Заполните поле!"); message += "Филиал \n"; v = false; }
            if (count == 0) { error.SetError(ServiceInCabinetListBx, "Заполните поле!"); message += "Услуги \n"; v = false; }
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
        private void AddServiceInCabinet_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить услугу";
                TP.BackId = id;
                TP.FormStatus = 2;
                TP.ShowDialog();                
                int SerID = TP.ServiceId;
                if (SerID != 0)
                    FillListBox(SerID);
                else
                    FillListBox();
            }
        }
        private void DeleteCabinetService_Click(object sender, EventArgs e)
        {
            try
            {
                string servicename = this.ServiceInCabinetListBx.SelectedItem.ToString();
                using (ClientEntities db = new ClientEntities())
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить услугу?", "Тату салон", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Service ser = db.Service.Where(x => x.Name == servicename).FirstOrDefault<Service>();
                        CabinetServices cs = db.CabinetServices.Where(x => x.CabinetID == id && x.ServiceID == ser.Id && x.DeleteTime == null).FirstOrDefault<CabinetServices>();//and deletetime!=0?
                        cs.DeleteTime = DateTime.Now;
                        db.SaveChanges();
                        FillListBox();
                    }
                }
            }
            catch
            {
                bool b = CountStr();
                if (!b)
                    MessageBox.Show("У кабинета нет услуг, которые можно удалить.", "Тату салон");
                else MessageBox.Show("Нажмите на услугу, которую хотите удалить.", "Тату салон");
            }
        }
    }
}
