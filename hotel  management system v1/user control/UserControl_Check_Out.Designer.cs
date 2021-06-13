
namespace hotel__management_system_v1.user_control
{
    partial class UserControl_Check_Out
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRCOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerRCOut = new System.Windows.Forms.DateTimePicker();
            this.buttonRCOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wymeldowanie Klienta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SZUKAJ  Imię ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(37, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(936, 231);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(39, 112);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(300, 27);
            this.textBoxName.TabIndex = 10;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxCName
            // 
            this.textBoxCName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCName.ForeColor = System.Drawing.Color.Black;
            this.textBoxCName.Location = new System.Drawing.Point(37, 408);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.ReadOnly = true;
            this.textBoxCName.Size = new System.Drawing.Size(300, 27);
            this.textBoxCName.TabIndex = 12;
            this.textBoxCName.TextChanged += new System.EventHandler(this.textBoxCName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Imię i Nazwisko";
            // 
            // textBoxRCOut
            // 
            this.textBoxRCOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRCOut.ForeColor = System.Drawing.Color.Black;
            this.textBoxRCOut.Location = new System.Drawing.Point(355, 408);
            this.textBoxRCOut.Name = "textBoxRCOut";
            this.textBoxRCOut.ReadOnly = true;
            this.textBoxRCOut.Size = new System.Drawing.Size(300, 27);
            this.textBoxRCOut.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(355, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Numer Pokoju";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(672, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data wymeldowania";
            // 
            // dateTimePickerRCOut
            // 
            this.dateTimePickerRCOut.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerRCOut.Location = new System.Drawing.Point(672, 408);
            this.dateTimePickerRCOut.Name = "dateTimePickerRCOut";
            this.dateTimePickerRCOut.Size = new System.Drawing.Size(301, 27);
            this.dateTimePickerRCOut.TabIndex = 16;
            // 
            // buttonRCOut
            // 
            this.buttonRCOut.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRCOut.Location = new System.Drawing.Point(1028, 393);
            this.buttonRCOut.Name = "buttonRCOut";
            this.buttonRCOut.Size = new System.Drawing.Size(236, 59);
            this.buttonRCOut.TabIndex = 17;
            this.buttonRCOut.Text = "Wymelduj ";
            this.buttonRCOut.UseVisualStyleBackColor = false;
            this.buttonRCOut.Click += new System.EventHandler(this.buttonRCOut_Click);
            // 
            // UserControl_Check_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.buttonRCOut);
            this.Controls.Add(this.dateTimePickerRCOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRCOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Check_Out";
            this.Size = new System.Drawing.Size(1286, 485);
            this.Load += new System.EventHandler(this.UserControl_Check_Out_Load);
            this.Leave += new System.EventHandler(this.UserControl_Check_Out_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.TextBox textBoxRCOut;
        private System.Windows.Forms.DateTimePicker dateTimePickerRCOut;
        private System.Windows.Forms.Button buttonRCOut;
    }
}
