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
    public partial class ClientCard : Form
    {
        public ClientCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private void Refresh1()
        {
            using (ClientEntities db = new ClientEntities())
            {
                Client temp = db.Client.Where(x => x.Id == this.id).FirstOrDefault<Client>();
                FIOLbl.Text = temp.SecondName + ' ' + temp.Name + ' ' + temp.LastName;
                PhoneClientNumberLbl.Text = temp.ContactPhoneNumber;
                CommentTxtBox.Text = temp.Comment;
            }
        }
        private void DeleteClientBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить клиента?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Client w = db.Client.Where(x => x.Id == id).FirstOrDefault<Client>();
                    w.DeleteTime = DateTime.Now;
                    db.SaveChanges();
                    this.Close();
                }
            }
        }
        private void ClientCard_Load(object sender, EventArgs e)
        {
            Refresh1();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ClientEdit c = new ClientEdit();
            c.Currentid = id;
            c.ShowDialog();
            Refresh1();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PayCard c = new PayCard();
            c.Stat = 2;
            c.Clientid = id;
            c.ShowDialog();
        }
    }
}