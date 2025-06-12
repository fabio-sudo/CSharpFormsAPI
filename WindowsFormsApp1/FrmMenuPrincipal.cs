using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMenuPrincipal : Form
    {
        

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //CEP não preenchido
            if (mtbCep.Text == string.Empty)
                return;



        }
    }
}
