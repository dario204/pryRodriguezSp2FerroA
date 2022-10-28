using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRodriguezSp2FerroA
{
    public partial class frmFerro : Form
    {

        public frmFerro()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            string ComprueboDistancia = txtDistancia.Text.Trim();
            if (ComprueboDistancia.Length>0)
            {
                int distancia = Convert.ToInt32(txtDistancia.Text);
                if (distancia>0)
                {
                    if (Convert.ToInt32(numDias.Value)>= 7 && distancia>=100)
                    {
                        lblPrecioo.Text = Convert.ToString(2.50 * distancia);
                        lblTotall.Text = "$2.5";
                    }
                    else
                    {
                        lblPrecioo.Text = Convert.ToString(5 * distancia);
                        lblTotall.Text = "$5";
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar distancia porfavor");
                }
            }
        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar !=(char)Keys.Back))
            {
                 e.Handled=true;
            }
        }
    }
}
