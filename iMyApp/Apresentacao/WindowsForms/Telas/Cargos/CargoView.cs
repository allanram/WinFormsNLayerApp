
using Negocio.Entidades;
using Negocio.Repositorios;
using Negocio.Validators;

namespace WindowsForms.Telas.Cargos
{
    public partial class CargoView : Form
    {
        private readonly ICargoRepository _cargoRepository;
        public CargoView(ICargoRepository cargoRepository)
        {
            InitializeComponent();
            _cargoRepository = cargoRepository;
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





            var resultado = _cargoRepository.Incluir(novoCargo);

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
            
            var dataTable = _cargoRepository.OterTodos();
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
