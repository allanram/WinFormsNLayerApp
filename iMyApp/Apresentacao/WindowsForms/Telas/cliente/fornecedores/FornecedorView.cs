using Database.Repositorios;
using Negocio.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Telas.cliente.fornecedores
{
    public partial class FornecedorView : Form
    {
        private IFornecedorRepository _fornecedorRepository;
        public FornecedorView()
        {
            InitializeComponent();
            _fornecedorRepository = new FornecedorRepository();
        }

        private void FornecedorView_Load(object sender, EventArgs e)
        {
            var listaFornecedores = _fornecedorRepository.ObterTodos();
            dgvMostraFornecedores.DataSource = listaFornecedores;
        }
    }
}
