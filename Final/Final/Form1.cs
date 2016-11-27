﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using Business;
using DataTransfer;
using DevExpress.XtraTreeList.Nodes;

namespace Final
{
    public partial class Form1 : DevComponents.DotNetBar.RibbonForm
    {
        public Form1()
        {
            this.InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			RoomBusiness.CreateTreeRoom(treeView1);
		}
	}
}
