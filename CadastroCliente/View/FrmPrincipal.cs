using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente.View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.Show();
        }

        private void cadastroLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
