namespace Tyuiu.PolyantsevEI.Sprint7.Project.V14
{
    partial class FormRed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxPanel_PEI = new System.Windows.Forms.GroupBox();
            this.buttonSave_PEI = new System.Windows.Forms.Button();
            this.buttonDelete_PEI = new System.Windows.Forms.Button();
            this.buttonAdd_PEI = new System.Windows.Forms.Button();
            this.buttonOpen_PEI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridMatrix_PEI = new System.Windows.Forms.DataGridView();
            this.openFileDialog_PEI = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBoxPanel_PEI.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_PEI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxPanel_PEI);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 449);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxPanel_PEI
            // 
            this.groupBoxPanel_PEI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.groupBoxPanel_PEI.Controls.Add(this.buttonSave_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonDelete_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonAdd_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonOpen_PEI);
            this.groupBoxPanel_PEI.Location = new System.Drawing.Point(0, -7);
            this.groupBoxPanel_PEI.Name = "groupBoxPanel_PEI";
            this.groupBoxPanel_PEI.Size = new System.Drawing.Size(126, 454);
            this.groupBoxPanel_PEI.TabIndex = 2;
            this.groupBoxPanel_PEI.TabStop = false;
            // 
            // buttonSave_PEI
            // 
            this.buttonSave_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PEI.Image")));
            this.buttonSave_PEI.Location = new System.Drawing.Point(21, 216);
            this.buttonSave_PEI.Name = "buttonSave_PEI";
            this.buttonSave_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonSave_PEI.TabIndex = 3;
            this.buttonSave_PEI.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_PEI
            // 
            this.buttonDelete_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_PEI.Image")));
            this.buttonDelete_PEI.Location = new System.Drawing.Point(21, 150);
            this.buttonDelete_PEI.Name = "buttonDelete_PEI";
            this.buttonDelete_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonDelete_PEI.TabIndex = 2;
            this.buttonDelete_PEI.UseVisualStyleBackColor = true;
            // 
            // buttonAdd_PEI
            // 
            this.buttonAdd_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_PEI.Image")));
            this.buttonAdd_PEI.Location = new System.Drawing.Point(21, 83);
            this.buttonAdd_PEI.Name = "buttonAdd_PEI";
            this.buttonAdd_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonAdd_PEI.TabIndex = 1;
            this.buttonAdd_PEI.UseVisualStyleBackColor = true;
            this.buttonAdd_PEI.Click += new System.EventHandler(this.buttonDelete_PEI_Click);
            // 
            // buttonOpen_PEI
            // 
            this.buttonOpen_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_PEI.Image")));
            this.buttonOpen_PEI.Location = new System.Drawing.Point(21, 16);
            this.buttonOpen_PEI.Name = "buttonOpen_PEI";
            this.buttonOpen_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonOpen_PEI.TabIndex = 0;
            this.buttonOpen_PEI.UseVisualStyleBackColor = true;
            this.buttonOpen_PEI.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridMatrix_PEI);
            this.panel2.Location = new System.Drawing.Point(127, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 449);
            this.panel2.TabIndex = 1;
            // 
            // dataGridMatrix_PEI
            // 
            this.dataGridMatrix_PEI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMatrix_PEI.Location = new System.Drawing.Point(0, 0);
            this.dataGridMatrix_PEI.Name = "dataGridMatrix_PEI";
            this.dataGridMatrix_PEI.RowHeadersWidth = 51;
            this.dataGridMatrix_PEI.Size = new System.Drawing.Size(724, 447);
            this.dataGridMatrix_PEI.TabIndex = 0;
            this.dataGridMatrix_PEI.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog_PEI
            // 
            this.openFileDialog_PEI.FileName = "openFileDialog1";
            // 
            // FormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(869, 489);
            this.MinimumSize = new System.Drawing.Size(869, 489);
            this.Name = "FormRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.panel1.ResumeLayout(false);
            this.groupBoxPanel_PEI.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMatrix_PEI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPanel_PEI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAdd_PEI;
        private System.Windows.Forms.Button buttonOpen_PEI;
        private System.Windows.Forms.DataGridView dataGridMatrix_PEI;
        private System.Windows.Forms.Button buttonDelete_PEI;
        private System.Windows.Forms.Button buttonSave_PEI;
        private System.Windows.Forms.OpenFileDialog openFileDialog_PEI;
    }
}