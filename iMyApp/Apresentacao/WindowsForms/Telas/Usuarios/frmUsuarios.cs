using Negocio.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Telas.Usuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var remetente = txtFrom.Text;
            var destinatario = txtTo.Text;
            var assunto =  txtSubject.Text;
            var mensagem  = txtMensagem.Text;   
                
            var emailService = new EmailServices(remetente,destinatario,assunto,mensagem);
            emailService.EmailRecuperarSenha("allan.r.aguiar@aluno.senai.br");
        }
    }
}
