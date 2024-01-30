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
    public partial class SphereForm : Form
    {
        public SphereForm()
        {
            InitializeComponent();
        }

        List<Sphere> sList = new List<Sphere>();

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Sphere s = new Sphere();
                s.Id += 1;
                s.Radius = int.Parse(txt_radius.Text);
                s.TotalArea = s.CalculateVolume(s.Radius);
                sList.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = sList;
        }

        private void SphereForm_Load(object sender, EventArgs e)
        {

        }
    }
}
