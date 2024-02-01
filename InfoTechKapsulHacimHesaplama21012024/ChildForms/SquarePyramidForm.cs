using InfoTechKapsulHacimHesaplama21012024.Shapes;
using System;
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
    public partial class SquarePyramidForm : Form
    {
        public SquarePyramidForm()
        {
            InitializeComponent();
        }

        List<SquarePyramid> sqlist = new List<SquarePyramid>();
        int _id = 0;

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            _id++;

            try
            {
                SquarePyramid sp = new SquarePyramid();
                sp.Id += _id;
                sp.Side = int.Parse(txt_side.Text);
                sp.Height = int.Parse(txt_height.Text);
                sp.TotalArea = sp.CalculateVolume(sp.Side, sp.Height);
                sqlist.Add(sp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sqlist;
        }

        private void SquarePyramidForm_Load(object sender, EventArgs e)
        {

        }
    }
}
