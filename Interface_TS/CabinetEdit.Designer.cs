namespace Interface_TS
{
    partial class CabinetEdit
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
            this.label3 = new System.Windows.Forms.Label();
            this.ServiceInCabinetListBx = new System.Windows.Forms.ListBox();
            this.AddServiceInCabinet = new System.Windows.Forms.Button();
            this.DeleteCabinetService = new System.Windows.Forms.Button();
            this.SaveCabinetBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(104, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Список услуг:";
            // 
            // ServiceInCabinetListBx
            // 
            this.ServiceInCabinetListBx.FormattingEnabled = true;
            this.ServiceInCabinetListBx.Location = new System.Drawing.Point(15, 122);
            this.ServiceInCabinetListBx.Name = "ServiceInCabinetListBx";
            this.ServiceInCabinetListBx.Size = new System.Drawing.Size(236, 95);
            this.ServiceInCabinetListBx.TabIndex = 5;
            // 
            // AddServiceInCabinet
            // 
            this.AddServiceInCabinet.Location = new System.Drawing.Point(12, 223);
            this.AddServiceInCabinet.Name = "AddServiceInCabinet";
            this.AddServiceInCabinet.Size = new System.Drawing.Size(110, 23);
            this.AddServiceInCabinet.TabIndex = 6;
            this.AddServiceInCabinet.Text = "Добавить услугу";
            this.AddServiceInCabinet.UseVisualStyleBackColor = true;
            this.AddServiceInCabinet.Click += new System.EventHandler(this.AddServiceInCabinet_Click);
            // 
            // DeleteCabinetService
            // 
            this.DeleteCabinetService.Location = new System.Drawing.Point(141, 223);
            this.DeleteCabinetService.Name = "DeleteCabinetService";
            this.DeleteCabinetService.Size = new System.Drawing.Size(110, 23);
            this.DeleteCabinetService.TabIndex = 7;
            this.DeleteCabinetService.Text = "Удалить услугу";
            this.DeleteCabinetService.UseVisualStyleBackColor = true;
            this.DeleteCabinetService.Click += new System.EventHandler(this.DeleteCabinetService_Click);
            // 
            // SaveCabinetBtn
            // 
            this.SaveCabinetBtn.Location = new System.Drawing.Point(176, 252);
            this.SaveCabinetBtn.Name = "SaveCabinetBtn";
            this.SaveCabinetBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveCabinetBtn.TabIndex = 8;
            this.SaveCabinetBtn.Text = "Сохранить";
            this.SaveCabinetBtn.UseVisualStyleBackColor = true;
            this.SaveCabinetBtn.Click += new System.EventHandler(this.SaveCabinetBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Филиал:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // CabinetEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 292);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveCabinetBtn);
            this.Controls.Add(this.DeleteCabinetService);
            this.Controls.Add(this.AddServiceInCabinet);
            this.Controls.Add(this.ServiceInCabinetListBx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CabinetEdit";
            this.Text = "Кабинет";
            this.Load += new System.EventHandler(this.CabinetEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ServiceInCabinetListBx;
        private System.Windows.Forms.Button AddServiceInCabinet;
        private System.Windows.Forms.Button DeleteCabinetService;
        private System.Windows.Forms.Button SaveCabinetBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider error;
    }
}