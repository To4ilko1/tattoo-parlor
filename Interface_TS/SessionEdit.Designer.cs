namespace Interface_TS
{
    partial class SessionEdit
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DateDtm = new System.Windows.Forms.DateTimePicker();
            this.SaveSessionBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BranchCmbBx = new System.Windows.Forms.ComboBox();
            this.ClientLbl = new System.Windows.Forms.Label();
            this.ChooseClientBtn = new System.Windows.Forms.Button();
            this.SessionServiceDataGrid1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddServiceToSessionBtn = new System.Windows.Forms.Button();
            this.DeleteServiceFromSessionBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.Price1Lbl = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SessionServiceDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата сеанса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Клиент:";
            // 
            // DateDtm
            // 
            this.DateDtm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateDtm.Location = new System.Drawing.Point(101, 44);
            this.DateDtm.Name = "DateDtm";
            this.DateDtm.Size = new System.Drawing.Size(160, 20);
            this.DateDtm.TabIndex = 7;
            // 
            // SaveSessionBtn
            // 
            this.SaveSessionBtn.Location = new System.Drawing.Point(718, 319);
            this.SaveSessionBtn.Name = "SaveSessionBtn";
            this.SaveSessionBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveSessionBtn.TabIndex = 12;
            this.SaveSessionBtn.Text = "Сохранить";
            this.SaveSessionBtn.UseVisualStyleBackColor = true;
            this.SaveSessionBtn.Click += new System.EventHandler(this.SaveSessionBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Филиал:";
            // 
            // BranchCmbBx
            // 
            this.BranchCmbBx.FormattingEnabled = true;
            this.BranchCmbBx.Location = new System.Drawing.Point(101, 10);
            this.BranchCmbBx.Name = "BranchCmbBx";
            this.BranchCmbBx.Size = new System.Drawing.Size(160, 21);
            this.BranchCmbBx.TabIndex = 14;
            // 
            // ClientLbl
            // 
            this.ClientLbl.AutoSize = true;
            this.ClientLbl.Location = new System.Drawing.Point(483, 15);
            this.ClientLbl.Name = "ClientLbl";
            this.ClientLbl.Size = new System.Drawing.Size(35, 13);
            this.ClientLbl.TabIndex = 15;
            this.ClientLbl.Text = "label8";
            // 
            // ChooseClientBtn
            // 
            this.ChooseClientBtn.Location = new System.Drawing.Point(682, 8);
            this.ChooseClientBtn.Name = "ChooseClientBtn";
            this.ChooseClientBtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseClientBtn.TabIndex = 16;
            this.ChooseClientBtn.Text = "Выбрать";
            this.ChooseClientBtn.UseVisualStyleBackColor = true;
            this.ChooseClientBtn.Click += new System.EventHandler(this.ChooseClientBtn_Click);
            // 
            // SessionServiceDataGrid1
            // 
            this.SessionServiceDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SessionServiceDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SessionServiceDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7});
            this.SessionServiceDataGrid1.Location = new System.Drawing.Point(15, 110);
            this.SessionServiceDataGrid1.Name = "SessionServiceDataGrid1";
            this.SessionServiceDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SessionServiceDataGrid1.Size = new System.Drawing.Size(778, 150);
            this.SessionServiceDataGrid1.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Наименование услуги";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Описание";
            this.Column2.Name = "Column2";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Кабинет";
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Мастер";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Стоимость";
            this.Column4.Name = "Column4";
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
            // AddServiceToSessionBtn
            // 
            this.AddServiceToSessionBtn.Location = new System.Drawing.Point(15, 290);
            this.AddServiceToSessionBtn.Name = "AddServiceToSessionBtn";
            this.AddServiceToSessionBtn.Size = new System.Drawing.Size(119, 23);
            this.AddServiceToSessionBtn.TabIndex = 18;
            this.AddServiceToSessionBtn.Text = "Добавить услугу";
            this.AddServiceToSessionBtn.UseVisualStyleBackColor = true;
            this.AddServiceToSessionBtn.Click += new System.EventHandler(this.AddServiceToSessionBtn_Click);
            // 
            // DeleteServiceFromSessionBtn
            // 
            this.DeleteServiceFromSessionBtn.Location = new System.Drawing.Point(674, 290);
            this.DeleteServiceFromSessionBtn.Name = "DeleteServiceFromSessionBtn";
            this.DeleteServiceFromSessionBtn.Size = new System.Drawing.Size(119, 23);
            this.DeleteServiceFromSessionBtn.TabIndex = 19;
            this.DeleteServiceFromSessionBtn.Text = "Удалить услугу";
            this.DeleteServiceFromSessionBtn.UseVisualStyleBackColor = true;
            this.DeleteServiceFromSessionBtn.Click += new System.EventHandler(this.DeleteServiceFromSessionBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Время начала:";
            // 
            // TimeStart
            // 
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStart.Location = new System.Drawing.Point(486, 44);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(67, 20);
            this.TimeStart.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Время окончания:";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(14, 262);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(115, 13);
            this.label0.TabIndex = 25;
            this.label0.Text = "Итоговая стоимость:";
            // 
            // Price1Lbl
            // 
            this.Price1Lbl.AutoSize = true;
            this.Price1Lbl.Location = new System.Drawing.Point(136, 262);
            this.Price1Lbl.Name = "Price1Lbl";
            this.Price1Lbl.Size = new System.Drawing.Size(41, 13);
            this.Price1Lbl.TabIndex = 26;
            this.Price1Lbl.Text = "label11";
            // 
            // TimeEnd
            // 
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEnd.Location = new System.Drawing.Point(486, 79);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(67, 20);
            this.TimeEnd.TabIndex = 27;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // SessionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 353);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.Price1Lbl);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeleteServiceFromSessionBtn);
            this.Controls.Add(this.AddServiceToSessionBtn);
            this.Controls.Add(this.SessionServiceDataGrid1);
            this.Controls.Add(this.ChooseClientBtn);
            this.Controls.Add(this.ClientLbl);
            this.Controls.Add(this.BranchCmbBx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveSessionBtn);
            this.Controls.Add(this.DateDtm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "SessionEdit";
            this.Text = "Сеанс";
            this.Load += new System.EventHandler(this.SessionEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SessionServiceDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DateDtm;
        private System.Windows.Forms.Button SaveSessionBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox BranchCmbBx;
        private System.Windows.Forms.Label ClientLbl;
        private System.Windows.Forms.Button ChooseClientBtn;
        private System.Windows.Forms.DataGridView SessionServiceDataGrid1;
        private System.Windows.Forms.Button AddServiceToSessionBtn;
        private System.Windows.Forms.Button DeleteServiceFromSessionBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label Price1Lbl;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}