namespace Interface_TS
{
    partial class ServiceCard
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
            this.PriceServiceLbl = new System.Windows.Forms.Label();
            this.ServiceNameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ServicePriceLbl = new System.Windows.Forms.Label();
            this.EditServiceBtn = new System.Windows.Forms.Button();
            this.DeleteServiceBtn = new System.Windows.Forms.Button();
            this.ServiceMaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.Coliumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceTimeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMaterialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceServiceLbl
            // 
            this.PriceServiceLbl.AutoSize = true;
            this.PriceServiceLbl.Location = new System.Drawing.Point(12, 18);
            this.PriceServiceLbl.Name = "PriceServiceLbl";
            this.PriceServiceLbl.Size = new System.Drawing.Size(96, 13);
            this.PriceServiceLbl.TabIndex = 0;
            this.PriceServiceLbl.Text = "Название услуги:";
            // 
            // ServiceNameLbl
            // 
            this.ServiceNameLbl.AutoSize = true;
            this.ServiceNameLbl.Location = new System.Drawing.Point(119, 18);
            this.ServiceNameLbl.Name = "ServiceNameLbl";
            this.ServiceNameLbl.Size = new System.Drawing.Size(35, 13);
            this.ServiceNameLbl.TabIndex = 1;
            this.ServiceNameLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость услуги:";
            // 
            // ServicePriceLbl
            // 
            this.ServicePriceLbl.AutoSize = true;
            this.ServicePriceLbl.Location = new System.Drawing.Point(119, 46);
            this.ServicePriceLbl.Name = "ServicePriceLbl";
            this.ServicePriceLbl.Size = new System.Drawing.Size(35, 13);
            this.ServicePriceLbl.TabIndex = 5;
            this.ServicePriceLbl.Text = "label5";
            // 
            // EditServiceBtn
            // 
            this.EditServiceBtn.Location = new System.Drawing.Point(12, 322);
            this.EditServiceBtn.Name = "EditServiceBtn";
            this.EditServiceBtn.Size = new System.Drawing.Size(346, 23);
            this.EditServiceBtn.TabIndex = 6;
            this.EditServiceBtn.Text = "Редактировать";
            this.EditServiceBtn.UseVisualStyleBackColor = true;
            this.EditServiceBtn.Click += new System.EventHandler(this.EditServiceBtn_Click);
            // 
            // DeleteServiceBtn
            // 
            this.DeleteServiceBtn.Location = new System.Drawing.Point(283, 351);
            this.DeleteServiceBtn.Name = "DeleteServiceBtn";
            this.DeleteServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteServiceBtn.TabIndex = 7;
            this.DeleteServiceBtn.Text = "Удалить";
            this.DeleteServiceBtn.UseVisualStyleBackColor = true;
            this.DeleteServiceBtn.Click += new System.EventHandler(this.DeleteServiceBtn_Click);
            // 
            // ServiceMaterialDataGrid
            // 
            this.ServiceMaterialDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceMaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceMaterialDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coliumn1,
            this.Column2,
            this.Column3});
            this.ServiceMaterialDataGrid.Location = new System.Drawing.Point(12, 166);
            this.ServiceMaterialDataGrid.Name = "ServiceMaterialDataGrid";
            this.ServiceMaterialDataGrid.Size = new System.Drawing.Size(346, 150);
            this.ServiceMaterialDataGrid.TabIndex = 8;
            // 
            // Coliumn1
            // 
            this.Coliumn1.HeaderText = "Наименование материала";
            this.Coliumn1.Name = "Coliumn1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Количество материала, требующегося для услуги в шт.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Количество материала, требующегося для услуги в гр.";
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Описание:";
            // 
            // DescriptionTxt
            // 
            this.DescriptionTxt.Location = new System.Drawing.Point(78, 99);
            this.DescriptionTxt.Multiline = true;
            this.DescriptionTxt.Name = "DescriptionTxt";
            this.DescriptionTxt.Size = new System.Drawing.Size(280, 53);
            this.DescriptionTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Длительность услуги( в мин):";
            // 
            // ServiceTimeLbl
            // 
            this.ServiceTimeLbl.AutoSize = true;
            this.ServiceTimeLbl.Location = new System.Drawing.Point(175, 74);
            this.ServiceTimeLbl.Name = "ServiceTimeLbl";
            this.ServiceTimeLbl.Size = new System.Drawing.Size(35, 13);
            this.ServiceTimeLbl.TabIndex = 12;
            this.ServiceTimeLbl.Text = "label4";
            // 
            // ServiceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 385);
            this.Controls.Add(this.ServiceTimeLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DescriptionTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceMaterialDataGrid);
            this.Controls.Add(this.DeleteServiceBtn);
            this.Controls.Add(this.EditServiceBtn);
            this.Controls.Add(this.ServicePriceLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServiceNameLbl);
            this.Controls.Add(this.PriceServiceLbl);
            this.Name = "ServiceCard";
            this.Text = "Услуга";
            this.Load += new System.EventHandler(this.ServiceCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceMaterialDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceServiceLbl;
        private System.Windows.Forms.Label ServiceNameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ServicePriceLbl;
        private System.Windows.Forms.Button EditServiceBtn;
        private System.Windows.Forms.Button DeleteServiceBtn;
        private System.Windows.Forms.DataGridView ServiceMaterialDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescriptionTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coliumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ServiceTimeLbl;
    }
}