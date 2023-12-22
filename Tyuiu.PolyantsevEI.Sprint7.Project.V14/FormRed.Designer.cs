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
            this.buttonOpen_PEI = new System.Windows.Forms.Button();
            this.buttonDelete_PEI = new System.Windows.Forms.Button();
            this.buttonAdd_PEI = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSave_PEI = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxPanel_PEI.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBoxPanel_PEI);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 359);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxPanel_PEI
            // 
            this.groupBoxPanel_PEI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.groupBoxPanel_PEI.Controls.Add(this.buttonSave_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonOpen_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonDelete_PEI);
            this.groupBoxPanel_PEI.Controls.Add(this.buttonAdd_PEI);
            this.groupBoxPanel_PEI.Location = new System.Drawing.Point(0, -7);
            this.groupBoxPanel_PEI.Name = "groupBoxPanel_PEI";
            this.groupBoxPanel_PEI.Size = new System.Drawing.Size(126, 362);
            this.groupBoxPanel_PEI.TabIndex = 2;
            this.groupBoxPanel_PEI.TabStop = false;
            // 
            // buttonOpen_PEI
            // 
            this.buttonOpen_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_PEI.Image")));
            this.buttonOpen_PEI.Location = new System.Drawing.Point(21, 142);
            this.buttonOpen_PEI.Name = "buttonOpen_PEI";
            this.buttonOpen_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonOpen_PEI.TabIndex = 2;
            this.buttonOpen_PEI.UseVisualStyleBackColor = true;
            // 
            // buttonDelete_PEI
            // 
            this.buttonDelete_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_PEI.Image")));
            this.buttonDelete_PEI.Location = new System.Drawing.Point(21, 76);
            this.buttonDelete_PEI.Name = "buttonDelete_PEI";
            this.buttonDelete_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonDelete_PEI.TabIndex = 1;
            this.buttonDelete_PEI.UseVisualStyleBackColor = true;
            this.buttonDelete_PEI.Click += new System.EventHandler(this.buttonDelete_PEI_Click);
            // 
            // buttonAdd_PEI
            // 
            this.buttonAdd_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd_PEI.Image")));
            this.buttonAdd_PEI.Location = new System.Drawing.Point(21, 10);
            this.buttonAdd_PEI.Name = "buttonAdd_PEI";
            this.buttonAdd_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonAdd_PEI.TabIndex = 0;
            this.buttonAdd_PEI.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(127, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 359);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSave_PEI
            // 
            this.buttonSave_PEI.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave_PEI.Image")));
            this.buttonSave_PEI.Location = new System.Drawing.Point(21, 208);
            this.buttonSave_PEI.Name = "buttonSave_PEI";
            this.buttonSave_PEI.Size = new System.Drawing.Size(80, 60);
            this.buttonSave_PEI.TabIndex = 3;
            this.buttonSave_PEI.UseVisualStyleBackColor = true;
            // 
            // FormRed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormRed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать";
            this.panel1.ResumeLayout(false);
            this.groupBoxPanel_PEI.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxPanel_PEI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete_PEI;
        private System.Windows.Forms.Button buttonAdd_PEI;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonOpen_PEI;
        private System.Windows.Forms.Button buttonSave_PEI;
    }
}