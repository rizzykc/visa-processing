﻿using System;
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
    public partial class viewStudent : Form
    {
        public viewStudent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_Menu now = new Main_Menu();
            now.Show();
            this.Hide();
        }

        private void loadRecord()
        {
            string strCommand;
            strCommand = "SELECT * from student order by S_No";
            string connectionString = "SERVER=localhost;DATABASE=visadb;UID=root;PASSWORD='';";
            string commandString = strCommand;
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(commandString, connectionString);
            DataSet DataSet = new DataSet();
            DataAdapter.Fill(DataSet, "student");
            dataGridView1.DataSource = DataSet.Tables["student"].DefaultView;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadRecord();
        }
    }
}
