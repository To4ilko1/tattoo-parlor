namespace Interface_TS
{
    partial class BranchEdit
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
            this.SaveBranchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BranchMaterialDataGrid1 = new System.Windows.Forms.DataGridView();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ostatok_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 3;
            // 
            // SaveBranchBtn
            // 
            this.SaveBranchBtn.Location = new System.Drawing.Point(303, 316);
            this.SaveBranchBtn.Name = "SaveBranchBtn";
            this.SaveBranchBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBranchBtn.TabIndex = 4;
            this.SaveBranchBtn.Text = "Сохранить";
            this.SaveBranchBtn.UseVisualStyleBackColor = true;
            this.SaveBranchBtn.Click += new System.EventHandler(this.SaveBranchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Телефон";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(123, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BranchMaterialDataGrid1);
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наличие материала";
            // 
            // BranchMaterialDataGrid1
            // 
            this.BranchMaterialDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BranchMaterialDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BranchMaterialDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.material,
            this.Ostatok,
            this.Ostatok_1});
            this.BranchMaterialDataGrid1.Location = new System.Drawing.Point(9, 19);
            this.BranchMaterialDataGrid1.Name = "BranchMaterialDataGrid1";
            this.BranchMaterialDataGrid1.Size = new System.Drawing.Size(353, 150);
            this.BranchMaterialDataGrid1.TabIndex = 0;
            // 
            // material
            // 
            this.material.HeaderText = "Материал";
            this.material.Name = "material";
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
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // BranchEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaveBranchBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BranchEdit";
            this.Text = "Филиал";
            this.Load += new System.EventHandler(this.BranchEdit_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchMaterialDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SaveBranchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView BranchMaterialDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ostatok_1;
        private System.Windows.Forms.ErrorProvider error;
    }
}