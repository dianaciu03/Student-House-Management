﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Housing_Project
{
    public partial class Supervisor : Form
    {
        public Supervisor()
        {
            InitializeComponent();
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
            //dt.Columns.AddRange(new DataColumn[3] { new DataColumn("Id", typeof(int)),
            //            new DataColumn("Name", typeof(string)),
            //            new DataColumn("Country",typeof(string)) });
            //dt.Rows.Add(1, "John Hammond", "United States");
            //dt.Rows.Add(2, "Mudassar Khan", "India");
            //dt.Rows.Add(3, "Suzanne Mathews", "France");
            //dt.Rows.Add(4, "Robert Schidner", "Russia");
            //this.dataGridView1.DataSource = dt;
            //this.dataGridView1.AllowUserToAddRows = false;
        }

        private void report_problem_Click(object sender, EventArgs e)
        {
            //try

            //{

            //    String str = "";

            //    String query = "select * from data";

            //    SqlConnection con = new SqlConnection(str);

            //    SqlCommand cmd = new SqlCommand(query, con);

            //    con.Open();

            //    DataSet ds = new DataSet();

            //    MessageBox.Show("connect with sql server");

            //    con.Close();

            //}

            //catch (Exception es)

            //{

            //    MessageBox.Show(es.Message);



            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    //Table start.
        //    string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

        //    //Adding HeaderRow.
        //    html += "<tr>";
        //    foreach (DataGridViewColumn column in dataGridView1.Columns)
        //    {
        //        html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
        //    }
        //    html += "</tr>";

        //    //Adding DataRow.
        //    foreach (DataGridViewRow row in dataGridView1.Rows)
        //    {
        //        html += "<tr>";
        //        foreach (DataGridViewCell cell in row.Cells)
        //        {
        //            html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
        //        }
        //        html += "</tr>";
        //    }

        //    //Table end.
        //    html += "</table>";

        //    File.WriteAllText(@"E:\Files\DataGridView.htm", html);
        }
    }
}
