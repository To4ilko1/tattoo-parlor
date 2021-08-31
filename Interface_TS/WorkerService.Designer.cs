namespace Interface_TS
{
    partial class WorkerService
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
            this.ChooseServiceToWorkerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CommentToServiceTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveWorkerToServiceBtn = new System.Windows.Forms.Button();
            this.ServiceLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeStartDtm = new System.Windows.Forms.DateTimePicker();
            this.TimeEndDtm = new System.Windows.Forms.DateTimePicker();
            this.WorkerLinkLbl = new System.Windows.Forms.LinkLabel();
            this.ChooseWorkerToServiceBtn = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.CabinetLinkLbl = new System.Windows.Forms.LinkLabel();
            this.ChooseCabinetToServiceBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Услуга:";
            // 
            // ChooseServiceToWorkerBtn
            // 
            this.ChooseServiceToWorkerBtn.Location = new System.Drawing.Point(262, 37);
            this.ChooseServiceToWorkerBtn.Name = "ChooseServiceToWorkerBtn";
            this.ChooseServiceToWorkerBtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseServiceToWorkerBtn.TabIndex = 2;
            this.ChooseServiceToWorkerBtn.Text = "Выбрать";
            this.ChooseServiceToWorkerBtn.UseVisualStyleBackColor = true;
            this.ChooseServiceToWorkerBtn.Click += new System.EventHandler(this.ChooseServiceToWorkerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Мастер:";
            // 
            // CommentToServiceTxt
            // 
            this.CommentToServiceTxt.Location = new System.Drawing.Point(87, 185);
            this.CommentToServiceTxt.Name = "CommentToServiceTxt";
            this.CommentToServiceTxt.Size = new System.Drawing.Size(250, 67);
            this.CommentToServiceTxt.TabIndex = 5;
            this.CommentToServiceTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание:";
            // 
            // SaveWorkerToServiceBtn
            // 
            this.SaveWorkerToServiceBtn.Location = new System.Drawing.Point(262, 258);
            this.SaveWorkerToServiceBtn.Name = "SaveWorkerToServiceBtn";
            this.SaveWorkerToServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveWorkerToServiceBtn.TabIndex = 7;
            this.SaveWorkerToServiceBtn.Text = "Сохранить";
            this.SaveWorkerToServiceBtn.UseVisualStyleBackColor = true;
            this.SaveWorkerToServiceBtn.Click += new System.EventHandler(this.SaveWorkerToServiceBtn_Click);
            // 
            // ServiceLinkLbl
            // 
            this.ServiceLinkLbl.AutoSize = true;
            this.ServiceLinkLbl.Location = new System.Drawing.Point(84, 42);
            this.ServiceLinkLbl.Name = "ServiceLinkLbl";
            this.ServiceLinkLbl.Size = new System.Drawing.Size(55, 13);
            this.ServiceLinkLbl.TabIndex = 8;
            this.ServiceLinkLbl.TabStop = true;
            this.ServiceLinkLbl.Text = "linkLabel1";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Время начала услуги:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Время окончания услуги:";
            // 
            // TimeStartDtm
            // 
            this.TimeStartDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStartDtm.Location = new System.Drawing.Point(158, 69);
            this.TimeStartDtm.Name = "TimeStartDtm";
            this.TimeStartDtm.Size = new System.Drawing.Size(83, 20);
            this.TimeStartDtm.TabIndex = 15;
            this.TimeStartDtm.ValueChanged += new System.EventHandler(this.TimeStartDtm_ValueChanged);
            // 
            // TimeEndDtm
            // 
            this.TimeEndDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEndDtm.Location = new System.Drawing.Point(158, 104);
            this.TimeEndDtm.Name = "TimeEndDtm";
            this.TimeEndDtm.Size = new System.Drawing.Size(83, 20);
            this.TimeEndDtm.TabIndex = 16;
            // 
            // WorkerLinkLbl
            // 
            this.WorkerLinkLbl.AutoSize = true;
            this.WorkerLinkLbl.Location = new System.Drawing.Point(84, 146);
            this.WorkerLinkLbl.Name = "WorkerLinkLbl";
            this.WorkerLinkLbl.Size = new System.Drawing.Size(55, 13);
            this.WorkerLinkLbl.TabIndex = 17;
            this.WorkerLinkLbl.TabStop = true;
            this.WorkerLinkLbl.Text = "linkLabel1";
            // 
            // ChooseWorkerToServiceBtn
            // 
            this.ChooseWorkerToServiceBtn.Location = new System.Drawing.Point(262, 141);
            this.ChooseWorkerToServiceBtn.Name = "ChooseWorkerToServiceBtn";
            this.ChooseWorkerToServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseWorkerToServiceBtn.TabIndex = 18;
            this.ChooseWorkerToServiceBtn.Text = "Выбрать";
            this.ChooseWorkerToServiceBtn.UseVisualStyleBackColor = true;
            this.ChooseWorkerToServiceBtn.Click += new System.EventHandler(this.ChooseWorkerToServiceBtn_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Кабинет:";
            // 
            // CabinetLinkLbl
            // 
            this.CabinetLinkLbl.AutoSize = true;
            this.CabinetLinkLbl.Location = new System.Drawing.Point(84, 13);
            this.CabinetLinkLbl.Name = "CabinetLinkLbl";
            this.CabinetLinkLbl.Size = new System.Drawing.Size(55, 13);
            this.CabinetLinkLbl.TabIndex = 20;
            this.CabinetLinkLbl.TabStop = true;
            this.CabinetLinkLbl.Text = "linkLabel1";
            // 
            // ChooseCabinetToServiceBtn
            // 
            this.ChooseCabinetToServiceBtn.Location = new System.Drawing.Point(262, 8);
            this.ChooseCabinetToServiceBtn.Name = "ChooseCabinetToServiceBtn";
            this.ChooseCabinetToServiceBtn.Size = new System.Drawing.Size(75, 23);
            this.ChooseCabinetToServiceBtn.TabIndex = 21;
            this.ChooseCabinetToServiceBtn.Text = "Выбрать";
            this.ChooseCabinetToServiceBtn.UseVisualStyleBackColor = true;
            this.ChooseCabinetToServiceBtn.Click += new System.EventHandler(this.ChooseCabinetToServiceBtn_Click);
            // 
            // WorkerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 291);
            this.Controls.Add(this.ChooseCabinetToServiceBtn);
            this.Controls.Add(this.CabinetLinkLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ChooseWorkerToServiceBtn);
            this.Controls.Add(this.WorkerLinkLbl);
            this.Controls.Add(this.TimeEndDtm);
            this.Controls.Add(this.TimeStartDtm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ServiceLinkLbl);
            this.Controls.Add(this.SaveWorkerToServiceBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CommentToServiceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChooseServiceToWorkerBtn);
            this.Controls.Add(this.label1);
            this.Name = "WorkerService";
            this.Text = "Выбор мастера для услуги";
            this.Load += new System.EventHandler(this.WorkerService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChooseServiceToWorkerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox CommentToServiceTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveWorkerToServiceBtn;
        private System.Windows.Forms.LinkLabel ServiceLinkLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker TimeStartDtm;
        private System.Windows.Forms.DateTimePicker TimeEndDtm;
        private System.Windows.Forms.LinkLabel WorkerLinkLbl;
        private System.Windows.Forms.Button ChooseWorkerToServiceBtn;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Button ChooseCabinetToServiceBtn;
        private System.Windows.Forms.LinkLabel CabinetLinkLbl;
        private System.Windows.Forms.Label label8;
    }
}