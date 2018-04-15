﻿using IS_HeMart.ServiceManagers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_HeMart.Forms
{
    public partial class UkonyForm : BaseForm
    {
		private DataManager _dataManager;
        public UkonyForm()
        {
            InitializeComponent();
			_dataManager = new DataManager();
			zoznamUkonovBindingSource.DataSource = _dataManager.GetUkony().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

		private void UkonyForm_Load(object sender, EventArgs e)
		{
			var data = (new DataManager()).GetZoznamUkonov().ToList();
			dataGridView1.DataSource = data;
		}
	}
}
