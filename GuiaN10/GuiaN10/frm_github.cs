﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiaN10
{
    public partial class frm_github : Form
    {
        public frm_github()
        {
            InitializeComponent();
        }

        private void lbl_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/joselegui");
        }
    }
}
