using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLojonaDoJao
{
    public partial class RegistrarClientes : Form
    {
        public RegistrarClientes()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inConnectedDBDataSet.Cidade' table. You can move, or remove it, as needed.
            this.cidadeTableAdapter.Fill(this.inConnectedDBDataSet.Cidade);

        }
    }
}
