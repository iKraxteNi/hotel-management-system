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
    public partial class UserControl_Room : UserControl
    {
        functionsDB fn = new functionsDB();
        String query;

        public UserControl_Room()
        {
            InitializeComponent();
        }

        private void UserControl_Room_Load(object sender, EventArgs e) //pobieranie danych z bazy i wyświetlanie na tabeli w panelu add room 
        {
            query = "select * from rooms ";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AddRoom_Click(object sender, EventArgs e) // dodawanie pokojów , przesył do bazy , i inne 
        {
            if (textNrRoom.Text!=""&& textTypRoom.Text!=""&& textBedRoom.Text!=""&& textCenaRoom.Text!="")
            {
                String roomnr = textNrRoom.Text;
                String rooomtyp = textTypRoom.Text;
                String roombed = textBedRoom.Text;
                int rcena = int.Parse(textCenaRoom.Text);

                query = "insert into rooms (roomNr,roomTyp,bed,cena) values('"+roomnr+"','"+rooomtyp+"','"+roombed+"',"+rcena+")";
                fn.setData(query, "Dodano Pokój");

                UserControl_Room_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola! ", "Uwaga !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll() // czyszczenie textboxów 
        {
            textNrRoom.Clear();
            textTypRoom.SelectedIndex = -1;
            textBedRoom.SelectedIndex = -1;
            textCenaRoom.Clear();
            textBoxNrDelete.Clear();

        }

        private void UserControl_Room_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UserControl_Room_Enter(object sender, EventArgs e)
        {
            UserControl_Room_Load(this, null);
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            if (textBoxNrDelete.Text != "")
            {
                if (MessageBox.Show("Jesteś pewien?", "Potwierdź ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "update rooms set del = 'YES' where roomid ='" + textBoxNrDelete.Text + "'";
                    fn.setData(query, "Usunięto pokuj");

                    query = "select * from rooms ";
                    DataSet ds = fn.GetData(query);
                    dataGridView1.DataSource = ds.Tables[0];

                    clearAll();

                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                textBoxNrDelete.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            else { }
        }
    }
}
 