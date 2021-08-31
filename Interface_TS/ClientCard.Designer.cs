namespace Interface_TS
{
    partial class ClientCard
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
            this.label2 = new System.Windows.Forms.Label();
            this.FIOLbl = new System.Windows.Forms.Label();
            this.PhoneClientNumberLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteClientBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.CommentTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон";
            // 
            // FIOLbl
            // 
            this.FIOLbl.AutoSize = true;
            this.FIOLbl.Location = new System.Drawing.Point(75, 18);
            this.FIOLbl.Name = "FIOLbl";
            this.FIOLbl.Size = new System.Drawing.Size(123, 13);
            this.FIOLbl.TabIndex = 2;
            this.FIOLbl.Text = "Петров Петр Петрович";
            // 
            // PhoneClientNumberLbl
            // 
            this.PhoneClientNumberLbl.AutoSize = true;
            this.PhoneClientNumberLbl.Location = new System.Drawing.Point(75, 46);
            this.PhoneClientNumberLbl.Name = "PhoneClientNumberLbl";
            this.PhoneClientNumberLbl.Size = new System.Drawing.Size(73, 13);
            this.PhoneClientNumberLbl.TabIndex = 3;
            this.PhoneClientNumberLbl.Text = "88005555535";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Комментарий";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(15, 225);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(257, 23);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteClientBtn
            // 
            this.DeleteClientBtn.Location = new System.Drawing.Point(197, 254);
            this.DeleteClientBtn.Name = "DeleteClientBtn";
            this.DeleteClientBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteClientBtn.TabIndex = 7;
            this.DeleteClientBtn.Text = "Удалить";
            this.DeleteClientBtn.UseVisualStyleBackColor = true;
            this.DeleteClientBtn.Click += new System.EventHandler(this.DeleteClientBtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Просмотреть расписание";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(15, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Посмотреть платежи";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // CommentTxtBox
            // 
            this.CommentTxtBox.Location = new System.Drawing.Point(15, 92);
            this.CommentTxtBox.Multiline = true;
            this.CommentTxtBox.Name = "CommentTxtBox";
            this.CommentTxtBox.Size = new System.Drawing.Size(257, 69);
            this.CommentTxtBox.TabIndex = 12;
            // 
            // ClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.CommentTxtBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteClientBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneClientNumberLbl);
            this.Controls.Add(this.FIOLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientCard";
            this.Text = "Клиент";
            this.Load += new System.EventHandler(this.ClientCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteClientBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox CommentTxtBox;
        public System.Windows.Forms.Label FIOLbl;
        public System.Windows.Forms.Label PhoneClientNumberLbl;
    }
}