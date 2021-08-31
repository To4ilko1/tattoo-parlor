namespace Interface_TS
{
    partial class ServiceEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SaveServiceBtn = new System.Windows.Forms.Button();
            this.ServiceMaterialDataGrid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMaterialInService = new System.Windows.Forms.Button();
            this.DeleteMaterialFromService = new System.Windows.Forms.Button();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.TimeSerTxtBx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMaterialDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название услуги:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость услуги:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(45, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // SaveServiceBtn
            // 
            this.SaveServiceBtn.Location = new System.Drawing.Point(321, 321);
            this.SaveServiceBtn.Name = "SaveServiceBtn";
            this.SaveServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveServiceBtn.TabIndex = 6;
            this.SaveServiceBtn.Text = "Сохранить";
            this.SaveServiceBtn.UseVisualStyleBackColor = true;
            this.SaveServiceBtn.Click += new System.EventHandler(this.SaveServiceBtn_Click);
            // 
            // ServiceMaterialDataGrid1
            // 
            this.ServiceMaterialDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceMaterialDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceMaterialDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.ServiceMaterialDataGrid1.Location = new System.Drawing.Point(15, 136);
            this.ServiceMaterialDataGrid1.Name = "ServiceMaterialDataGrid1";
            this.ServiceMaterialDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceMaterialDataGrid1.Size = new System.Drawing.Size(381, 150);
            this.ServiceMaterialDataGrid1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование материала";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Объём, требующийся для услуги в шт.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Материал, требующийся для услуги в гр.";
            this.Column3.Name = "Column3";
            // 
            // AddMaterialInService
            // 
            this.AddMaterialInService.Location = new System.Drawing.Point(15, 292);
            this.AddMaterialInService.Name = "AddMaterialInService";
            this.AddMaterialInService.Size = new System.Drawing.Size(117, 23);
            this.AddMaterialInService.TabIndex = 8;
            this.AddMaterialInService.Text = "Добавить материал";
            this.AddMaterialInService.UseVisualStyleBackColor = true;
            this.AddMaterialInService.Click += new System.EventHandler(this.AddMaterialInService_Click);
            // 
            // DeleteMaterialFromService
            // 
            this.DeleteMaterialFromService.Location = new System.Drawing.Point(279, 292);
            this.DeleteMaterialFromService.Name = "DeleteMaterialFromService";
            this.DeleteMaterialFromService.Size = new System.Drawing.Size(117, 23);
            this.DeleteMaterialFromService.TabIndex = 9;
            this.DeleteMaterialFromService.Text = "Удалить материал";
            this.DeleteMaterialFromService.UseVisualStyleBackColor = true;
            this.DeleteMaterialFromService.Click += new System.EventHandler(this.DeleteMaterialFromService_Click);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(12, 80);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLbl.TabIndex = 10;
            this.DescriptionLbl.Text = "Описание:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 77);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(282, 53);
            this.textBox3.TabIndex = 11;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Длительность услуги( в мин):";
            // 
            // TimeSerTxtBx
            // 
            this.TimeSerTxtBx.Location = new System.Drawing.Point(351, 47);
            this.TimeSerTxtBx.Name = "TimeSerTxtBx";
            this.TimeSerTxtBx.Size = new System.Drawing.Size(45, 20);
            this.TimeSerTxtBx.TabIndex = 13;
            this.TimeSerTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeSerTxtBx_KeyPress);
            // 
            // ServiceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 366);
            this.Controls.Add(this.TimeSerTxtBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.DeleteMaterialFromService);
            this.Controls.Add(this.AddMaterialInService);
            this.Controls.Add(this.ServiceMaterialDataGrid1);
            this.Controls.Add(this.SaveServiceBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ServiceEdit";
            this.Text = "Услуга";
            this.Load += new System.EventHandler(this.ServiceEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMaterialDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SaveServiceBtn;
        private System.Windows.Forms.DataGridView ServiceMaterialDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button AddMaterialInService;
        private System.Windows.Forms.Button DeleteMaterialFromService;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox TimeSerTxtBx;
        private System.Windows.Forms.Label label3;
    }
}