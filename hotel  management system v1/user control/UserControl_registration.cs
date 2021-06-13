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
    public partial class UserControl_registration : UserControl
    {

        functionsDB fn = new functionsDB();
        String query;

        public UserControl_registration()
        {
            InitializeComponent();
        }

        public void setComboBox(String query, ComboBox combo) // odczyt i spr dostępnych nr pokoji 
        {
            SqlDataReader sdr = fn.getForComboBox(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void UserControl_registration_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTypRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNrroom.SelectedIndex=-1;
            textBoxCenaR.Clear();
            query = "select roomNr from rooms where bed = '" + comboBoxBedRoom.Text + "' and roomTyp = '" + comboBoxTypRoom.Text + "' and booked = 'NO' and del = 'NO'";
            setComboBox(query, comboBoxNrroom);
        }

        private void comboBoxBedRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNrroom.SelectedIndex =-1;
            textBoxCenaR.Clear();
            query = "select roomNr from rooms where bed = '" + comboBoxBedRoom.Text + "' and roomTyp = '" + comboBoxTypRoom.Text + "' and booked = 'NO' and del = 'NO' " ;
            setComboBox(query, comboBoxNrroom);



        } int rid;

        private void comboBoxNrroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select cena,roomid from rooms where roomNr = '" + comboBoxNrroom.Text + "' ";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
               textBoxCenaR.Text = ds.Tables[0].Rows[0][0].ToString(); 
            }
            else
            {
                textBoxCenaR.Clear();
            }

            if (ds.Tables[0].Rows.Count > 0)
            {
               rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
            }
            

        }

        private void buttonRejestra_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxNrfon.Text != "" && textBoxIDd.Text != "" && textBoxNaro.Text != "" && textBoxAdres.Text != "" && comboBoxPlec.Text != "" && dateTimePickerDZ.Text != "" && dateTimePickerDU.Text != "" && textBoxCenaR.Text != "")
            {
                String name = textBoxName.Text;
                int mobile = int.Parse(textBoxNrfon.Text);
                String national = textBoxNaro.Text;
                String gender = comboBoxPlec.Text;
                String id = textBoxIDd.Text;
                String adress = textBoxAdres.Text;
                String checkin = dateTimePickerDZ.Text;
                String datau = dateTimePickerDU.Text;

                query = "insert into klient (kname,mobilenr,narodowosc,plec,ID,adres,checkin,dateU,roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + id + "','" + adress + "','" + checkin + "','" + datau + "'," + rid + ") update rooms set booked ='YES' where roomNr = '" + comboBoxNrroom.Text + "' ";
                fn.setData(query, "Pokuj nr" + comboBoxNrroom.Text + " Zarezerwowany!");
                clearAll();
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola!", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            textBoxName.Clear();
            textBoxNrfon.Clear();
            textBoxNaro.Clear();
            comboBoxPlec.SelectedIndex = -1;
            textBoxIDd.Clear();
            textBoxAdres.Clear();
            dateTimePickerDU.ResetText();
            dateTimePickerDZ.ResetText();
            comboBoxBedRoom.SelectedIndex = -1;
            comboBoxTypRoom.SelectedIndex = -1;
            comboBoxNrroom.SelectedIndex = -1;
            textBoxCenaR.Clear();

        }

        private void UserControl_registration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

       

        private void textBoxNrfon_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxNrfon.Text, "  ^ [0-9]"))
            {
                textBoxNrfon.Text = "";
            }

        }

        private void textBoxNrfon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

}
