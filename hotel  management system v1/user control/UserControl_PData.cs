using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel__management_system_v1.user_control
{
    public partial class UserControl_PData : UserControl
    {
        functionsDB fn = new functionsDB();
        string query;
        public UserControl_PData()
        {
            InitializeComponent();
        }

        private void UserControl_PData_Load(object sender, EventArgs e)
        {
            getMaxID();

           

        }
        public void getMaxID()
        {
            query = "select max(pid) from pracownik"; // automatycznie pobierz największe dostępne pID przy załadowaniu tego okna, tej zakładki
            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 nr = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelID.Text = (nr + 1).ToString();

            }
            else
            {
                labelID.Text = 1.ToString();
            }

        }

        private void btdp_Click(object sender, EventArgs e)
        {
            if (textBoxPImie.Text != "" && textBoxPnrf.Text != "" && comboBoxPp.Text != "" && textBoxPemail.Text != "" && textBoxPL.Text !="" && textBoxPH.Text != "" && textBoxPHp.Text != "")
            {
                if (textBoxPH.Text == textBoxPHp.Text)
                {
                    String name = textBoxPImie.Text;
                    Int64 moblie = Int64.Parse(textBoxPnrf.Text);
                    String gender = comboBoxPp.Text;
                    String emali = textBoxPemail.Text;
                    String login = textBoxPL.Text;
                    String pass = textBoxPH.Text;

                    query = "insert into pracownik ( pname,  nrmobile, gender, emailp, loginp, haslop ) values ('" + name + "'," + moblie + ",'" + gender + "','" + emali + "','" + login + "','" + pass + "')";
                    fn.setData(query, "Zarejestrowano użytkownika");

                    clearAll();
                    getMaxID();
                }
                else
                {
                    MessageBox.Show("Podane hasła nie są takie same.");
                }
            }
            else
            {
                MessageBox.Show("Nie wypełniono wszystkich danych.");
            }

        }

        public void clearAll()
        {
            textBoxPImie.Clear();
            textBoxPnrf.Clear();
            comboBoxPp.SelectedIndex = -1;
            textBoxPemail.Clear();
            textBoxPL.Clear();
            textBoxPH.Clear();
            textBoxPHp.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)  // tabelka pracownika dane do tabelki-
        {
            if (tabControl1.SelectedIndex == 1)
            {
                query = "select * from pracownik ";
                DataSet ds = fn.GetData(query);
                dataGridViewDp.DataSource = ds.Tables[0];
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                query = "select * from pracownik ";
                DataSet ds = fn.GetData(query);
                dataGridViewDPd.DataSource = ds.Tables[0];
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) // p usuwanie 
        {
            if(textBoxSID.Text != "")
            {
                if (MessageBox.Show("Jesteś pewien?", "Potwierdź ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from pracownik where pid = " + textBoxSID.Text + "";
                 fn.setData(query, "Usunięto pracownika");

                    query = "select * from pracownik ";
                    DataSet ds = fn.GetData(query);
                    dataGridViewDPd.DataSource = ds.Tables[0];

                }
                
            }
            
        }

        private void UserControl_PData_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                app.Visible = true;

                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Exported from gridview";

                for (int i = 1; i < dataGridViewDp.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewDp.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridViewDp.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewDp.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewDp.Rows[i].Cells[j].Value.ToString();
                    }
                }

            
        }

        private void dataGridViewDPd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDPd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxSID.Text = dataGridViewDPd.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void textBoxPnrf_TextChanged(object sender, EventArgs e)
        {
        
                if (System.Text.RegularExpressions.Regex.IsMatch(textBoxPnrf.Text, "  ^ [0-9]"))
                {
                    textBoxPnrf.Text = "";
                }
        }

        private void textBoxPnrf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
