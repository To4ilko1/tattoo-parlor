namespace Interface_TS
{
    partial class DeleteMaterialCount
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
            this.TheCostForTheAmountTxtBx = new System.Windows.Forms.TextBox();
            this.SaveMaterialCountInBranch = new System.Windows.Forms.Button();
            this.CostPerPieceTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ChooseMaterial = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какое количество материала хотите списать?";
            // 
            // TheCostForTheAmountTxtBx
            // 
            this.TheCostForTheAmountTxtBx.Location = new System.Drawing.Point(95, 80);
            this.TheCostForTheAmountTxtBx.Name = "TheCostForTheAmountTxtBx";
            this.TheCostForTheAmountTxtBx.Size = new System.Drawing.Size(100, 20);
            this.TheCostForTheAmountTxtBx.TabIndex = 1;
            // 
            // SaveMaterialCountInBranch
            // 
            this.SaveMaterialCountInBranch.Location = new System.Drawing.Point(228, 133);
            this.SaveMaterialCountInBranch.Name = "SaveMaterialCountInBranch";
            this.SaveMaterialCountInBranch.Size = new System.Drawing.Size(75, 23);
            this.SaveMaterialCountInBranch.TabIndex = 2;
            this.SaveMaterialCountInBranch.Text = "Ок";
            this.SaveMaterialCountInBranch.UseVisualStyleBackColor = true;
            this.SaveMaterialCountInBranch.Click += new System.EventHandler(this.SaveMaterialCountInBranch_Click);
            // 
            // CostPerPieceTxt
            // 
            this.CostPerPieceTxt.Location = new System.Drawing.Point(95, 123);
            this.CostPerPieceTxt.Name = "CostPerPieceTxt";
            this.CostPerPieceTxt.Size = new System.Drawing.Size(100, 20);
            this.CostPerPieceTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Объем в шт.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Объем в гр.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Материал";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(78, 41);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // ChooseMaterial
            // 
            this.ChooseMaterial.Location = new System.Drawing.Point(228, 35);
            this.ChooseMaterial.Name = "ChooseMaterial";
            this.ChooseMaterial.Size = new System.Drawing.Size(75, 23);
            this.ChooseMaterial.TabIndex = 8;
            this.ChooseMaterial.Text = "Выбрать";
            this.ChooseMaterial.UseVisualStyleBackColor = true;
            this.ChooseMaterial.Click += new System.EventHandler(this.ChooseMaterial_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // DeleteMaterialCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 172);
            this.Controls.Add(this.ChooseMaterial);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CostPerPieceTxt);
            this.Controls.Add(this.SaveMaterialCountInBranch);
            this.Controls.Add(this.TheCostForTheAmountTxtBx);
            this.Controls.Add(this.label1);
            this.Name = "DeleteMaterialCount";
            this.Text = "Списывание материалов";
            this.Load += new System.EventHandler(this.DeleteMaterialCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TheCostForTheAmountTxtBx;
        private System.Windows.Forms.Button SaveMaterialCountInBranch;
        private System.Windows.Forms.TextBox CostPerPieceTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button ChooseMaterial;
        private System.Windows.Forms.ErrorProvider error;
    }
}