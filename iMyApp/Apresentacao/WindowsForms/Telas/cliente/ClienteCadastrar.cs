﻿

using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Telas.cliente
{
    public partial class ClienteCadastrar : Form
    {
        // Construtor
        public ClienteCadastrar()
        {
            InitializeComponent();

            var cliente = new Cliente();
            
            var colaborador = new Colaborador();
            
            

        }
    }
}
