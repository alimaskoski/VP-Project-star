﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class startForm : Form
    {
        public static string playerName;
        public static string category;
        public startForm()
        {
            InitializeComponent();
            this.ActiveControl = txtName; 
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            playerName = txtName.Text;
            if (btnStart.Text == "History")
            {
                category = "history";
                this.Hide();
                var myForm = new Form1();
                myForm.ShowDialog();
                this.Close();
            }
            else if (txtName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your name!");
                this.ActiveControl = txtName;
            }
            else
            {

                lblHeader.Text = "CATEGORY";
                lblName.Hide();
                txtName.Hide();
                btnStart.Text = "History";
                btnHighscore.Text = "Geography";
                btnExit.Text = "Trivia";
                
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Trivia")
            {
                category = "trivia";
                this.Hide();
                var myForm = new Form1();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void btnHighscore_Click(object sender, EventArgs e)
        {
            if(btnHighscore.Text == "Geography")
            {
                category = "geography";
                this.Hide();
                var myForm = new Form1();
                myForm.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                var myForm = new highscoreForm();
                myForm.ShowDialog();
                this.Close();
            }
        }
    }
}
