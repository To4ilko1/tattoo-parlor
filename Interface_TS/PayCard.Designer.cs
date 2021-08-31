namespace Interface_TS
{
    partial class PayCard
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
            this.label2 = new System.Windows.Forms.Label();
            this.ClientSessionLinkLbl = new System.Windows.Forms.LinkLabel();
            this.DeletePayBtn = new System.Windows.Forms.Button();
            this.PayGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OstatokDescriptionLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.PayStateLbl = new System.Windows.Forms.Label();
            this.OstatokLbl = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PayGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Клиент:";
            // 
            // ClientSessionLinkLbl
            // 
            this.ClientSessionLinkLbl.AutoSize = true;
            this.ClientSessionLinkLbl.Location = new System.Drawing.Point(57, 9);
            this.ClientSessionLinkLbl.Name = "ClientSessionLinkLbl";
            this.ClientSessionLinkLbl.Size = new System.Drawing.Size(55, 13);
            this.ClientSessionLinkLbl.TabIndex = 6;
            this.ClientSessionLinkLbl.TabStop = true;
            this.ClientSessionLinkLbl.Text = "linkLabel1";
            this.ClientSessionLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClientSessionLinkLbl_LinkClicked);
            // 
            // DeletePayBtn
            // 
            this.DeletePayBtn.Location = new System.Drawing.Point(482, 274);
            this.DeletePayBtn.Name = "DeletePayBtn";
            this.DeletePayBtn.Size = new System.Drawing.Size(75, 23);
            this.DeletePayBtn.TabIndex = 11;
            this.DeletePayBtn.Text = "Удалить";
            this.DeletePayBtn.UseVisualStyleBackColor = true;
            this.DeletePayBtn.Click += new System.EventHandler(this.DeletePayBtn_Click);
            // 
            // PayGridView
            // 
            this.PayGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PayGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PayGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Service,
            this.Date,
            this.Worker,
            this.Cost,
            this.Pay});
            this.PayGridView.Location = new System.Drawing.Point(12, 33);
            this.PayGridView.Name = "PayGridView";
            this.PayGridView.Size = new System.Drawing.Size(545, 166);
            this.PayGridView.TabIndex = 12;
            this.PayGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PayGridView_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Итоговая сумма:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Оплачено: ";
            // 
            // OstatokDescriptionLbl
            // 
            this.OstatokDescriptionLbl.AutoSize = true;
            this.OstatokDescriptionLbl.Location = new System.Drawing.Point(464, 214);
            this.OstatokDescriptionLbl.Name = "OstatokDescriptionLbl";
            this.OstatokDescriptionLbl.Size = new System.Drawing.Size(52, 13);
            this.OstatokDescriptionLbl.TabIndex = 19;
            this.OstatokDescriptionLbl.Text = "Остаток:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(110, 214);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(35, 13);
            this.PriceLbl.TabIndex = 22;
            this.PriceLbl.Text = "label5";
            // 
            // PayStateLbl
            // 
            this.PayStateLbl.AutoSize = true;
            this.PayStateLbl.Location = new System.Drawing.Point(313, 214);
            this.PayStateLbl.Name = "PayStateLbl";
            this.PayStateLbl.Size = new System.Drawing.Size(35, 13);
            this.PayStateLbl.TabIndex = 23;
            this.PayStateLbl.Text = "label6";
            // 
            // OstatokLbl
            // 
            this.OstatokLbl.AutoSize = true;
            this.OstatokLbl.Location = new System.Drawing.Point(522, 214);
            this.OstatokLbl.Name = "OstatokLbl";
            this.OstatokLbl.Size = new System.Drawing.Size(35, 13);
            this.OstatokLbl.TabIndex = 24;
            this.OstatokLbl.Text = "label7";
            // 
            // PayBtn
            // 
            this.PayBtn.Location = new System.Drawing.Point(200, 230);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(181, 65);
            this.PayBtn.TabIndex = 25;
            this.PayBtn.Text = "Оплатить";
            this.PayBtn.UseVisualStyleBackColor = true;
            this.PayBtn.Click += new System.EventHandler(this.EditPayBtn_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id платежа";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id услуги";
            this.Column1.Name = "Column1";
            // 
            // Service
            // 
            this.Service.HeaderText = "Услуга";
            this.Service.Name = "Service";
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата услуги";
            this.Date.Name = "Date";
            // 
            // Worker
            // 
            this.Worker.HeaderText = "Работник";
            this.Worker.Name = "Worker";
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.Name = "Cost";
            // 
            // Pay
            // 
            this.Pay.HeaderText = "Оплачено";
            this.Pay.Name = "Pay";
            this.Pay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PayCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 307);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.OstatokLbl);
            this.Controls.Add(this.PayStateLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.OstatokDescriptionLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PayGridView);
            this.Controls.Add(this.DeletePayBtn);
            this.Controls.Add(this.ClientSessionLinkLbl);
            this.Controls.Add(this.label2);
            this.Name = "PayCard";
            this.Text = "Платёж";
            this.Load += new System.EventHandler(this.PayCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel ClientSessionLinkLbl;
        private System.Windows.Forms.Button DeletePayBtn;
        private System.Windows.Forms.DataGridView PayGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label OstatokDescriptionLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label PayStateLbl;
        private System.Windows.Forms.Label OstatokLbl;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pay;
    }
}