using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Computerized_Visa_Processing
{
    public partial class searchJournalist : Form
    {
        string sql, constr;
        MySqlCommand olecom;
        MySqlDataAdapter da;
        DataTable tbl;
        int rowpos = 0;

        public searchJournalist()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Main_Menu now = new Main_Menu();
            now.Show();
            this.Hide();
        }

        private void searchUser()
        {
            try
            {
                string strCommand;
                tbl = new DataTable();
                string strName = (string)textBox2.Text;
                string namekey = "'" + strName + "'";
                strCommand = "SELECT * FROM journalist WHERE ePptNo = '" + strName + "'";
                string commandString = strCommand;
                MySqlConnection mycon = new MySqlConnection(constr);
                da = new MySqlDataAdapter(commandString, mycon);
                MySqlCommandBuilder cmbd = new MySqlCommandBuilder(da);
                da.Fill(tbl);
                display();
            }
            catch
            {
                MessageBox.Show("Error", "Visa Processing", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox2.Focus();
                return;
            }
        }

        private void display()
        {
            try
            {
                if (tbl.Rows.Count == 0)
                {
                    clearData();
                    if (tbl.Rows.Count == 0)
                    {
                        MessageBox.Show("Records don't exist");
                    }
                }

                textBox6.Text = tbl.Rows[rowpos]["First_Name"].ToString();
                textBox5.Text = tbl.Rows[rowpos]["Middle_Name"].ToString();
                textBox3.Text = tbl.Rows[rowpos]["Surname"].ToString();
                comboBox3.Text = tbl.Rows[rowpos]["Sex"].ToString();
                textBox9.Text = tbl.Rows[rowpos]["D.O.B"].ToString();
                textBox7.Text = tbl.Rows[rowpos]["State_of_Origin"].ToString();
                textBox8.Text = tbl.Rows[rowpos]["Place_of_Birth"].ToString();
                textBox16.Text = tbl.Rows[rowpos]["Nationality"].ToString();
                comboBox1.Text = tbl.Rows[rowpos]["Marital_Status"].ToString();
                textBox10.Text = tbl.Rows[rowpos]["Duration_of_Stay"].ToString();
                textBox11.Text = tbl.Rows[rowpos]["Mode_of_Transport"].ToString();
                comboBox2.Text = tbl.Rows[rowpos]["Validity"].ToString();
                textBox15.Text = tbl.Rows[rowpos]["Employer_Name"].ToString();
                textBox14.Text = tbl.Rows[rowpos]["Employer_No"].ToString();
                textBox13.Text = tbl.Rows[rowpos]["Employer_Address"].ToString();
                textBox4.Text = tbl.Rows[rowpos]["Signature"].ToString();

            }

            catch
            {

            }
        }

        private void updateUser()
        {
            try
            {
                if (tbl.Rows.Count != 0)
                {
                    tbl.Rows[rowpos]["First_Name"] = textBox6.Text;
                    tbl.Rows[rowpos]["Middle_Name"] = textBox5.Text;
                    tbl.Rows[rowpos]["Surname"] = textBox3.Text;
                    tbl.Rows[rowpos]["Sex"] = comboBox3.Text;
                    tbl.Rows[rowpos]["D.O.B"] = textBox9.Text;
                    tbl.Rows[rowpos]["State_of_Origin"] = textBox7.Text;
                    tbl.Rows[rowpos]["Place_of_Birth"] = textBox8.Text;
                    tbl.Rows[rowpos]["Nationality"] = textBox16.Text;
                    tbl.Rows[rowpos]["Marital_Status"] = comboBox1.SelectedIndex;
                    tbl.Rows[rowpos]["Duration_of_Stay"] = textBox10.Text;
                    tbl.Rows[rowpos]["Mode_of_Transport"] = textBox11.Text;
                    tbl.Rows[rowpos]["Validity"] = comboBox2.Text;
                    tbl.Rows[rowpos]["Employer_Name"] = textBox15.Text;
                    tbl.Rows[rowpos]["Employer_No"] = textBox14.Text;
                    tbl.Rows[rowpos]["Employer_Address"] = textBox13.Text;
                    tbl.Rows[rowpos]["Signature"] = textBox4.Text;


                    da.Update(tbl);

                    MessageBox.Show("Update Successful", "Visa Processing", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
            }
        }

        private void delRecord()
        {
            try
            {
                if (textBox6.Text != "" && textBox5.Text != "")
                {
                    if (tbl.Rows.Count != 0)
                    {
                        tbl.Rows[rowpos].Delete();
                        da.Update(tbl);
                        rowpos = 0;
                        clearData();
                        MessageBox.Show("Record has been deleted successfully..."); textBox2.Focus();
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("Please search for record before you can delete");
                }
            }
            catch
            {
            }
        }

        private void clearData()
        {
            textBox3.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void searchJournalist_Load(object sender, EventArgs e)
        {
            constr = "SERVER=localhost;DATABASE=visadb;UID=root;PASSWORD='';";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            updateUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delRecord();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            searchUser();
        }
    }
}
