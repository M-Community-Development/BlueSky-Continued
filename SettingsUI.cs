﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Threading;
using System.Windows;
using System.IO;
using System.Diagnostics;
using System.ServiceProcess;
using System.Net;
using System.Windows.Threading;
using BlueSkyNew.API;

namespace BlueSkyNew
{
    public partial class SettingsUI : Form
    {
        public SettingsUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rAPI.installmc(progressBar1, label5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rAPI.uninstallmc(progressBar1, label5);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            rAPI.desvc();
        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            /*
            APITests apitest = new APITests();
            apitest.Show();
            */
            rAPI.notice("API Testing Menu is disabled!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rAPI.ws();
        }
    }
}
