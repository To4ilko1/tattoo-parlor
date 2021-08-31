namespace Interface_TS
{
    partial class WorkingHourCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.WorkingHourWorkerLbl = new System.Windows.Forms.Label();
            this.WorkingHourBranchNameLbl1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.WorkingHourTimeStartLbl = new System.Windows.Forms.Label();
            this.EditWorkingHourBtn = new System.Windows.Forms.Button();
            this.DeleteWorkingHourBtn = new System.Windows.Forms.Button();
            this.labl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkingHourTimeEndLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мастер:";
            // 
            // WorkingHourWorkerLbl
            // 
            this.WorkingHourWorkerLbl.AutoSize = true;
            this.WorkingHourWorkerLbl.Location = new System.Drawing.Point(100, 13);
            this.WorkingHourWorkerLbl.Name = "WorkingHourWorkerLbl";
            this.WorkingHourWorkerLbl.Size = new System.Drawing.Size(35, 13);
            this.WorkingHourWorkerLbl.TabIndex = 1;
            this.WorkingHourWorkerLbl.Text = "label2";
            // 
            // WorkingHourBranchNameLbl1
            // 
            this.WorkingHourBranchNameLbl1.AutoSize = true;
            this.WorkingHourBranchNameLbl1.Location = new System.Drawing.Point(100, 50);
            this.WorkingHourBranchNameLbl1.Name = "WorkingHourBranchNameLbl1";
            this.WorkingHourBranchNameLbl1.Size = new System.Drawing.Size(35, 13);
            this.WorkingHourBranchNameLbl1.TabIndex = 8;
            this.WorkingHourBranchNameLbl1.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(143, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 9;
            // 
            // WorkingHourTimeStartLbl
            // 
            this.WorkingHourTimeStartLbl.AutoSize = true;
            this.WorkingHourTimeStartLbl.Location = new System.Drawing.Point(100, 84);
            this.WorkingHourTimeStartLbl.Name = "WorkingHourTimeStartLbl";
            this.WorkingHourTimeStartLbl.Size = new System.Drawing.Size(41, 13);
            this.WorkingHourTimeStartLbl.TabIndex = 10;
            this.WorkingHourTimeStartLbl.Text = "label11";
            // 
            // EditWorkingHourBtn
            // 
            this.EditWorkingHourBtn.Location = new System.Drawing.Point(16, 149);
            this.EditWorkingHourBtn.Name = "EditWorkingHourBtn";
            this.EditWorkingHourBtn.Size = new System.Drawing.Size(263, 23);
            this.EditWorkingHourBtn.TabIndex = 12;
            this.EditWorkingHourBtn.Text = "Редактировать";
            this.EditWorkingHourBtn.UseVisualStyleBackColor = true;
            this.EditWorkingHourBtn.Click += new System.EventHandler(this.EditWorkingHourBtn_Click);
            // 
            // DeleteWorkingHourBtn
            // 
            this.DeleteWorkingHourBtn.Location = new System.Drawing.Point(204, 180);
            this.DeleteWorkingHourBtn.Name = "DeleteWorkingHourBtn";
            this.DeleteWorkingHourBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteWorkingHourBtn.TabIndex = 13;
            this.DeleteWorkingHourBtn.Text = "Удалить";
            this.DeleteWorkingHourBtn.UseVisualStyleBackColor = true;
            this.DeleteWorkingHourBtn.Click += new System.EventHandler(this.DeleteWorkingHourBtn_Click);
            // 
            // labl
            // 
            this.labl.AutoSize = true;
            this.labl.Location = new System.Drawing.Point(13, 84);
            this.labl.Name = "labl";
            this.labl.Size = new System.Drawing.Size(81, 13);
            this.labl.TabIndex = 4;
            this.labl.Text = "Время начала:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Время конца:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Филиал:";
            // 
            // WorkingHourTimeEndLbl
            // 
            this.WorkingHourTimeEndLbl.AutoSize = true;
            this.WorkingHourTimeEndLbl.Location = new System.Drawing.Point(100, 118);
            this.WorkingHourTimeEndLbl.Name = "WorkingHourTimeEndLbl";
            this.WorkingHourTimeEndLbl.Size = new System.Drawing.Size(41, 13);
            this.WorkingHourTimeEndLbl.TabIndex = 15;
            this.WorkingHourTimeEndLbl.Text = "label12";
            // 
            // WorkingHourCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 215);
            this.Controls.Add(this.WorkingHourTimeEndLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteWorkingHourBtn);
            this.Controls.Add(this.EditWorkingHourBtn);
            this.Controls.Add(this.WorkingHourTimeStartLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.WorkingHourBranchNameLbl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labl);
            this.Controls.Add(this.WorkingHourWorkerLbl);
            this.Controls.Add(this.label1);
            this.Name = "WorkingHourCard";
            this.Text = "Расписание работника";
            this.Load += new System.EventHandler(this.WorkingHourCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WorkingHourWorkerLbl;
        private System.Windows.Forms.Label WorkingHourBranchNameLbl1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label WorkingHourTimeStartLbl;
        private System.Windows.Forms.Button EditWorkingHourBtn;
        private System.Windows.Forms.Button DeleteWorkingHourBtn;
        private System.Windows.Forms.Label labl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label WorkingHourTimeEndLbl;
    }
}