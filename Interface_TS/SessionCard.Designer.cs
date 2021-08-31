namespace Interface_TS
{
    partial class SessionCard
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
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateSessionDtm = new System.Windows.Forms.DateTimePicker();
            this.ClientSessionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.EditSessionBtn = new System.Windows.Forms.Button();
            this.DeleteSessionBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SessionServiceDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BranchSessionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.TimeStartDtm = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeEndDtm = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.SessionServiceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Дата сеанса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(442, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиент:";
            // 
            // DateSessionDtm
            // 
            this.DateSessionDtm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateSessionDtm.Location = new System.Drawing.Point(92, 43);
            this.DateSessionDtm.Name = "DateSessionDtm";
            this.DateSessionDtm.Size = new System.Drawing.Size(128, 20);
            this.DateSessionDtm.TabIndex = 7;
            // 
            // ClientSessionLinkLabel
            // 
            this.ClientSessionLinkLabel.AutoSize = true;
            this.ClientSessionLinkLabel.Location = new System.Drawing.Point(519, 13);
            this.ClientSessionLinkLabel.Name = "ClientSessionLinkLabel";
            this.ClientSessionLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.ClientSessionLinkLabel.TabIndex = 9;
            this.ClientSessionLinkLabel.TabStop = true;
            this.ClientSessionLinkLabel.Text = "linkLabel1";
            this.ClientSessionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClientSessionLinkLabel_LinkClicked);
            // 
            // EditSessionBtn
            // 
            this.EditSessionBtn.Location = new System.Drawing.Point(528, 271);
            this.EditSessionBtn.Name = "EditSessionBtn";
            this.EditSessionBtn.Size = new System.Drawing.Size(262, 23);
            this.EditSessionBtn.TabIndex = 12;
            this.EditSessionBtn.Text = "Редактировать";
            this.EditSessionBtn.UseVisualStyleBackColor = true;
            this.EditSessionBtn.Click += new System.EventHandler(this.EditSessionBtn_Click);
            // 
            // DeleteSessionBtn
            // 
            this.DeleteSessionBtn.Location = new System.Drawing.Point(715, 300);
            this.DeleteSessionBtn.Name = "DeleteSessionBtn";
            this.DeleteSessionBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteSessionBtn.TabIndex = 13;
            this.DeleteSessionBtn.Text = "Удалить";
            this.DeleteSessionBtn.UseVisualStyleBackColor = true;
            this.DeleteSessionBtn.Click += new System.EventHandler(this.DeleteSessionBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Филиал:";
            // 
            // SessionServiceDataGrid
            // 
            this.SessionServiceDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionServiceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7});
            this.SessionServiceDataGrid.Location = new System.Drawing.Point(12, 108);
            this.SessionServiceDataGrid.Name = "SessionServiceDataGrid";
            this.SessionServiceDataGrid.Size = new System.Drawing.Size(778, 150);
            this.SessionServiceDataGrid.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Услуга";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Описание";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Кабинет";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Мастер";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Время начала";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Время конца";
            this.Column7.Name = "Column7";
            // 
            // BranchSessionLinkLabel
            // 
            this.BranchSessionLinkLabel.AutoSize = true;
            this.BranchSessionLinkLabel.Location = new System.Drawing.Point(89, 13);
            this.BranchSessionLinkLabel.Name = "BranchSessionLinkLabel";
            this.BranchSessionLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.BranchSessionLinkLabel.TabIndex = 15;
            this.BranchSessionLinkLabel.TabStop = true;
            this.BranchSessionLinkLabel.Text = "linkLabel2";
            this.BranchSessionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BranchSessionLinkLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Итоговая стоимость:";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(131, 271);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(35, 13);
            this.PriceLbl.TabIndex = 18;
            this.PriceLbl.Text = "label6";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(442, 48);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 13);
            this.label.TabIndex = 19;
            this.label.Text = "Время начала:";
            // 
            // TimeStartDtm
            // 
            this.TimeStartDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStartDtm.Location = new System.Drawing.Point(547, 43);
            this.TimeStartDtm.Name = "TimeStartDtm";
            this.TimeStartDtm.Size = new System.Drawing.Size(67, 20);
            this.TimeStartDtm.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Время окончания:";
            // 
            // TimeEndDtm
            // 
            this.TimeEndDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEndDtm.Location = new System.Drawing.Point(547, 77);
            this.TimeEndDtm.Name = "TimeEndDtm";
            this.TimeEndDtm.Size = new System.Drawing.Size(67, 20);
            this.TimeEndDtm.TabIndex = 22;
            // 
            // SessionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 330);
            this.Controls.Add(this.TimeEndDtm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeStartDtm);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SessionServiceDataGrid);
            this.Controls.Add(this.BranchSessionLinkLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeleteSessionBtn);
            this.Controls.Add(this.EditSessionBtn);
            this.Controls.Add(this.ClientSessionLinkLabel);
            this.Controls.Add(this.DateSessionDtm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Name = "SessionCard";
            this.Text = "Сеанс";
            this.Load += new System.EventHandler(this.SessionCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionServiceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateSessionDtm;
        private System.Windows.Forms.LinkLabel ClientSessionLinkLabel;
        private System.Windows.Forms.Button EditSessionBtn;
        private System.Windows.Forms.Button DeleteSessionBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView SessionServiceDataGrid;
        private System.Windows.Forms.LinkLabel BranchSessionLinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DateTimePicker TimeStartDtm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TimeEndDtm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}