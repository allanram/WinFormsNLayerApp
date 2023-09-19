using Negocio;
using Negocio.Entidades.Comum;
using System;
using System.Collections.Generic;
using Database.Repositorios;
using Negocio.Entidades;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Entidades.Validator;

namespace WindowsForms.Telas.Funcionario
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            var nome = txtNomeFuncionario.Text;
            var cic = mskCic.Text;
            var dataAdimissao = DateTime.Parse(dtpAdmissao.Text);
            var dataNascimento = DateTime.Parse(dtpNascimento.Text);
            var Uf = cmbUf.Text;
            var nascionalidade = txtNascionalidade.Text;
            var telefone = mskTelefone.Text;
            var rg = mskRg.Text;
            var sexo;



            var novoCadastro = new Funcionarios(nome, dataNascimento, telefone, dataAdimissao, cic, nascionalidade, sexo, rg);


        }
    }
}
