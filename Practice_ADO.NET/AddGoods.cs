﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_ADO.NET
{
    public partial class AddGoods : Form
    {
        int _lastid;
        public AddGoods(int lastid)
        {
            InitializeComponent();
            _lastid = lastid;
        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
           tb_id.Text = _lastid.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
