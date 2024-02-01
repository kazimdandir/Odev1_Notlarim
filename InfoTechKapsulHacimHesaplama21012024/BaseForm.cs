using InfoTechKapsulHacimHesaplama21012024.ChildForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoTechKapsulHacimHesaplama21012024
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        #region Quadrangular

        private void dikdörtgenPrizmaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            QuadrangularForm child = new QuadrangularForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new QuadrangularForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        private void pictBox_quadrangular_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            QuadrangularForm child = new QuadrangularForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new QuadrangularForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        #endregion

        #region Cube

        private void küpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            CubeForm child = new CubeForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new CubeForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        private void pictBox_cube_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            CubeForm child = new CubeForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new CubeForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        #endregion

        #region Sphere

        private void küreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            SphereForm child = new SphereForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new SphereForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        private void pictBox_sphere_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            SphereForm child = new SphereForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new SphereForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        #endregion

        #region Cylinder

        private void silindirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            CylinderForm child = new CylinderForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new CylinderForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }
        private void pictBox_cylinder_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            CylinderForm child = new CylinderForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new CylinderForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        #endregion

        #region Cone

        private void koniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            ConeForm child = new ConeForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new ConeForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        private void pictBox_cone_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            ConeForm child = new ConeForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new ConeForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }


        #endregion

        #region SquarePyramid

        private void karePiramitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            SquarePyramidForm child = new SquarePyramidForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new SquarePyramidForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }
        private void pictBox_squarePyramid_Click(object sender, EventArgs e)
        {
            pictBox_quadrangular.Hide();
            pictBox_cone.Hide();
            pictBox_cylinder.Hide();
            pictBox_sphere.Hide();
            pictBox_squarePyramid.Hide();
            pictBox_cube.Hide();

            SquarePyramidForm child = new SquarePyramidForm();
            foreach (Form mdiChild in this.MdiChildren)
            {
                if (mdiChild.Text == child.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            //Form child = new SquarePyramidForm();
            //OpenForm(ref child);

            child.MdiParent = this;
            child.Show();
        }

        #endregion

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //void OpenForm(ref Form form)
        //{
        //    Form f = form;
        //    foreach (Form mdiChild in this.MdiChildren)
        //    {
        //        if (mdiChild.Text == f.Text)
        //        {
        //            mdiChild.BringToFront();
        //            return;
        //        }
        //    }
        //    f.MdiParent = this;
        //    f.Show();
        //}

        private void yatayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void dikeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void üstÜsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
