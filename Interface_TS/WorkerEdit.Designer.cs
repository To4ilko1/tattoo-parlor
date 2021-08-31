namespace Interface_TS
{
    partial class WorkerEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveWorkerBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ServiceInWorkerListBx = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddServiceToWorker = new System.Windows.Forms.Button();
            this.DeleteServiceToWorker = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефон:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Должность:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стиль тату:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(377, 41);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Комментарий:";
            // 
            // SaveWorkerBtn
            // 
            this.SaveWorkerBtn.Location = new System.Drawing.Point(446, 226);
            this.SaveWorkerBtn.Name = "SaveWorkerBtn";
            this.SaveWorkerBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveWorkerBtn.TabIndex = 10;
            this.SaveWorkerBtn.Text = "Сохранить";
            this.SaveWorkerBtn.UseVisualStyleBackColor = true;
            this.SaveWorkerBtn.Click += new System.EventHandler(this.SaveWorkerBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Список услуг:";
            // 
            // ServiceInWorkerListBx
            // 
            this.ServiceInWorkerListBx.FormattingEnabled = true;
            this.ServiceInWorkerListBx.Location = new System.Drawing.Point(15, 125);
            this.ServiceInWorkerListBx.Name = "ServiceInWorkerListBx";
            this.ServiceInWorkerListBx.Size = new System.Drawing.Size(215, 95);
            this.ServiceInWorkerListBx.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Филиал:";
            // 
            // AddServiceToWorker
            // 
            this.AddServiceToWorker.Location = new System.Drawing.Point(15, 225);
            this.AddServiceToWorker.Name = "AddServiceToWorker";
            this.AddServiceToWorker.Size = new System.Drawing.Size(100, 23);
            this.AddServiceToWorker.TabIndex = 16;
            this.AddServiceToWorker.Text = "Добавить услугу";
            this.AddServiceToWorker.UseVisualStyleBackColor = true;
            this.AddServiceToWorker.Click += new System.EventHandler(this.AddServiceToWorker_Click);
            // 
            // DeleteServiceToWorker
            // 
            this.DeleteServiceToWorker.Location = new System.Drawing.Point(136, 225);
            this.DeleteServiceToWorker.Name = "DeleteServiceToWorker";
            this.DeleteServiceToWorker.Size = new System.Drawing.Size(94, 23);
            this.DeleteServiceToWorker.TabIndex = 17;
            this.DeleteServiceToWorker.Text = "Удалить услугу";
            this.DeleteServiceToWorker.UseVisualStyleBackColor = true;
            this.DeleteServiceToWorker.Click += new System.EventHandler(this.DeleteServiceToWorker_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(306, 126);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(215, 94);
            this.textBox6.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(144, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Стаж работы:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(377, 68);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // WorkerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 267);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.DeleteServiceToWorker);
            this.Controls.Add(this.AddServiceToWorker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ServiceInWorkerListBx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SaveWorkerBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "WorkerEdit";
            this.Text = "Сотрудник";
            this.Load += new System.EventHandler(this.WorkerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveWorkerBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox ServiceInWorkerListBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddServiceToWorker;
        private System.Windows.Forms.Button DeleteServiceToWorker;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ErrorProvider error;
    }
}