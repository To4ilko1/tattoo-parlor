namespace Interface_TS
{
    partial class CabinetCard
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
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CabinetNameLbl = new System.Windows.Forms.Label();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CabinetServicesListBx = new System.Windows.Forms.ListBox();
            this.EditCabinetBtn = new System.Windows.Forms.Button();
            this.DeleteCabinetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CabinetBranchLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Наименование кабинета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // CabinetNameLbl
            // 
            this.CabinetNameLbl.AutoSize = true;
            this.CabinetNameLbl.Location = new System.Drawing.Point(147, 18);
            this.CabinetNameLbl.Name = "CabinetNameLbl";
            this.CabinetNameLbl.Size = new System.Drawing.Size(24, 13);
            this.CabinetNameLbl.TabIndex = 3;
            this.CabinetNameLbl.Text = "№3";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Location = new System.Drawing.Point(147, 46);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(35, 13);
            this.DescriptionLbl.TabIndex = 4;
            this.DescriptionLbl.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Список услуг";
            // 
            // CabinetServicesListBx
            // 
            this.CabinetServicesListBx.FormattingEnabled = true;
            this.CabinetServicesListBx.Location = new System.Drawing.Point(15, 126);
            this.CabinetServicesListBx.Name = "CabinetServicesListBx";
            this.CabinetServicesListBx.Size = new System.Drawing.Size(319, 95);
            this.CabinetServicesListBx.TabIndex = 6;
            // 
            // EditCabinetBtn
            // 
            this.EditCabinetBtn.Location = new System.Drawing.Point(239, 234);
            this.EditCabinetBtn.Name = "EditCabinetBtn";
            this.EditCabinetBtn.Size = new System.Drawing.Size(95, 23);
            this.EditCabinetBtn.TabIndex = 7;
            this.EditCabinetBtn.Text = "Редактировать";
            this.EditCabinetBtn.UseVisualStyleBackColor = true;
            this.EditCabinetBtn.Click += new System.EventHandler(this.EditCabinetBtn_Click);
            // 
            // DeleteCabinetBtn
            // 
            this.DeleteCabinetBtn.Location = new System.Drawing.Point(15, 234);
            this.DeleteCabinetBtn.Name = "DeleteCabinetBtn";
            this.DeleteCabinetBtn.Size = new System.Drawing.Size(95, 23);
            this.DeleteCabinetBtn.TabIndex = 8;
            this.DeleteCabinetBtn.Text = "Удалить";
            this.DeleteCabinetBtn.UseVisualStyleBackColor = true;
            this.DeleteCabinetBtn.Click += new System.EventHandler(this.DeleteCabinetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Филиал";
            // 
            // CabinetBranchLbl
            // 
            this.CabinetBranchLbl.AutoSize = true;
            this.CabinetBranchLbl.Location = new System.Drawing.Point(147, 77);
            this.CabinetBranchLbl.Name = "CabinetBranchLbl";
            this.CabinetBranchLbl.Size = new System.Drawing.Size(35, 13);
            this.CabinetBranchLbl.TabIndex = 10;
            this.CabinetBranchLbl.Text = "label7";
            // 
            // CabinetCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 269);
            this.Controls.Add(this.CabinetBranchLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteCabinetBtn);
            this.Controls.Add(this.EditCabinetBtn);
            this.Controls.Add(this.CabinetServicesListBx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.CabinetNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Name = "CabinetCard";
            this.Text = "Кабинет";
            this.Load += new System.EventHandler(this.CabinetCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CabinetNameLbl;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox CabinetServicesListBx;
        private System.Windows.Forms.Button EditCabinetBtn;
        private System.Windows.Forms.Button DeleteCabinetBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CabinetBranchLbl;
    }
}