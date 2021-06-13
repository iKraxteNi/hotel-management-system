using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel__management_system_v1.user_control
{
    public partial class UserControl_KData : UserControl
    {
        functionsDB fn = new functionsDB();
        string query;
           
        public UserControl_KData()
        {
            InitializeComponent();
        }

        private void comboBoxDaneK_SelectedIndexChanged(object sender, EventArgs e) // wybieranie jakich klientów wyświetlić 
        {
            if (comboBoxDaneK.SelectedIndex==0) // all
            {
                query = "Select klient.kid,klient.kname,klient.mobilenr,klient.narodowosc,klient.plec,klient.ID,klient.adres,klient.checkin,klient.checkoutd,klient.checkout,klient.dateU,rooms.roomNr,rooms.roomTyp,rooms.bed,rooms.cena from klient inner join rooms on klient.roomid = rooms.roomid ";
                getDanek(query);
            }
            else if (comboBoxDaneK.SelectedIndex==1) // zamoldowani
            {
                query= "Select klient.kid,klient.kname,klient.mobilenr,klient.narodowosc,klient.plec,klient.ID,klient.adres,klient.checkin,klient.checkoutd,klient.checkout,klient.dateU,rooms.roomNr,rooms.roomTyp,rooms.bed,rooms.cena from klient inner join rooms on klient.roomid = rooms.roomid where checkoutd is null";
                getDanek(query);
            }
            else if (comboBoxDaneK.SelectedIndex == 2) // wymeldowani 
            {
                query = "Select klient.kid,klient.kname,klient.mobilenr,klient.narodowosc,klient.plec,klient.ID,klient.adres,klient.checkin,klient.checkoutd,klient.checkout,klient.dateU,rooms.roomNr,rooms.roomTyp,rooms.bed,rooms.cena from klient inner join rooms on klient.roomid = rooms.roomid where checkoutd is not null";
                getDanek(query);
            }
        }

        private void getDanek(string query) 
        {
            DataSet ds = fn.GetData(query);
            dataGridViewDaneK.DataSource = ds.Tables[0];
        }

        private void buttonExport_Click(object sender, EventArgs e) // export do excela 
        {
            if (comboBoxDaneK.Text !="")
            {
                 
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
               
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                 
                app.Visible = true;
                
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                
                worksheet.Name = "Exported from gridview";
                 
                for (int i = 1; i < dataGridViewDaneK.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridViewDaneK.Columns[i - 1].HeaderText;
                }
                 
                for (int i = 0; i < dataGridViewDaneK.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridViewDaneK.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewDaneK.Rows[i].Cells[j].Value.ToString();
                    }
                }

            }
            else
            {
                MessageBox.Show("Pole wyszukania nie moze być puste ");
            }
        }
    }
}
