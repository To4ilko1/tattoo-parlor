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
    public partial class MaterialEdit : Form
    {
        public MaterialEdit()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private void SaveMaterialBtn_Click_1(object sender, EventArgs e)
        {
            if (Validation())
            {
                using (ClientEntities db = new ClientEntities())
                {
                    if (db.Material.Find(id) == null)
                    {
                        Material m = new Material();
                        m.Id = id;
                        m.Name = textBox1.Text;
                        m.NameOfSupplier = textBox2.Text;
                        if (textBox5.Text != "") m.CostPerPiece = Convert.ToInt32(textBox3.Text);
                        else m.CostPerPiece = null;
                        if (textBox4.Text != "") m.TheCostForTheAmount = Convert.ToDouble(textBox4.Text);
                        else m.TheCostForTheAmount = null;
                        m.Description = textBox5.Text;
                        db.Material.Add(m);
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        Material temp = db.Material.Where(x => x.Id == id && x.DeleteTime == null).FirstOrDefault<Material>();
                        temp.Name = textBox1.Text;
                        temp.NameOfSupplier = textBox2.Text;
                        if (textBox3.Text != "") temp.CostPerPiece = Convert.ToInt32(textBox3.Text);
                        else temp.CostPerPiece = null;
                        if (textBox4.Text != "") temp.TheCostForTheAmount = Convert.ToDouble(textBox4.Text);
                        else temp.TheCostForTheAmount = null;
                        temp.Description = textBox5.Text;
                        db.SaveChanges();
                        this.Close();
                    }
                }
            }
        }
        private void MaterialEdit_Load(object sender, EventArgs e)
        {
            using (ClientEntities db = new ClientEntities())
            {
                if (db.Material.Find(id) != null)
                {
                    Material temp = db.Material.Where(x => x.Id == id && x.DeleteTime == null).FirstOrDefault<Material>();
                    textBox1.Text = temp.Name;
                    textBox2.Text = temp.NameOfSupplier;
                    textBox3.Text = Convert.ToString(temp.CostPerPiece);
                    textBox4.Text = Convert.ToString(temp.TheCostForTheAmount);
                    textBox5.Text = temp.Description;
                }
                else
                {
                    Material c = new Material();
                    c.Id = db.Material.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }
        private bool Validation() //true - все норм false - ошибки
        {
            string message = "\n";
            bool v = true;
            if (textBox1.Text == "") { error.SetError(textBox1, "Заполните поле!"); message += "Название материала \n"; v = false; }
            if (textBox2.Text == "") { error.SetError(textBox2, "Заполните поле!"); message += "Наименование поставщика \n"; v = false; }
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

