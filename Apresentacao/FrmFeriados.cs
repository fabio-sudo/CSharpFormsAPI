using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmFeriados : Form
    {

        NegFeriado nFeriado = new NegFeriado();
        List<Feriado> listaFeriados = new List<Feriado>(); 

        public FrmFeriados()
        {
            InitializeComponent();
        }

        //Eventos manuais Grid
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.Rows.Count > 0)
                if (dgvFeriados.SelectedRows.Count > 0)
                    dgvFeriados.Rows.Remove(dgvFeriados.SelectedRows[0]);

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {


            // 1. Adicione colunas manualmente (nome, data, tipo)
            dgvFeriados.Columns.Add("colNome", "Nome do Feriado");
            dgvFeriados.Columns.Add("colData", "Data");
            dgvFeriados.Columns.Add("colTipo", "Tipo");

        }

        private void btLinha_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.Columns.Count <= 0)
                return;
            // 2. Adicione uma nova linha ao DataGridView
            int index = dgvFeriados.Rows.Add(); // Adiciona uma linha vazia e retorna o índice

            // 3. Defina os valores das células manualmente
            dgvFeriados.Rows[index].Cells[0].Value = "Ano Novo";
            dgvFeriados.Rows[index].Cells[1].Value = "01/01/2025";
            dgvFeriados.Rows[index].Cells[2].Value = "Feriado Nacional";


        }

        private void btAdicionarLinha_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.Columns.Count <= 0)
                return;

            dgvFeriados.Rows.Add();

        }

        private void btRemoverLinha_Click(object sender, EventArgs e)
        {
            if (dgvFeriados.Rows.Count > 0)
                if (dgvFeriados.CurrentRow != null)
                    dgvFeriados.Rows.Remove(dgvFeriados.CurrentRow);
        }

        private void btLimparGrid_Click(object sender, EventArgs e)
        {
            dgvFeriados.Rows.Clear();
            dgvFeriados.Columns.Clear();
        }
        //-------------




        private async void btBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAno.Text))
                return;

            // Limpa a lista antes de buscar
            listaFeriados.Clear();

            // Busca feriados e preenche listaFeriados
            await nFeriado.BuscarFeriados(tbAno.Text, listaFeriados);

            // Atualiza o DataGridView se houver dados
            if (listaFeriados.Any())
            {
                dgvFeriados.DataSource = null; // Limpa a fonte de dados
                dgvFeriados.DataSource = new BindingList<Feriado>(listaFeriados);
            }

        }
    }
}
