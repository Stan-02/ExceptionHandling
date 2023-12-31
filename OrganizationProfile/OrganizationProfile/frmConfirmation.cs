﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirmation : Form
    {
        
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void frmConfirmation_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblGender.Text = StudentInformationClass.SetGender;
            lblBirthday.Text = StudentInformationClass.SetBirthday;
            lblContactNo.Text = "+63" + StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Successfully!", "Message");
        }

        private void lblStudNo_Click(object sender, EventArgs e)
        {
            
        }
    }
}
