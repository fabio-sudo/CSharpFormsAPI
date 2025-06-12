using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using ObjetoTransferencia;



namespace Apresentacao
{
    public partial class FrmCep : Form
    {

        NegCep nCep = new NegCep();
        Cep? objCep = new Cep();

        public FrmCep()
        {
            InitializeComponent();
        }




        private void MetodoPreencherGrid(Cep cep)
        {
            dgvCep.Rows.Clear(); // Limpa antes de adicionar novas linhas

            dgvCep.Rows.Add("CEP:",mtbCep.Text);
            dgvCep.Rows.Add("Estado:", cep.State);
            dgvCep.Rows.Add("Cidade:", cep.City);
            dgvCep.Rows.Add("Bairro:", cep.Neighborhood);
            dgvCep.Rows.Add("Rua:", cep.Street);
            dgvCep.Rows.Add("Serviço:", cep.Service);
            dgvCep.Rows.Add("", "Texte");
        }

 

        private async void btnCep_Click(object sender, EventArgs e)
        {
            var cep = await nCep.GetCep(mtbCep.Text);

            if (cep != null)
            {
                MetodoPreencherGrid(cep);
            }
            else
            {
                MessageBox.Show("CEP não encontrado ou inválido.");
                dgvCep.Rows.Clear();
            }
        }
    }
}
