﻿
namespace hotel__management_system_v1.user_control
{
    partial class UserControl_KData
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDaneK = new System.Windows.Forms.ComboBox();
            this.dataGridViewDaneK = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaneK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dane Klientów";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wyszukaj:";
            // 
            // comboBoxDaneK
            // 
            this.comboBoxDaneK.BackColor = System.Drawing.Color.SkyBlue;
            this.comboBoxDaneK.FormattingEnabled = true;
            this.comboBoxDaneK.Items.AddRange(new object[] {
            "Wszyscy Klienci",
            "Zameldowani",
            "Wymeldowani"});
            this.comboBoxDaneK.Location = new System.Drawing.Point(517, 92);
            this.comboBoxDaneK.Name = "comboBoxDaneK";
            this.comboBoxDaneK.Size = new System.Drawing.Size(265, 23);
            this.comboBoxDaneK.TabIndex = 4;
            this.comboBoxDaneK.SelectedIndexChanged += new System.EventHandler(this.comboBoxDaneK_SelectedIndexChanged);
            // 
            // dataGridViewDaneK
            // 
            this.dataGridViewDaneK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDaneK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaneK.Location = new System.Drawing.Point(38, 121);
            this.dataGridViewDaneK.Name = "dataGridViewDaneK";
            this.dataGridViewDaneK.RowTemplate.Height = 25;
            this.dataGridViewDaneK.Size = new System.Drawing.Size(1213, 348);
            this.dataGridViewDaneK.TabIndex = 5;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonExport.Location = new System.Drawing.Point(1116, 92);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export danych do pliku .xlm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserControl_KData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridViewDaneK);
            this.Controls.Add(this.comboBoxDaneK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_KData";
            this.Size = new System.Drawing.Size(1286, 485);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaneK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDaneK;
        private System.Windows.Forms.DataGridView dataGridViewDaneK;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
