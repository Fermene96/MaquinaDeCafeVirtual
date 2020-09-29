using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeCafeVirtual
{
    public partial class Form1 : Form
    {

        float Valor = 0.0F;
        float ValorDoCafe = 0.0F;

        public Form1()
        {
            InitializeComponent();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MochaOpt_CheckedChanged(object sender, EventArgs e)
        {
            PainelDigital.Clear();
            EnableButtons();
            PainelDigital.Text = "São 4 reais";
            ValorDoCafe = 4.0F;
        }

        private void CafeOpt_CheckedChanged(object sender, EventArgs e)
        {
            PainelDigital.Clear();
            EnableButtons();
            PainelDigital.Text = "São 2 reais";
            ValorDoCafe = 2.0F;
        }

        private void CappuccinoOpt_CheckedChanged(object sender, EventArgs e)
        {
            PainelDigital.Clear();
            EnableButtons();
            PainelDigital.Text = "São 3 reais e 50 centavos";
            ValorDoCafe = 3.5F;
        }

        private void CafeComLeiteOpt_CheckedChanged(object sender, EventArgs e)
        {
            PainelDigital.Clear();
            EnableButtons();
            PainelDigital.Text = "São 3 reais";
            ValorDoCafe = 3.0F;
        }
        
        private void EnableButtons()
        {
            PrepararBtn.Enabled = true;
            CancelarBtn.Enabled = true;
        }

        private void umCentBtn_Click(object sender, EventArgs e)
        {
            Valor = Valor + 0.01F;
        }

        private void PrepararBtn_Click(object sender, EventArgs e)
        {
            if(Valor < ValorDoCafe)
            {
                float Total = ValorDoCafe - Valor;
                PainelDigital.Text = "Está faltando R$" + Total.ToString();
            }
            else if(Valor >= ValorDoCafe)
            {
                PainelDigital.Text = "Esta saindo...";
            }
        }
    }
}
