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
    public partial class FormTabelaCliente : Form
    {
        public FormTabelaCliente()
        {
            InitializeComponent();
        }

        private void FormTabelaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inConnectedDBDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.inConnectedDBDataSet.Cliente);

        }

    }
}
