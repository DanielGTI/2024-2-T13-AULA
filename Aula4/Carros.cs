using System.Numerics;

namespace Aula4
{
    public partial class frm_Carros : Form
    {
        int carro = 0, votos = 0;
        // carro 1 = Corolla
        // carro 2 = Cybertruck
        // carro 3 = Ferrari

        public frm_Carros()
        {
            InitializeComponent();
        }

        private void btnCarro2_Click(object sender, EventArgs e)
        {
            pic_Carro.Image = Properties.Resources.cybertruck;
            carro = 2;
        }

        private void btnCarro1_Click(object sender, EventArgs e)
        {
            pic_Carro.Image = Properties.Resources.Corolla;
            carro = 1;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if ( carro == 1 )
            {
                votos = Convert.ToInt32(lbl_Votos_Corolla.Text) + 1;
                lbl_Votos_Corolla.Text = votos.ToString();
            }
            if ( carro == 2 )
            {
                votos = Convert.ToInt32(lbl_Votos_Cybertruck.Text) + 1;
                lbl_Votos_Cybertruck.Text = votos.ToString();
            }
            if( carro == 3)
            {
                votos = Convert.ToInt32(lbl_Votos_Ferrari.Text) + 1;
                lbl_Votos_Ferrari.Text = votos.ToString();
            }


            pic_Carro.Image = Properties.Resources.cars;
            carro = votos = 0;
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            carro = votos = 0;
            lbl_Votos_Cybertruck.Text = "0";
            lbl_Votos_Corolla.Text = "0";
            lbl_Votos_Ferrari.Text = "0";
            pic_Carro.Image = Properties.Resources.cars;
        }

        private void btn_Ferrari_Click(object sender, EventArgs e)
        {
            pic_Carro.Image = Properties.Resources.ferrari;
            carro = 3;
        }
    }
}


