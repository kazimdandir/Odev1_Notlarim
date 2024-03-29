﻿using InfoTechKapsulHacimHesaplama21012024.Shapes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTechKapsulHacimHesaplama21012024.ChildForms
{
    public partial class CubeForm : Form
    {
        public CubeForm()
        {
            InitializeComponent();
        }

        List<Cube> cList = new List<Cube>();

        int _id = 0;

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            _id++;

            try
            {
                Cube c = new Cube();
                c.Id = _id;
                c.Side = int.Parse(txt_side.Text);
                c.TotalArea = c.CalculateVolume(c.Side);
                cList.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cList;
        }

        private void CubeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
