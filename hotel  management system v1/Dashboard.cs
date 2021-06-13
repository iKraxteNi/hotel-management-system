using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel__management_system_v1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl_Room1.Visible = true;
            userControl_Room1.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userControl_Room1.Visible = false;
            userControl_registration1.Visible = false;
            userControl_Check_Out1.Visible = false;
            userControl_kData1.Visible = false;
            userControl_pData1.Visible = false;


        }

        private void bM_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userControl_Room1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRe_Click(object sender, EventArgs e)
        {
            userControl_registration1.Visible = true;
            userControl_registration1.BringToFront();
        }

        private void buttonCOut_Click(object sender, EventArgs e)
        {
            userControl_Check_Out1.Visible = true;
            userControl_Check_Out1.BringToFront();
        }

        private void buttonCData_Click(object sender, EventArgs e)
        {
            userControl_kData1.Visible = true;
            userControl_kData1.BringToFront();
        }

        private void buttonEnData_Click(object sender, EventArgs e)
        {
            userControl_pData1.Visible = true;
            userControl_pData1.BringToFront();
        }
        int mouseX = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseY = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseinX = 0;
        /// <summary>
        /// Parametr zawierający pozycję kursora.
        /// </summary>
        int mouseinY = 0;
        /// <summary>
        /// Bool zawierający dane o tym czy przycisk myszy jest nacisnięty.
        /// </summary>
        bool mouseDown;
        /// <summary>
        /// Funkcja służaca do przesuwania całym oknem w przypadku przesuwania panelu.
        /// </summary>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - mouseinX;
                mouseY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
        /// <summary>
        /// Funckja w przypadku zaprzestania przesuwania panelu.
        /// </summary>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        /// <summary>
        /// Funkcja w przypadku rozpoczęcia przesuwnaia panelu.
        /// </summary>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
    }
}
