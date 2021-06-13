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
    public partial class UserControl_Check_Out : UserControl
    {
        functionsDB fn = new functionsDB();
        String query;

        public UserControl_Check_Out()
        {
            InitializeComponent();
        }

        private void UserControl_Check_Out_Load(object sender, EventArgs e) // pobieranie danych inner join do grafu w check out
        {
            query = "Select klient.kid,klient.kname,klient.mobilenr,klient.narodowosc,klient.plec,klient.ID,klient.adres,klient.checkin,klient.dateU,rooms.roomNr,rooms.roomTyp,rooms.bed,rooms.cena from klient inner join rooms on klient.roomid = rooms.roomid where checkout = 'NO'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0]; 

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            
            query = "Select klient.kid,klient.kname,klient.mobilenr,klient.narodowosc,klient.plec,klient.ID,klient.adres,klient.checkin,klient.dateU,rooms.roomNr,rooms.roomTyp,rooms.bed,rooms.cena from klient inner join rooms on klient.roomid = rooms.roomid where kname like'"+ textBoxName.Text +"%' and checkout = 'NO'";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxCName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxRCOut.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                 id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }
        }

        private void buttonRCOut_Click(object sender, EventArgs e)
        {
            if (textBoxCName.Text != "")
            {
                if (MessageBox.Show("Jesteś pewien?", "Potwierdzenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = dateTimePickerRCOut.Text;
                    query = "update klient set checkout = 'YES', checkoutd ='" + cdate + "' where kid = '"+id+"' update rooms set booked = 'NO' where roomNr ='"+textBoxRCOut.Text+"'";
                    fn.setData(query, "Wymeldowano.");
                    UserControl_Check_Out_Load(this, null);
                    clearAll();
                }  
            }
            else
            {
                MessageBox.Show("Nie wybrano klienta.", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            textBoxCName.Clear();
            textBoxName.Clear();
            textBoxRCOut.Clear();
            dateTimePickerRCOut.ResetText();
        }

        private void UserControl_Check_Out_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void textBoxCName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
