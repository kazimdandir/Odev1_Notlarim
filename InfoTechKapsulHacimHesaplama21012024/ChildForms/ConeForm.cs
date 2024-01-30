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
    public partial class ConeForm : Form
    {
        public ConeForm()
        {
            InitializeComponent();
        }

        List<Cone> cList = new List<Cone>();

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Cone c = new Cone();
                c.Id += 1;
                c.Radius = int.Parse(txt_radius.Text);
                c.Height = int.Parse(txt_height.Text);
                c.TotalArea = c.CalculateVolume(c.Radius, c.Height);
                cList.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cList;
        }
    }
}
