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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }
        private void logInBtn_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                Worker temp = db.Worker.Where(x => x.Login == textBox1.Text && x.Password == textBox2.Text).FirstOrDefault<Worker>();
                if (temp != null)
                {
                    this.Hide();
                    TattooParlor TP = new TattooParlor();
                    TP.FormStatus = 1;
                    TP.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Тату салон");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь с администратору АСУ.", "Тату салон");
        }
    }
}
