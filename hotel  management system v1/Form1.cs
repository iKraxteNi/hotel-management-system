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
    public partial class Form1 : Form
    {
        functionsDB fn = new functionsDB();
        String query;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e) // logowanie spr danych logownia 
        {
            query = "select loginp, haslop from pracownik where loginp = '"+textBoxLogin.Text+"' and haslop = '" + textBoxPass.Text + "'";
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count !=0)
            {

                labelWronePass.Visible = false;
                Dashboard dasb = new Dashboard();
                this.Hide();
                dasb.Show();
            }
            else
            {
                labelWronePass.Visible = true;
                textBoxLogin.Clear();
                textBoxPass.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
