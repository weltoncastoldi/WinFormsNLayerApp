using Database.Repositorios;
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

            var novoCargo = new Cargo(nome,status);


            var cargoRepository = new CargoRepository();

            var resultado = cargoRepository.Inserir(novoCargo);

            if (resultado)
            {
                MessageBox.Show("Cargo cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar o cargo");
            }
            
        }
    }
}
