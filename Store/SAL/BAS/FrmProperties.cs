﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Store.SAL.BAS
{
    public partial class FrmProperties : Form
    {
        public FrmProperties()
        {
            InitializeComponent();
        }

        private void FrmProperties_Load(object sender , EventArgs e)
        {
           
        }

        private void btnNew_Click(object sender , EventArgs e)
        {
            using (var frm=new FrmPropertiesActions())
            {
                frm.ShowDialog();
            }
        }
    }
}
