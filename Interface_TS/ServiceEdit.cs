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
    public partial class ServiceEdit : Form
    {
        public ServiceEdit()
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
        public int BackId
        {
            get { return backid; }
            set { backid = value; }
        }

        public void FillDataGridView()
        {
            using (ClientEntities db = new ClientEntities())
            {
                ServiceMaterialDataGrid1.Rows.Clear();
                List<ServiceMaterials> sm = db.ServiceMaterials.Where(x => x.ServiceID == id).ToList();
                foreach (ServiceMaterials s in sm)
                {
                    Material mat = db.Material.Where(x => x.Id == s.MaterialID).FirstOrDefault<Material>();
                    ServiceMaterialDataGrid1.Rows.Add(mat.Name, s.CountPerPiece, s.CountForTheAmount);
                }
                ServiceMaterialDataGrid1.ReadOnly = true;
            }
        }
        public void FillDataGridView(int matid)
        { 
                using (ClientEntities db = new ClientEntities())
                {
                    ServiceMaterialDataGrid1.Rows.Clear();
                    List<ServiceMaterials> sm = db.ServiceMaterials.Where(x => x.ServiceID == id).ToList();
                    foreach (ServiceMaterials s in sm)
                    {
                        Material mat1 = db.Material.Where(x => x.Id == s.MaterialID).FirstOrDefault<Material>();
                        ServiceMaterialDataGrid1.Rows.Add(mat1.Name, s.CountPerPiece, s.CountForTheAmount);
                    }
                   // Material mat = db.Material.Find(matid);
                  //  ServiceMaterialDataGrid1.Rows.Add(mat.Name, mat.CostPerPiece, mat.TheCostForTheAmount);
                    ServiceMaterialDataGrid1.ReadOnly = true;
            }
        }
        private void SaveServiceBtn_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    if (db.Service.Find(id) == null)
                    {
                        Service s = new Service();
                        s.Id = id;
                        s.Name = textBox1.Text;
                        s.Price = Convert.ToDouble(textBox2.Text);
                        s.Time = Convert.ToDouble(TimeSerTxtBx.Text);
                        s.Description = textBox3.Text;
                        db.Service.Add(s);
                       // int countrows = ServiceMaterialDataGrid1.Rows.Count;
                        //for (int i = 0; i < countrows-1; i++)
                        //{
                        //    string materialname = Convert.ToString(ServiceMaterialDataGrid1.Rows[i].Cells[0].Value);
                        //    Material temp1 = db.Material.Where(x => x.Name == materialname).FirstOrDefault<Material>();
                        //    int mtrlid = Convert.ToInt16(temp1.Id);
                        //   // ServiceMaterials sm = new ServiceMaterials();
                        //  //  sm.ServiceID = id;
                        //   // sm.MaterialID = mtrlid;
                        //  //  db.ServiceMaterials.Add(sm);
                        //    db.SaveChanges();
                        //}
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        Service temp = db.Service.Where(x => x.Id == id).FirstOrDefault<Service>();
                        temp.Name = textBox1.Text;
                        temp.Price = Convert.ToDouble(textBox2.Text);
                        temp.Description = textBox3.Text;
                        temp.Time= Convert.ToDouble(TimeSerTxtBx.Text);
                        //int countrows = ServiceMaterialDataGrid1.Rows.Count - 1;///////////////////////////////////////////                   
                        //for (int i = 0; i < countrows; i++)
                        //{
                        //    string materialname = ServiceMaterialDataGrid1.Rows[i].Cells[0].Value.ToString();
                        //    Material mat = db.Material.Where(x => x.Name == materialname).FirstOrDefault<Material>();
                        //    if (!db.ServiceMaterials.Any(x => x.ServiceID.Equals(id) && x.MaterialID.Equals(mat.Id) && x.DeleteTime == null))
                        //    {
                        //        ServiceMaterials sm = new ServiceMaterials();
                        //        sm.ServiceID = id;
                        //        sm.MaterialID = mat.Id;
                        //        db.ServiceMaterials.Add(sm);
                        //        db.SaveChanges();
                        //    }
                        //}
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
        private void ServiceEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Service.Find(id) != null)
                {
                    Service temp = db.Service.Where(x => x.Id == id).FirstOrDefault<Service>();
                    textBox1.Text = temp.Name;
                    textBox2.Text = Convert.ToString(temp.Price);
                    textBox3.Text = temp.Description;
                    TimeSerTxtBx.Text = Convert.ToString(temp.Time);
                    FillDataGridView();
                }
                else
                {
                    Service c = new Service();
                    c.Id = db.Service.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }

        private void AddMaterialInService_Click(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                //TattooParlor TP = new TattooParlor();
                //TP.Text = "Добавить услугу";
                //TP.BackId = id;
                // TP.FormStatus = 4;
                //TP.ShowDialog();
                AddMaterialCount AMC = new AddMaterialCount();
                AMC.Status = 2;
                AMC.Serviceid = id;
                AMC.ShowDialog();
                int MatID = AMC.Materialid;
                FillDataGridView(MatID);//////////////////////////////
            }
        }

        private void DeleteMaterialFromService_Click(object sender, EventArgs e)
        {
            string temp = Convert.ToString(this.ServiceMaterialDataGrid1.CurrentRow.Cells[0].Value);
            using (ClientEntities db = new ClientEntities())
            {
                DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить материал?", "Тату салон", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Material mat = db.Material.Where(x => x.Name == temp).FirstOrDefault<Material>();
                    ServiceMaterials sm = db.ServiceMaterials.Where(x => x.ServiceID == id && x.MaterialID == mat.Id).FirstOrDefault<ServiceMaterials>();//and deletetime!=0?
                    db.ServiceMaterials.Remove(sm);
                    db.SaveChanges();
                    FillDataGridView();
                }              
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            int count = ServiceMaterialDataGrid1.Rows.Count;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "Название услуги \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Стоимость услуги \n"; v = false; }
            if (count == 1) { error.SetError(ServiceMaterialDataGrid1, "Заполните поле!"); message += "Материалы \n"; v = false; }
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

        private void TimeSerTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
