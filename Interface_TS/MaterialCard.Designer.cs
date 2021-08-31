namespace Interface_TS
{
    partial class MaterialCard
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MaterialNameLbl = new System.Windows.Forms.Label();
            this.MaterialNameOfSupplierLbl = new System.Windows.Forms.Label();
            this.MaterialCostPerPieceLbl = new System.Windows.Forms.Label();
            this.MaterialTheCostForTheAmountLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DeleteMaterialBtn = new System.Windows.Forms.Button();
            this.BranchMaterialDataGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialDescriptionLbl = new System.Windows.Forms.Label();
            this.Branch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название материала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование поставщика:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Стоимость за штуку:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Стоимость за грамм:";
            // 
            // MaterialNameLbl
            // 
            this.MaterialNameLbl.AutoSize = true;
            this.MaterialNameLbl.Location = new System.Drawing.Point(171, 18);
            this.MaterialNameLbl.Name = "MaterialNameLbl";
            this.MaterialNameLbl.Size = new System.Drawing.Size(35, 13);
            this.MaterialNameLbl.TabIndex = 4;
            this.MaterialNameLbl.Text = "label5";
            // 
            // MaterialNameOfSupplierLbl
            // 
            this.MaterialNameOfSupplierLbl.AutoSize = true;
            this.MaterialNameOfSupplierLbl.Location = new System.Drawing.Point(171, 52);
            this.MaterialNameOfSupplierLbl.Name = "MaterialNameOfSupplierLbl";
            this.MaterialNameOfSupplierLbl.Size = new System.Drawing.Size(35, 13);
            this.MaterialNameOfSupplierLbl.TabIndex = 5;
            this.MaterialNameOfSupplierLbl.Text = "label6";
            // 
            // MaterialCostPerPieceLbl
            // 
            this.MaterialCostPerPieceLbl.AutoSize = true;
            this.MaterialCostPerPieceLbl.Location = new System.Drawing.Point(171, 89);
            this.MaterialCostPerPieceLbl.Name = "MaterialCostPerPieceLbl";
            this.MaterialCostPerPieceLbl.Size = new System.Drawing.Size(35, 13);
            this.MaterialCostPerPieceLbl.TabIndex = 6;
            this.MaterialCostPerPieceLbl.Text = "label7";
            // 
            // MaterialTheCostForTheAmountLbl
            // 
            this.MaterialTheCostForTheAmountLbl.AutoSize = true;
            this.MaterialTheCostForTheAmountLbl.Location = new System.Drawing.Point(171, 125);
            this.MaterialTheCostForTheAmountLbl.Name = "MaterialTheCostForTheAmountLbl";
            this.MaterialTheCostForTheAmountLbl.Size = new System.Drawing.Size(35, 13);
            this.MaterialTheCostForTheAmountLbl.TabIndex = 7;
            this.MaterialTheCostForTheAmountLbl.Text = "label8";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(15, 308);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(348, 23);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DeleteMaterialBtn
            // 
            this.DeleteMaterialBtn.Location = new System.Drawing.Point(288, 337);
            this.DeleteMaterialBtn.Name = "DeleteMaterialBtn";
            this.DeleteMaterialBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteMaterialBtn.TabIndex = 9;
            this.DeleteMaterialBtn.Text = "Удалить";
            this.DeleteMaterialBtn.UseVisualStyleBackColor = true;
            this.DeleteMaterialBtn.Click += new System.EventHandler(this.DeleteMaterialBtn_Click);
            // 
            // BranchMaterialDataGrid
            // 
            this.BranchMaterialDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BranchMaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchMaterialDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Branch,
            this.Ostatok,
            this.Ostatok_1});
            this.BranchMaterialDataGrid.Location = new System.Drawing.Point(15, 152);
            this.BranchMaterialDataGrid.Name = "BranchMaterialDataGrid";
            this.BranchMaterialDataGrid.Size = new System.Drawing.Size(348, 150);
            this.BranchMaterialDataGrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Описание:";
            // 
            // MaterialDescriptionLbl
            // 
            this.MaterialDescriptionLbl.AutoSize = true;
            this.MaterialDescriptionLbl.Location = new System.Drawing.Point(301, 18);
            this.MaterialDescriptionLbl.Name = "MaterialDescriptionLbl";
            this.MaterialDescriptionLbl.Size = new System.Drawing.Size(35, 13);
            this.MaterialDescriptionLbl.TabIndex = 12;
            this.MaterialDescriptionLbl.Text = "label6";
            // 
            // Branch
            // 
            this.Branch.HeaderText = "Услуга";
            this.Branch.Name = "Branch";
            // 
            // Ostatok
            // 
            this.Ostatok.HeaderText = "Расход в гр.";
            this.Ostatok.Name = "Ostatok";
            // 
            // Ostatok_1
            // 
            this.Ostatok_1.HeaderText = "Расход в шт.";
            this.Ostatok_1.Name = "Ostatok_1";
            // 
            // MaterialCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.MaterialDescriptionLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BranchMaterialDataGrid);
            this.Controls.Add(this.DeleteMaterialBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.MaterialTheCostForTheAmountLbl);
            this.Controls.Add(this.MaterialCostPerPieceLbl);
            this.Controls.Add(this.MaterialNameOfSupplierLbl);
            this.Controls.Add(this.MaterialNameLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MaterialCard";
            this.Text = "Материалы";
            this.Load += new System.EventHandler(this.MaterialCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MaterialNameLbl;
        private System.Windows.Forms.Label MaterialNameOfSupplierLbl;
        private System.Windows.Forms.Label MaterialCostPerPieceLbl;
        private System.Windows.Forms.Label MaterialTheCostForTheAmountLbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteMaterialBtn;
        private System.Windows.Forms.DataGridView BranchMaterialDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MaterialDescriptionLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Branch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok_1;
    }
}