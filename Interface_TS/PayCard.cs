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
    public partial class PayCard : Form
    {
        public PayCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int clientid;
        public int Clientid
        {
            get { return clientid; }
            set { clientid = value; }
        }
        private int stat;
        public int Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        private void FillDataGridView(Pay pay)
        {
            using (ClientEntities db = new ClientEntities())
            {
                PayGridView.Rows.Clear();
                double sum = 0;
                double price = 0;
                double ostatok = 0;
                int count = 0;
                List<SessionServices> ss = db.SessionServices.Where(x => x.SessionID == pay.SessionID).ToList();
                foreach (SessionServices s in ss)
                {              
                    Service ser = db.Service.Where(x => x.Id == s.ServiceID).FirstOrDefault<Service>();
                    PayGridView.Rows.Add(pay.Id, ser.Id, ser.Name, s.TimeStart, pay.Worker.SecondName + ' ' + pay.Worker.Name + ' ' + pay.Worker.LastName, ser.Price, s.PayState);
                    if (s.PayState == true)
                    {
                        PayGridView.Rows[count].Cells[5].ReadOnly = true;//(Convert.ToBoolean(PayGridView.Rows[count].Cells[5].Value) == true)
                        sum = sum + Convert.ToDouble(ser.Price);                        
                    }
                    count++;
                    price = price + Convert.ToDouble(ser.Price);
                }
                ostatok = price - sum;
                if (ostatok > 0)
                {
                    OstatokDescriptionLbl.Text = "Остаток:";
                    OstatokLbl.Text = Convert.ToString(ostatok);
                }
                else
                {
                    OstatokDescriptionLbl.Text = "Все оплачено.";
                    OstatokLbl.Visible = false;
                }
                PayStateLbl.Text = Convert.ToString(sum);
                PriceLbl.Text = Convert.ToString(price);
                ClientSessionLinkLbl.Text = pay.Client.SecondName + ' ' + pay.Client.Name + ' ' + pay.Client.LastName;
            }
        }
        private double sum1=0;
        private double price1 = 0;
        private double ostatok1 = 0;
        private void FillDataGridView1(Pay pay)
        {

            using (ClientEntities db = new ClientEntities())
            {                
                int count = 0;
                List<SessionServices> ss = db.SessionServices.Where(x => x.SessionID == pay.SessionID).ToList();
                foreach (SessionServices s in ss)
                {
                    Service ser = db.Service.Where(x => x.Id == s.ServiceID).FirstOrDefault<Service>();
                    PayGridView.Rows.Add(pay.Id,ser.Id, ser.Name, s.TimeStart, pay.Worker.SecondName + ' ' + pay.Worker.Name + ' ' + pay.Worker.LastName, ser.Price, s.PayState);
                    if (s.PayState == true)
                    {
                        PayGridView.Rows[count].Cells[6].ReadOnly = true;//(Convert.ToBoolean(PayGridView.Rows[count].Cells[5].Value) == true)
                        sum1 = sum1 + Convert.ToDouble(ser.Price);
                    }
                    count++;
                    price1 = price1 + Convert.ToDouble(ser.Price);
                }
                
                ClientSessionLinkLbl.Text = pay.Client.SecondName + ' ' + pay.Client.Name + ' ' + pay.Client.LastName;
            }

            PayStateLbl.Text = Convert.ToString(sum1);
            PriceLbl.Text = Convert.ToString(price1);
        }
        private void Refresh1(int index)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Pay pay = db.Pay.Where(x => x.Id == id).FirstOrDefault<Pay>();
                FillDataGridView(pay);
                ClientSessionLinkLbl.Text = pay.Client.SecondName + ' ' + pay.Client.Name + ' ' + pay.Client.LastName;
            }
        }
        private void Refresh2(int index)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Client temp = db.Client.Where(x => x.Id == index && x.DeleteTime == null).FirstOrDefault();
                List<Pay> pays = db.Pay.Where(x =>x.ClientID==index).ToList();
                foreach (Pay p in pays)
                {
                    FillDataGridView1(p);
                }
                ostatok1 = price1 - sum1;
                if (ostatok1 > 0)
                {
                    OstatokDescriptionLbl.Text = "Остаток:";
                    OstatokLbl.Text = Convert.ToString(ostatok1);
                }
                else
                {
                    OstatokDescriptionLbl.Text = "Все оплачено.";
                    OstatokLbl.Visible = false;
                }
                ClientSessionLinkLbl.Text = temp.SecondName + ' ' + temp.Name + ' ' +temp.LastName;
            }
        }
        private void EditPayBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                int count = PayGridView.RowCount - 1;
                for (int i=0;i<count;i++)
                {
                    string servicename = Convert.ToString(PayGridView.Rows[i].Cells[0].Value);
                    Service ser = db.Service.Where(x => x.Name == servicename).FirstOrDefault<Service>();
                    int index = Convert.ToInt16(ser.Id);
                    Pay pay = db.Pay.Where(x => x.Id == id).FirstOrDefault<Pay>();
                    SessionServices temp = db.SessionServices.Where(x => x.ServiceID == index && x.SessionID == pay.SessionID).FirstOrDefault<SessionServices>();
                    if (Convert.ToBoolean(PayGridView.Rows[i].Cells[5].Value) == true)
                    {
                        temp.PayState = true;
                    }
                }
                db.SaveChanges();
            }
            Refresh1(id);
        }

        private void DeletePayBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {

                Pay s = db.Pay.Where(x => x.Id == id).FirstOrDefault<Pay>();
                s.DeleteTime = System.DateTime.Now;
                MessageBox.Show("Платеж успешно удален!", "Тату салон");
                db.SaveChanges();
                this.Close();
            }
        }

        private void PayCard_Load(object sender, EventArgs e)
        {
            if(stat!=2)
            Refresh1(this.id);
            else
            {
                Refresh2(clientid);
            }
        }

        private void ClientSessionLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                string[] fio = ClientSessionLinkLbl.Text.Split(' ');
                string secondname = fio[0];
                string name = fio[1];
                string lastname = fio[2];
                Client temp = db.Client.Where(x => x.SecondName==secondname && x.Name == name && x.LastName==lastname).FirstOrDefault<Client>();
                ClientCard CC = new ClientCard();
                CC.Currentid = Convert.ToInt16(temp.Id);
                CC.ShowDialog();
            }
        }

        private void PayGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 2)
            {                  
                int temp = Convert.ToInt32(this.PayGridView.CurrentRow.Cells[0].Value);
                PayCard c = new PayCard();
                c.Stat = 1;
                c.Currentid = temp;
                c.ShowDialog();
            }
        }
    }
}

