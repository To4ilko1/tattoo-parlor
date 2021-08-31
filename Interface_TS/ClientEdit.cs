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
    public partial class ClientEdit : Form
    {
        public ClientEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        private void ClientEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Client.Find(id) != null)
                {
                    Client temp = db.Client.Where(x => x.Id == id).FirstOrDefault<Client>();
                    textBox1.Text = temp.SecondName+' '+temp.Name+' '+temp.LastName;
                    textBox2.Text = temp.ContactPhoneNumber;
                    textBox3.Text = temp.Comment;
                }
                else
                {
                    Client c = new Client();
                    c.Id = db.Client.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "ФИО \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Телефон \n"; v = false; }
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
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Client.Find(id) == null)
                {
                    Client c = new Client();
                    c.Id = id;
                    string[] fio;
                    fio = textBox1.Text.Split(' ');
                    c.Name = fio[1];
                    c.SecondName = fio[0];
                    c.LastName = fio[2];
                    c.ContactPhoneNumber = textBox2.Text;
                    c.Comment = textBox3.Text;
                    db.Client.Add(c);
                    db.SaveChanges();
                    this.Close();
                }
                else
                {
                    string[] fio;
                    fio = this.textBox1.Text.Split(' ');
                    Client temp = db.Client.Where(x => x.Id == id).FirstOrDefault<Client>();
                    temp.Name = fio[1];
                    temp.SecondName = fio[0];
                    temp.LastName = fio[2];
                    temp.ContactPhoneNumber = textBox2.Text;
                    temp.Comment = textBox3.Text;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
