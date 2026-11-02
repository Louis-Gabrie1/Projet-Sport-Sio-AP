using AppliSportAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliGestionSportifs
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {
                    }

        private void consultationDesSportifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSport unObjectSport = new FrmSport();
            unObjectSport.Show();
        }

        private void gestionDesSportifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion unObjectSport = new FrmGestion();
            unObjectSport.Show();
            
        }
    }
}
