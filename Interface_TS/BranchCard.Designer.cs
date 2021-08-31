namespace Interface_TS
{
    partial class BranchCard
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
            this.BranchNameLbl = new System.Windows.Forms.Label();
            this.BranchAddressLbl = new System.Windows.Forms.Label();
            this.EditBranchBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BranchPhoneLbl = new System.Windows.Forms.Label();
            this.BranchMaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddMaterialInBranch = new System.Windows.Forms.Button();
            this.DeleteBranchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DeleteMaterialFromBranch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название филиала";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // BranchNameLbl
            // 
            this.BranchNameLbl.AutoSize = true;
            this.BranchNameLbl.Location = new System.Drawing.Point(133, 13);
            this.BranchNameLbl.Name = "BranchNameLbl";
            this.BranchNameLbl.Size = new System.Drawing.Size(35, 13);
            this.BranchNameLbl.TabIndex = 2;
            this.BranchNameLbl.Text = "label3";
            // 
            // BranchAddressLbl
            // 
            this.BranchAddressLbl.AutoSize = true;
            this.BranchAddressLbl.Location = new System.Drawing.Point(133, 45);
            this.BranchAddressLbl.Name = "BranchAddressLbl";
            this.BranchAddressLbl.Size = new System.Drawing.Size(35, 13);
            this.BranchAddressLbl.TabIndex = 3;
            this.BranchAddressLbl.Text = "label4";
            // 
            // EditBranchBtn
            // 
            this.EditBranchBtn.Location = new System.Drawing.Point(63, 307);
            this.EditBranchBtn.Name = "EditBranchBtn";
            this.EditBranchBtn.Size = new System.Drawing.Size(248, 23);
            this.EditBranchBtn.TabIndex = 4;
            this.EditBranchBtn.Text = "Редактировать";
            this.EditBranchBtn.UseVisualStyleBackColor = true;
            this.EditBranchBtn.Click += new System.EventHandler(this.EditBranchBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Телефон";
            // 
            // BranchPhoneLbl
            // 
            this.BranchPhoneLbl.AutoSize = true;
            this.BranchPhoneLbl.Location = new System.Drawing.Point(133, 79);
            this.BranchPhoneLbl.Name = "BranchPhoneLbl";
            this.BranchPhoneLbl.Size = new System.Drawing.Size(35, 13);
            this.BranchPhoneLbl.TabIndex = 7;
            this.BranchPhoneLbl.Text = "label6";
            // 
            // BranchMaterialDataGrid
            // 
            this.BranchMaterialDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BranchMaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchMaterialDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.Ostatok,
            this.Ostatok_1});
            this.BranchMaterialDataGrid.Location = new System.Drawing.Point(9, 19);
            this.BranchMaterialDataGrid.Name = "BranchMaterialDataGrid";
            this.BranchMaterialDataGrid.Size = new System.Drawing.Size(353, 150);
            this.BranchMaterialDataGrid.TabIndex = 8;
            // 
            // Material
            // 
            this.Material.HeaderText = "Материал";
            this.Material.Name = "Material";
            // 
            // Ostatok
            // 
            this.Ostatok.HeaderText = "Остаток в шт.";
            this.Ostatok.Name = "Ostatok";
            // 
            // Ostatok_1
            // 
            this.Ostatok_1.HeaderText = "Остаток в гр.";
            this.Ostatok_1.Name = "Ostatok_1";
            // 
            // AddMaterialInBranch
            // 
            this.AddMaterialInBranch.Location = new System.Drawing.Point(9, 176);
            this.AddMaterialInBranch.Name = "AddMaterialInBranch";
            this.AddMaterialInBranch.Size = new System.Drawing.Size(75, 23);
            this.AddMaterialInBranch.TabIndex = 9;
            this.AddMaterialInBranch.Text = "Добавить";
            this.AddMaterialInBranch.UseVisualStyleBackColor = true;
            this.AddMaterialInBranch.Click += new System.EventHandler(this.AddMaterialInBranch_Click);
            // 
            // DeleteBranchBtn
            // 
            this.DeleteBranchBtn.Location = new System.Drawing.Point(266, 346);
            this.DeleteBranchBtn.Name = "DeleteBranchBtn";
            this.DeleteBranchBtn.Size = new System.Drawing.Size(112, 22);
            this.DeleteBranchBtn.TabIndex = 10;
            this.DeleteBranchBtn.Text = "Удалить филиал";
            this.DeleteBranchBtn.UseVisualStyleBackColor = true;
            this.DeleteBranchBtn.Click += new System.EventHandler(this.DeleteBranchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BranchMaterialDataGrid);
            this.groupBox1.Controls.Add(this.AddMaterialInBranch);
            this.groupBox1.Controls.Add(this.DeleteMaterialFromBranch);
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 205);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наличие материалов";
            // 
            // DeleteMaterialFromBranch
            // 
            this.DeleteMaterialFromBranch.Location = new System.Drawing.Point(287, 175);
            this.DeleteMaterialFromBranch.Name = "DeleteMaterialFromBranch";
            this.DeleteMaterialFromBranch.Size = new System.Drawing.Size(75, 23);
            this.DeleteMaterialFromBranch.TabIndex = 5;
            this.DeleteMaterialFromBranch.Text = "Списать";
            this.DeleteMaterialFromBranch.UseVisualStyleBackColor = true;
            this.DeleteMaterialFromBranch.Click += new System.EventHandler(this.DeleteMaterialFromBranch_Click);
            // 
            // BranchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteBranchBtn);
            this.Controls.Add(this.BranchPhoneLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EditBranchBtn);
            this.Controls.Add(this.BranchAddressLbl);
            this.Controls.Add(this.BranchNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BranchCard";
            this.Text = "Филиал";
            this.Load += new System.EventHandler(this.BranchCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BranchNameLbl;
        private System.Windows.Forms.Label BranchAddressLbl;
        private System.Windows.Forms.Button EditBranchBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BranchPhoneLbl;
        private System.Windows.Forms.DataGridView BranchMaterialDataGrid;
        private System.Windows.Forms.Button AddMaterialInBranch;
        private System.Windows.Forms.Button DeleteBranchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DeleteMaterialFromBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok_1;
    }
}