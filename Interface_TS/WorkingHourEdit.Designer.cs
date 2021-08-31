namespace Interface_TS
{
    partial class WorkingHourEdit
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
            this.WorkerCmbBx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeStartDtm = new System.Windows.Forms.DateTimePicker();
            this.TimeEndDtm = new System.Windows.Forms.DateTimePicker();
            this.SaveWorkingHourBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BranchCmbBx = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DateEndDtm = new System.Windows.Forms.DateTimePicker();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.error3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.DateStartDtm = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастер:";
            // 
            // WorkerCmbBx
            // 
            this.WorkerCmbBx.FormattingEnabled = true;
            this.WorkerCmbBx.Location = new System.Drawing.Point(124, 13);
            this.WorkerCmbBx.Name = "WorkerCmbBx";
            this.WorkerCmbBx.Size = new System.Drawing.Size(136, 21);
            this.WorkerCmbBx.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Время конца:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Время начала:";
            // 
            // TimeStartDtm
            // 
            this.TimeStartDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStartDtm.Location = new System.Drawing.Point(124, 79);
            this.TimeStartDtm.Name = "TimeStartDtm";
            this.TimeStartDtm.ShowUpDown = true;
            this.TimeStartDtm.Size = new System.Drawing.Size(136, 20);
            this.TimeStartDtm.TabIndex = 13;
            // 
            // TimeEndDtm
            // 
            this.TimeEndDtm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEndDtm.Location = new System.Drawing.Point(124, 114);
            this.TimeEndDtm.Name = "TimeEndDtm";
            this.TimeEndDtm.ShowUpDown = true;
            this.TimeEndDtm.Size = new System.Drawing.Size(136, 20);
            this.TimeEndDtm.TabIndex = 14;
            // 
            // SaveWorkingHourBtn
            // 
            this.SaveWorkingHourBtn.Location = new System.Drawing.Point(194, 288);
            this.SaveWorkingHourBtn.Name = "SaveWorkingHourBtn";
            this.SaveWorkingHourBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveWorkingHourBtn.TabIndex = 18;
            this.SaveWorkingHourBtn.Text = "Сохранить";
            this.SaveWorkingHourBtn.UseVisualStyleBackColor = true;
            this.SaveWorkingHourBtn.Click += new System.EventHandler(this.SaveWorkingHourBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Филиал:";
            // 
            // BranchCmbBx
            // 
            this.BranchCmbBx.FormattingEnabled = true;
            this.BranchCmbBx.Location = new System.Drawing.Point(124, 45);
            this.BranchCmbBx.Name = "BranchCmbBx";
            this.BranchCmbBx.Size = new System.Drawing.Size(136, 21);
            this.BranchCmbBx.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.DateEndDtm);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(16, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 124);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Окончание";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(7, 93);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // DateEndDtm
            // 
            this.DateEndDtm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEndDtm.Location = new System.Drawing.Point(7, 44);
            this.DateEndDtm.Name = "DateEndDtm";
            this.DateEndDtm.Size = new System.Drawing.Size(134, 20);
            this.DateEndDtm.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(164, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По количеству повторений:";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По дате:\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // error2
            // 
            this.error2.ContainerControl = this;
            // 
            // error3
            // 
            this.error3.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата начала:";
            // 
            // DateStartDtm
            // 
            this.DateStartDtm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartDtm.Location = new System.Drawing.Point(124, 146);
            this.DateStartDtm.Name = "DateStartDtm";
            this.DateStartDtm.Size = new System.Drawing.Size(136, 20);
            this.DateStartDtm.TabIndex = 23;
            // 
            // WorkingHourEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 323);
            this.Controls.Add(this.DateStartDtm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BranchCmbBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveWorkingHourBtn);
            this.Controls.Add(this.TimeEndDtm);
            this.Controls.Add(this.TimeStartDtm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WorkerCmbBx);
            this.Controls.Add(this.label1);
            this.Name = "WorkingHourEdit";
            this.Text = "WorkingHourEdit";
            this.Load += new System.EventHandler(this.WorkingHourEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WorkerCmbBx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker TimeStartDtm;
        private System.Windows.Forms.DateTimePicker TimeEndDtm;
        private System.Windows.Forms.Button SaveWorkingHourBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BranchCmbBx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker DateEndDtm;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ErrorProvider error1;
        private System.Windows.Forms.ErrorProvider error2;
        private System.Windows.Forms.ErrorProvider error3;
        private System.Windows.Forms.DateTimePicker DateStartDtm;
        private System.Windows.Forms.Label label3;
    }
}