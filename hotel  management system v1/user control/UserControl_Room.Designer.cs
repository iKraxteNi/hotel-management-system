
namespace hotel__management_system_v1.user_control
{
    partial class UserControl_Room
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNrRoom = new System.Windows.Forms.TextBox();
            this.textCenaRoom = new System.Windows.Forms.TextBox();
            this.textBedRoom = new System.Windows.Forms.ComboBox();
            this.textTypRoom = new System.Windows.Forms.ComboBox();
            this.AddRoom = new System.Windows.Forms.Button();
            this.buttonDeleteRoom = new System.Windows.Forms.Button();
            this.textBoxNrDelete = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj pokój ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(628, 298);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(715, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NR Pokoju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(715, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(715, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Łóżka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(715, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cena";
            // 
            // textNrRoom
            // 
            this.textNrRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNrRoom.Location = new System.Drawing.Point(715, 85);
            this.textNrRoom.Name = "textNrRoom";
            this.textNrRoom.Size = new System.Drawing.Size(355, 27);
            this.textNrRoom.TabIndex = 6;
            // 
            // textCenaRoom
            // 
            this.textCenaRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCenaRoom.Location = new System.Drawing.Point(715, 278);
            this.textCenaRoom.Name = "textCenaRoom";
            this.textCenaRoom.Size = new System.Drawing.Size(355, 27);
            this.textCenaRoom.TabIndex = 7;
            // 
            // textBedRoom
            // 
            this.textBedRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBedRoom.FormattingEnabled = true;
            this.textBedRoom.Items.AddRange(new object[] {
            "1 (1os.)",
            "1 (2os.)",
            "2 (1os.)",
            "3 (1os.)"});
            this.textBedRoom.Location = new System.Drawing.Point(715, 213);
            this.textBedRoom.Name = "textBedRoom";
            this.textBedRoom.Size = new System.Drawing.Size(355, 28);
            this.textBedRoom.TabIndex = 10;
            // 
            // textTypRoom
            // 
            this.textTypRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTypRoom.FormattingEnabled = true;
            this.textTypRoom.Items.AddRange(new object[] {
            "Klimatyzowany ",
            "Nie klimatyzowany "});
            this.textTypRoom.Location = new System.Drawing.Point(715, 145);
            this.textTypRoom.Name = "textTypRoom";
            this.textTypRoom.Size = new System.Drawing.Size(355, 28);
            this.textTypRoom.TabIndex = 11;
            // 
            // AddRoom
            // 
            this.AddRoom.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddRoom.Location = new System.Drawing.Point(834, 357);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(236, 59);
            this.AddRoom.TabIndex = 12;
            this.AddRoom.Text = "DODAJ";
            this.AddRoom.UseVisualStyleBackColor = false;
            this.AddRoom.Click += new System.EventHandler(this.AddRoom_Click);
            // 
            // buttonDeleteRoom
            // 
            this.buttonDeleteRoom.BackColor = System.Drawing.Color.IndianRed;
            this.buttonDeleteRoom.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteRoom.Location = new System.Drawing.Point(545, 380);
            this.buttonDeleteRoom.Name = "buttonDeleteRoom";
            this.buttonDeleteRoom.Size = new System.Drawing.Size(110, 36);
            this.buttonDeleteRoom.TabIndex = 13;
            this.buttonDeleteRoom.Text = "Usun";
            this.buttonDeleteRoom.UseVisualStyleBackColor = false;
            this.buttonDeleteRoom.Click += new System.EventHandler(this.buttonDeleteRoom_Click);
            // 
            // textBoxNrDelete
            // 
            this.textBoxNrDelete.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNrDelete.ForeColor = System.Drawing.Color.Black;
            this.textBoxNrDelete.Location = new System.Drawing.Point(305, 385);
            this.textBoxNrDelete.Name = "textBoxNrDelete";
            this.textBoxNrDelete.ReadOnly = true;
            this.textBoxNrDelete.Size = new System.Drawing.Size(193, 29);
            this.textBoxNrDelete.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID pokoju ";
            // 
            // UserControl_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNrDelete);
            this.Controls.Add(this.buttonDeleteRoom);
            this.Controls.Add(this.AddRoom);
            this.Controls.Add(this.textTypRoom);
            this.Controls.Add(this.textBedRoom);
            this.Controls.Add(this.textCenaRoom);
            this.Controls.Add(this.textNrRoom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Room";
            this.Size = new System.Drawing.Size(1286, 485);
            this.Load += new System.EventHandler(this.UserControl_Room_Load);
            this.Enter += new System.EventHandler(this.UserControl_Room_Enter);
            this.Leave += new System.EventHandler(this.UserControl_Room_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNrRoom;
        private System.Windows.Forms.TextBox textCenaRoom;
        private System.Windows.Forms.ComboBox textBedRoom;
        private System.Windows.Forms.ComboBox textTypRoom;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button buttonDeleteRoom;
        private System.Windows.Forms.TextBox textBoxNrDelete;
        private System.Windows.Forms.Label label6;
    }
}
