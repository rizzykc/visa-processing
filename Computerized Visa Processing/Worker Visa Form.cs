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
    public partial class Worker_Visa_Form : Form
    {
        string constStr, sql;
        MySqlCommand olecom;

        public Worker_Visa_Form()
        {
            InitializeComponent();
        }

        private void savedata()
        {
            sql = "INSERT into worker VALUES(S_no,?ePptNo,?First_Name,?Middle_Name,?Surname,?Sex,?D.O.B,?State_of_Origin,?Place_of_Birth,?Nationality,?Marital_Status,?Duration_of_Stay,?Mode_of_Transport,?Validity,?Next_of_Kin,?Next_of_Kin_No,?Signature)";
            MySqlConnection mycon = new MySqlConnection(constStr);
            olecom = new MySqlCommand(sql, mycon);

            olecom.Parameters.Add(new MySqlParameter("ePptNo", MySqlDbType.VarChar, 20));
            olecom.Parameters["ePptNo"].Value = textBox1.Text;

            olecom.Parameters.Add(new MySqlParameter("First_Name", MySqlDbType.VarChar, 20));
            olecom.Parameters["First_Name"].Value = textBox6.Text;

            olecom.Parameters.Add(new MySqlParameter("Middle_Name", MySqlDbType.VarChar, 20));
            olecom.Parameters["Middle_Name"].Value = textBox5.Text;

            olecom.Parameters.Add(new MySqlParameter("Surname", MySqlDbType.VarChar, 20));
            olecom.Parameters["Surname"].Value = textBox4.Text;

            olecom.Parameters.Add(new MySqlParameter("Sex", MySqlDbType.VarChar, 20));
            olecom.Parameters["Sex"].Value = comboBox3.Text;

            olecom.Parameters.Add(new MySqlParameter("D.O.B", MySqlDbType.VarChar, 20));
            olecom.Parameters["D.O.B"].Value = textBox2.Text;

            olecom.Parameters.Add(new MySqlParameter("State_of_Origin", MySqlDbType.VarChar, 20));
            olecom.Parameters["State_of_Origin"].Value = textBox7.Text;

            olecom.Parameters.Add(new MySqlParameter("Place_of_Birth", MySqlDbType.VarChar, 20));
            olecom.Parameters["Place_of_Birth"].Value = textBox8.Text;

            olecom.Parameters.Add(new MySqlParameter("Nationality", MySqlDbType.VarChar, 20));
            olecom.Parameters["Nationality"].Value = textBox16.Text;

            olecom.Parameters.Add(new MySqlParameter("Marital_Status", MySqlDbType.VarChar, 20));
            olecom.Parameters["Marital_Status"].Value = comboBox1.Text;

            olecom.Parameters.Add(new MySqlParameter("Duration_of_Stay", MySqlDbType.VarChar, 20));
            olecom.Parameters["Duration_of_Stay"].Value = textBox10.Text;

            olecom.Parameters.Add(new MySqlParameter("Mode_of_Transport", MySqlDbType.VarChar, 20));
            olecom.Parameters["Mode_of_Transport"].Value = textBox11.Text;

            olecom.Parameters.Add(new MySqlParameter("Validity", MySqlDbType.VarChar, 20));
            olecom.Parameters["Validity"].Value = comboBox2.Text;

            olecom.Parameters.Add(new MySqlParameter("Next_of_Kin", MySqlDbType.VarChar, 20));
            olecom.Parameters["Next_of_Kin"].Value = textBox15.Text;

            olecom.Parameters.Add(new MySqlParameter("Next_of_Kin_No", MySqlDbType.VarChar, 20));
            olecom.Parameters["Next_of_Kin_No"].Value = textBox14.Text;

            olecom.Parameters.Add(new MySqlParameter("Signature", MySqlDbType.VarChar, 20));
            olecom.Parameters["Signature"].Value = textBox13.Text;


            try
            {
                olecom.Connection.Open();
            }
            catch (MySqlException ne)
            {
                MessageBox.Show(ne.Message, "Unable to link to database"); return;
            }

            try
            {
                olecom.ExecuteNonQuery();
                MessageBox.Show("Record has been saved successfully"); return;
            }
            catch (MySqlException ne)
            {
                MessageBox.Show(ne.Message, "Error"); return;

            }
        }

        private void mainData()
        {
            string b, c, d, aa, bb, cc, dd, ee, co, combo, comb1, comb2, ff, gg, hh, ii;

            b = textBox8.Text;
            c = textBox6.Text;
            d = textBox5.Text;
            aa = textBox4.Text;
            combo = comboBox3.Text;
            cc = textBox2.Text;
            dd = textBox7.Text;
            ee = textBox1.Text;
            co = textBox16.Text;
            comb1 = comboBox1.Text;
            bb = textBox10.Text;
            ff = textBox11.Text;
            comb2 = comboBox2.Text;
            gg = textBox15.Text;
            hh = textBox14.Text;
            ii = textBox13.Text;

            if (textBox1.Text != "")
            {
                if (textBox6.Text != "")
                {
                    if (textBox5.Text != "")
                    {
                        if (textBox4.Text != "")
                        {
                            if (comboBox3.SelectedIndex != -1)
                            {
                                if (textBox2.Text != "")
                                {
                                    if (textBox7.Text != "")
                                    {
                                        if (textBox8.Text != "")
                                        {
                                            if (textBox16.Text != "")
                                            {
                                                if (comboBox1.SelectedIndex != -1)
                                                {
                                                    if (textBox10.Text != "")
                                                    {
                                                        if (textBox11.Text != "")
                                                        {
                                                            if (comboBox2.SelectedIndex != -1)
                                                            {
                                                                if (textBox15.Text != "")
                                                                {
                                                                    if (textBox14.Text != "")
                                                                    {
                                                                        if (textBox13.Text != "")
                                                                        {
                                                                            savedata();
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("Please sign", "Business Visa"); textBox13.Focus();
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Enter Next of Kin Number", "Business Visa"); textBox14.Focus();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Enter Name of Next of Kin", "Business Visa"); textBox15.Focus();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Select no of years to expiration", "Business Visa"); comboBox2.Focus();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Enter mode of transport", "Business Visa"); textBox11.Focus();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Enter duration of stay", "Business Visa"); textBox10.Focus();
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Select marital Status", "Business Visa"); comboBox1.Focus();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Enter Nationality please", "Business Visa"); textBox16.Focus();
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter place of Birth", "Business Visa"); textBox1.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter State of Origin", "Business Visa"); textBox7.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter Date of Birth", "Business Visa"); textBox2.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Select Sex", "Business Visa"); comboBox3.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter Surname please", "Business Visa"); textBox4.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Middlename please", "Business Visa"); textBox5.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter First name please", "Business Visa"); textBox6.Focus();
                }
            }
            else
            {
                MessageBox.Show("Enter Passport Number", "Business Visa"); textBox8.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_Menu now = new Main_Menu();
            now.Show();
            this.Hide();
        }

        private void clear()
        {
            textBox1.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainData();
        }

        private void Worker_Visa_Form_Load(object sender, EventArgs e)
        {
            constStr = "SERVER=localhost;DATABASE=visadb;UID=root;PASSWORD='';";
        }
    }
}
