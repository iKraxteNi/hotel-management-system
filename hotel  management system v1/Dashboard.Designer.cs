
namespace hotel__management_system_v1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCOut = new System.Windows.Forms.Button();
            this.buttonEnData = new System.Windows.Forms.Button();
            this.buttonCData = new System.Windows.Forms.Button();
            this.buttonRe = new System.Windows.Forms.Button();
            this.buttonRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userControl_pData1 = new hotel__management_system_v1.user_control.UserControl_PData();
            this.userControl_kData1 = new hotel__management_system_v1.user_control.UserControl_KData();
            this.userControl_Check_Out1 = new hotel__management_system_v1.user_control.UserControl_Check_Out();
            this.userControl_registration1 = new hotel__management_system_v1.user_control.UserControl_registration();
            this.userControl_Room1 = new hotel__management_system_v1.user_control.UserControl_Room();
            this.bX = new System.Windows.Forms.Button();
            this.bM = new System.Windows.Forms.Button();
            this.userControl_Check_Out2 = new hotel__management_system_v1.user_control.UserControl_Check_Out();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCOut);
            this.panel1.Controls.Add(this.buttonEnData);
            this.panel1.Controls.Add(this.buttonCData);
            this.panel1.Controls.Add(this.buttonRe);
            this.panel1.Controls.Add(this.buttonRoom);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 125);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonCOut
            // 
            this.buttonCOut.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonCOut.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonCOut.Image")));
            this.buttonCOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCOut.Location = new System.Drawing.Point(539, 10);
            this.buttonCOut.Name = "buttonCOut";
            this.buttonCOut.Size = new System.Drawing.Size(215, 78);
            this.buttonCOut.TabIndex = 1;
            this.buttonCOut.Text = "Wymeldowanie";
            this.buttonCOut.UseVisualStyleBackColor = false;
            this.buttonCOut.Click += new System.EventHandler(this.buttonCOut_Click);
            // 
            // buttonEnData
            // 
            this.buttonEnData.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonEnData.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonEnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEnData.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonEnData.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnData.Image")));
            this.buttonEnData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnData.Location = new System.Drawing.Point(1042, 10);
            this.buttonEnData.Name = "buttonEnData";
            this.buttonEnData.Size = new System.Drawing.Size(215, 78);
            this.buttonEnData.TabIndex = 3;
            this.buttonEnData.Text = "Pracownicy";
            this.buttonEnData.UseVisualStyleBackColor = false;
            this.buttonEnData.Click += new System.EventHandler(this.buttonEnData_Click);
            // 
            // buttonCData
            // 
            this.buttonCData.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonCData.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonCData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCData.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCData.Image = ((System.Drawing.Image)(resources.GetObject("buttonCData.Image")));
            this.buttonCData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCData.Location = new System.Drawing.Point(789, 10);
            this.buttonCData.Name = "buttonCData";
            this.buttonCData.Size = new System.Drawing.Size(215, 78);
            this.buttonCData.TabIndex = 2;
            this.buttonCData.Text = "Dane klienta";
            this.buttonCData.UseVisualStyleBackColor = false;
            this.buttonCData.Click += new System.EventHandler(this.buttonCData_Click);
            // 
            // buttonRe
            // 
            this.buttonRe.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonRe.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRe.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRe.Image = ((System.Drawing.Image)(resources.GetObject("buttonRe.Image")));
            this.buttonRe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRe.Location = new System.Drawing.Point(286, 10);
            this.buttonRe.Name = "buttonRe";
            this.buttonRe.Size = new System.Drawing.Size(215, 78);
            this.buttonRe.TabIndex = 1;
            this.buttonRe.Text = "Rejestracja klienta";
            this.buttonRe.UseVisualStyleBackColor = false;
            this.buttonRe.Click += new System.EventHandler(this.buttonRe_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.buttonRoom.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRoom.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonRoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonRoom.Image")));
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(35, 9);
            this.buttonRoom.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(215, 78);
            this.buttonRoom.TabIndex = 0;
            this.buttonRoom.Text = "Dodaj Pokuj";
            this.buttonRoom.UseVisualStyleBackColor = false;
            this.buttonRoom.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userControl_pData1);
            this.panel2.Controls.Add(this.userControl_kData1);
            this.panel2.Controls.Add(this.userControl_Check_Out1);
            this.panel2.Controls.Add(this.userControl_registration1);
            this.panel2.Controls.Add(this.userControl_Room1);
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 486);
            this.panel2.TabIndex = 1;
            // 
            // userControl_pData1
            // 
            this.userControl_pData1.BackColor = System.Drawing.Color.White;
            this.userControl_pData1.Location = new System.Drawing.Point(-1, -2);
            this.userControl_pData1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.userControl_pData1.Name = "userControl_pData1";
            this.userControl_pData1.Size = new System.Drawing.Size(1286, 485);
            this.userControl_pData1.TabIndex = 4;
            // 
            // userControl_kData1
            // 
            this.userControl_kData1.BackColor = System.Drawing.Color.White;
            this.userControl_kData1.Location = new System.Drawing.Point(-1, 0);
            this.userControl_kData1.Name = "userControl_kData1";
            this.userControl_kData1.Size = new System.Drawing.Size(1286, 485);
            this.userControl_kData1.TabIndex = 3;
            // 
            // userControl_Check_Out1
            // 
            this.userControl_Check_Out1.BackColor = System.Drawing.Color.White;
            this.userControl_Check_Out1.Location = new System.Drawing.Point(0, 1);
            this.userControl_Check_Out1.Name = "userControl_Check_Out1";
            this.userControl_Check_Out1.Size = new System.Drawing.Size(1286, 485);
            this.userControl_Check_Out1.TabIndex = 2;
            // 
            // userControl_registration1
            // 
            this.userControl_registration1.BackColor = System.Drawing.Color.White;
            this.userControl_registration1.Location = new System.Drawing.Point(0, 0);
            this.userControl_registration1.Name = "userControl_registration1";
            this.userControl_registration1.Size = new System.Drawing.Size(1286, 486);
            this.userControl_registration1.TabIndex = 1;
            // 
            // userControl_Room1
            // 
            this.userControl_Room1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControl_Room1.BackColor = System.Drawing.Color.White;
            this.userControl_Room1.Location = new System.Drawing.Point(1, 0);
            this.userControl_Room1.Name = "userControl_Room1";
            this.userControl_Room1.Size = new System.Drawing.Size(1287, 486);
            this.userControl_Room1.TabIndex = 0;
            this.userControl_Room1.TabStop = false;
            this.userControl_Room1.Visible = false;
            this.userControl_Room1.Load += new System.EventHandler(this.userControl_Room1_Load);
            // 
            // bX
            // 
            this.bX.Image = ((System.Drawing.Image)(resources.GetObject("bX.Image")));
            this.bX.Location = new System.Drawing.Point(1276, 7);
            this.bX.Name = "bX";
            this.bX.Size = new System.Drawing.Size(28, 28);
            this.bX.TabIndex = 2;
            this.bX.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bX.UseVisualStyleBackColor = true;
            this.bX.Click += new System.EventHandler(this.bX_Click);
            // 
            // bM
            // 
            this.bM.BackColor = System.Drawing.Color.PaleGreen;
            this.bM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bM.Image = ((System.Drawing.Image)(resources.GetObject("bM.Image")));
            this.bM.Location = new System.Drawing.Point(1276, 38);
            this.bM.Margin = new System.Windows.Forms.Padding(0);
            this.bM.Name = "bM";
            this.bM.Size = new System.Drawing.Size(28, 29);
            this.bM.TabIndex = 3;
            this.bM.UseVisualStyleBackColor = false;
            this.bM.Click += new System.EventHandler(this.bM_Click);
            // 
            // userControl_Check_Out2
            // 
            this.userControl_Check_Out2.BackColor = System.Drawing.Color.White;
            this.userControl_Check_Out2.Location = new System.Drawing.Point(1, 1);
            this.userControl_Check_Out2.Name = "userControl_Check_Out2";
            this.userControl_Check_Out2.Size = new System.Drawing.Size(1286, 485);
            this.userControl_Check_Out2.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1313, 637);
            this.Controls.Add(this.bX);
            this.Controls.Add(this.bM);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonCOut;
        private System.Windows.Forms.Button buttonEnData;
        private System.Windows.Forms.Button buttonCData;
        private System.Windows.Forms.Button buttonRe;
        private System.Windows.Forms.Button bX;
        private System.Windows.Forms.Button bM;
        private user_control.UserControl_Room userControl_Room1;
        private user_control.UserControl_registration userControl_registration1;
        private user_control.UserControl_Check_Out userControl_Check_Out2;
        private user_control.UserControl_Check_Out userControl_Check_Out1;
        private user_control.UserControl_KData userControl_kData1;
        private user_control.UserControl_PData userControl_pData1;
    }
}