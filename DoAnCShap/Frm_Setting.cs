﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCShap
{
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();

        private void checkBoxDo_CheckedChanged(object sender, EventArgs e)
        {
            LoadMau();
        }
        public void LoadMau()
        {
            if(checkBoxDo.Checked==true)
            {
                frm.panelTop.BackColor = Color.Red;
            }    
        }    

        private void Frm_Setting_Load(object sender, EventArgs e)
        {

        }
    }
}
