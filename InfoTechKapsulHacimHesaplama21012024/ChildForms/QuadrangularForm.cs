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
    public partial class QuadrangularForm : Form
    {
        public QuadrangularForm()
        {
            InitializeComponent();
        }

        List<Quadrangular> qList = new List<Quadrangular>();

        int _id = 0;

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            _id++;

            try
            {
                Quadrangular q = new Quadrangular();
                q.Id = _id;
                q.ShortSide = int.Parse(txt_shortSide.Text);
                q.LongSide = int.Parse(txt_longSide.Text);
                q.Height = int.Parse(txt_height.Text);
                q.TotalArea = q.CalculateVolume(q.ShortSide, q.LongSide, q.Height);
                qList.Add(q);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = qList;
        }

        private void QuadrangularForm_Load(object sender, EventArgs e)
        {

        }
    }
}
