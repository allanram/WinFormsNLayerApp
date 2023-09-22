using Database.Repositorios;
using Negocio.Entidades;
using Negocio.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Telas.Cargos
{
    public partial class CargoView : Form
    {

        public CargoView()
        {
            InitializeComponent();
        }

        private void btnNovoCargo_Click(object sender, EventArgs e)
        {
            groupBoxCargo.Visible = !groupBoxCargo.Visible;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var nome = txtCargo.Text;
            var status = chkStatus.Checked;
            var novoCargo = new Cargo(nome, status);

            var erros = Validacoes.ValidarDataAnottations(novoCargo);

            foreach( var erro in erros )
            {
                MessageBox.Show(erro.ErrorMessage);
            }




            var cargoRepository = new CargoRepository();

            var resultado = cargoRepository.Inserir(novoCargo);

            if (resultado)
            {
                MessageBox.Show("Cargo cadastro com sucesso");
            }
            else
            {
                MessageBox.Show("Erro,verifique e tente novamente");
            }
        }

        private void CargoView_Load(object sender, EventArgs e)
        {
            var cargoRepository = new CargoRepository();
            var dataTable = cargoRepository.ObterTodos();
            gvCargos.DataSource = dataTable;
        }

        private void gvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                groupBoxCargo.Show();
                var row = gvCargos.Rows[e.RowIndex];
                txtCargo.Text = row.Cells[1].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(row.Cells[2].Value.ToString());
            }
        }

        
        private void btnRecarregar_Click(object sender, EventArgs e)
        {
            
           
          
        }
    }
}
