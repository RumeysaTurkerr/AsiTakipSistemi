using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AşıTakipSistemi
{
    public partial class SekreterForm : Form
    {
        public SekreterForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 68;

            bool durum = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }


        private void cocukEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CocukEkleForm());

        }

        private void doktorEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new DoktorEkleForm());
        }

        private void yöneticiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SekreterEkleForm());
        }

        private void asiEkleToolStrip_Click(object sender, EventArgs e)
        {
            ChildForm(new AsiTakvimiEkleForm());
        }

        private void çıkışToolStrip_Click(object sender, EventArgs e)
        {
            GirişForm cikis = new GirişForm();
            cikis.Show();
            this.Close();
        }

        private void çocukGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CocukGuncelleSilForm());
        }

        private void doktorGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new DoktorGuncelleSilForm());
        }

        private void yöneticiGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SekreterGuncelleSilForm());
        }

    
    }
}
