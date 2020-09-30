using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeCafeVirtual.Resources
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TrocoDoCafe(float troco, float retorno)
        {
            if((troco > 0.0) && (retorno > 0.0))
            {
                return TrocoTxt.Text = "O seu troco é de R$ " 
                    + troco.ToString("F2") + " e também estamos devolvendo R$ " 
                    + retorno.ToString("F2") + " pois não aceitamos moedas de 1 e 5 centavos";
            }
            else if((troco > 0.0) && (retorno == 0.0))
            {
                return TrocoTxt.Text = "O seu troco é de R$ "
                    + troco.ToString("F2");
            }
            else if((troco == 0.0) && (retorno > 0.0))
            {
                return TrocoTxt.Text = "Estamos devolvendo R$ " 
                    + retorno.ToString("F2") + " pois não aceitamos moedas de 1 e 5 centavos";
            }
            else
            {
                return TrocoTxt.Text = "Obrigado e volte sempre!";
            }
            
        }
    }
}
