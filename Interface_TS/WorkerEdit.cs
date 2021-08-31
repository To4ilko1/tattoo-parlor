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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private bool CountStr()
        {
            int countrows = ServiceInWorkerListBx.Items.Count;
            if (countrows > 0)
                return true;
            else return false;
        }

        public void FillListBox()
        {
            using (ClientEntities db = new ClientEntities())
            {
                List<ServiceWorkers> servicelist = db.ServiceWorkers.Where(x => x.DeleteTime == null && x.WorkerID == id).ToList();
                foreach (ServiceWorkers sw in servicelist)
                {
                    ServiceInWorkerListBx.Items.Add(db.Service.Find(sw.ServiceID).Name);
                }
            }
        }
        public void FillListBox(int serid)
        {
            using (ClientEntities db = new ClientEntities())
            {
                int count = ServiceInWorkerListBx.Items.Count;
                List<int> check = new List<int>();
                for (int i = 0; i < count; i++)
                {
                    string pr = Convert.ToString(ServiceInWorkerListBx.Items[i]);
                    Service temp = db.Service.Where(x => x.Name == pr && x.DeleteTime==null).FirstOrDefault<Service>();
                    check.Add(Convert.ToInt16(temp.Id));
                }
                if (!check.Equals(serid))
                {
                    Service ser = db.Service.Find(serid);
                    ServiceInWorkerListBx.Items.Add(ser.Name);//ПРИ ЗАКРЫТИЯ СПИСКА УСЛУГ И НЕ ВЫБРАННОЙ НИ ОДНОЙ УСЛУГИ ОШИБКА!!!
                }
            }
        }
        private void SaveWorkerBtn_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    if (db.Worker.Find(id) == null)
                    {
                        Worker w = new Worker();
                        w.Id = id;
                        string[] fio;
                        fio = textBox1.Text.Split(' ');
                        w.Name = fio[1];
                        w.SecondName = fio[0];
                        w.LastName = fio[2];
                        w.ContactPhoneNumber = textBox2.Text;
                        w.Position = textBox3.Text;
                        w.TattooStyle = textBox4.Text;
                        w.BranchID = comboBox1.SelectedIndex + 1;
                        w.Experience = Convert.ToInt32(numericUpDown1.Value);
                        w.Comment = textBox6.Text;
                        int countitems = ServiceInWorkerListBx.Items.Count;
                        for (int i = 0; i < countitems; i++)
                        {
                            string servicename = Convert.ToString(ServiceInWorkerListBx.Items[i]);
                            Service srvc = db.Service.Where(x => x.DeleteTime==null && x.Name == servicename).FirstOrDefault<Service>();
                            ServiceWorkers sw = new ServiceWorkers();
                            sw.ServiceID = srvc.Id;
                            sw.WorkerID = id;
                            db.ServiceWorkers.Add(sw);
                            db.SaveChanges();
                        }
                        db.Worker.Add(w);
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        string[] fio = this.textBox1.Text.Split(' ');
                        Worker temp = db.Worker.Where(x => x.Id == id && x.DeleteTime==null).FirstOrDefault<Worker>();
                        temp.Name = fio[1];
                        temp.SecondName = fio[0];
                        temp.LastName = fio[2];
                        temp.ContactPhoneNumber = textBox2.Text;
                        temp.Position = textBox3.Text;
                        temp.TattooStyle = textBox4.Text;
                        temp.Experience = Convert.ToInt32(numericUpDown1.Value);
                        temp.BranchID = comboBox1.SelectedIndex + 1;
                        temp.Comment = textBox6.Text;
                        int countitems = ServiceInWorkerListBx.Items.Count;
                        for (int i = 0; i < countitems; i++)
                        {
                            string servicename = ServiceInWorkerListBx.Items[i].ToString();
                            Service ser = db.Service.Where(x => x.Name == servicename).FirstOrDefault<Service>();
                            if (!db.ServiceWorkers.Any(x => x.WorkerID.Equals(id) && x.ServiceID.Equals(ser.Id)))
                            {
                                ServiceWorkers sm = new ServiceWorkers();
                                sm.ServiceID = ser.Id;
                                sm.WorkerID = id;
                                db.ServiceWorkers.Add(sm);
                                db.SaveChanges();
                            }
                            else
                            {
                                ServiceWorkers sw = db.ServiceWorkers.Where(x => x.WorkerID == id && x.ServiceID == ser.Id).FirstOrDefault<ServiceWorkers>();
                                sw.DeleteTime = null;
                            }
                        }
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
        private void FillBranchCmbBx()
        {
            comboBox1.Items.Clear();
            using (ClientEntities db = new ClientEntities())
            {
                List<Branch> temp = new List<Branch>();
                temp = db.Branch.ToList();
                foreach (Branch b in temp)
                {
                    comboBox1.Items.Add(b.Name);
                }
                comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                comboBox1.SelectedIndex = 0;

            }
        }
        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Cabinet.Find(id) != null)
                {
                    Worker temp1 = db.Worker.Where(x => x.Id == id).FirstOrDefault<Worker>();
                    textBox1.Text = temp1.SecondName+' '+temp1.Name+' '+temp1.LastName;
                    textBox2.Text = temp1.ContactPhoneNumber;
                    textBox3.Text = temp1.Position;
                    textBox4.Text = temp1.TattooStyle;
                    numericUpDown1.Value = Convert.ToInt32(temp1.Experience);
                    FillBranchCmbBx();
                    comboBox1.SelectedIndex = Convert.ToInt32(temp1.BranchID)-1;
                    textBox6.Text = temp1.Comment;
                    FillListBox();
                }
                else
                {
                    Worker w = new Worker();
                    w.Id = db.Worker.Count() + 1;
                    Currentid = Convert.ToInt16(w.Id);
                    FillBranchCmbBx();
                    comboBox1.SelectedIndex = 0;
                }
            }
        }

        private void AddServiceToWorker_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                TattooParlor TP = new TattooParlor();
                TP.Text = "Добавить услугу";
                TP.BackId = id;
                TP.FormStatus = 5;
                TP.ShowDialog();
                int SerID = TP.ServiceId;
                if (SerID != 0)
                    FillListBox(SerID);
                else
                    FillListBox();
            }
        }
        private void DeleteServiceToWorker_Click(object sender, EventArgs e)
        {
            try
            {
                string servicename = this.ServiceInWorkerListBx.SelectedItem.ToString();
                using (ClientEntities db = new ClientEntities())
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить услугу?", "Тату салон", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Service ser = db.Service.Where(x => x.Name == servicename).FirstOrDefault<Service>();
                        ServiceWorkers sw = db.ServiceWorkers.Where(x => x.WorkerID == id && x.ServiceID == ser.Id).FirstOrDefault<ServiceWorkers>();//and deletetime!=0?
                        sw.DeleteTime = DateTime.Now;
                        db.SaveChanges();
                        FillListBox();
                    }         
                }
            }
            catch
            {
                bool b = CountStr();
                if (!b)
                    MessageBox.Show("У работника нет услуг, которые можно удалить.", "Тату салон");
                else MessageBox.Show("Нажмите на услугу, которую хотите удалить.", "Тату салон");
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            int count = ServiceInWorkerListBx.Items.Count;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "ФИО \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Телефон \n"; v = false; }
            if (textBox3.Text == "") { error.SetError(textBox3, "Заполните поле!"); message += "Должность \n"; v = false; }
            if (textBox4.Text == "") { error.SetError(textBox4, "Заполните поле!"); message += "Стиль тату \n"; v = false; }
            if (comboBox1.Text == "") { error.SetError(comboBox1, "Заполните поле!"); message += "Филиал \n"; v = false; }
            if (count == 0) { error.SetError(ServiceInWorkerListBx, "Заполните поле!"); message += "Услуги \n"; v = false; }
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
