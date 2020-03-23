/*
 * SuperTech.INC Restaurant Automation Application
 * Prototype v0.01
 * Last Edited - 3/22/20 by Zach Gherman
 * 
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //for the log-in database

namespace REST_AUTOMN_Proto_v0._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Exit_button.Text = "Exit";
        }

        // Exit button with a dialog message box to ensure user wants to exit.
        private void button1_Click(object sender, EventArgs e)
        {
            // example message box to get user feedback on next course of action.
            if (MessageBox.Show("Exit without saving", "Are you sure you want to exit without saving?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            /*Alternate Example using the same logic (and rearranging of code).
             * 
             * DialogResult dr = MessageBox.Show("Are you sure you want to exit without saving?", "Exit without saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             * if (dr == DialogResult.Yes)
             *     this.Close();
             * 
             */

        }

        // This is the log-in button
        // NOTE: we can break the log-in button into two separate log-ins. One for waitstaff and one for the kitchen
        //       to differentiate the different users and what they will see/access. Maybe. Food for thought.
        private void button1_Click_1(object sender, EventArgs e)
        {
            // '@' used in line below so we don't have to use '\\' for the pathways
            // Resources:
            //https://www.youtube.com/watch?v=tcmmCcMs8yU -- this video covers the logic and code below
            //https://www.youtube.com/watch?v=evLC28i1F-g -- this one is not as useful but does show how to set-up a database / connections

            // TODO: create a database of passwords not centralized on my personal PC.
            // NOTE: THIS WILL NOT WORK ON YOUR MACHINES UNLESS YOU SET UP A DATABASE ON YOUR MACHINE, just change the data source to wherever your database of passwords is saved.
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zgher\Desktop\School work\Homework Assignments\CPTS322\Restaurant Automation\REST_AUTOMN_Proto_v0.01\REST_AUTOMN_Proto_v0.01\PASSWORDS.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter adp = new SqlDataAdapter("Select Count(*) from PassTable where Password='" + textBox1.Text + "'", con);
            DataTable pdt = new DataTable();
            adp.Fill(pdt);

            // can be thrown into a loop to check multiple different passwords.
            if (pdt.Rows[0][0].ToString() == "1")
            { 
                this.Hide(); // Hides the log-in screen as that is our initial object.

                REST_AUTMN_OVRVW raov = new REST_AUTMN_OVRVW();
                raov.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password.");
            }
        }
    }
}
