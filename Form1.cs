using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstacionamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float varTotal = 0;
            if (LstTipo.SelectedIndex == 0)
            {
                varTotal = 400;
            }
            if (LstTipo.SelectedIndex == 1)
            {
                varTotal = 200;
            }
            if (LstTipo.SelectedIndex == 2)
            {
                varTotal = 600;
            }
            if (LstTipo.SelectedIndex == 3)
            {
                varTotal = 700;
            }


            if (NudHoras.Value == 1)
            {
                varTotal = varTotal * 1;
            }
            if (NudHoras.Value == 2)
            {
                varTotal = varTotal * 2;
            }
            if (NudHoras.Value == 3)
            {
                varTotal = varTotal * 3;
            }

            if (OptPlantaBaja.Checked == true)
            {
                varTotal = (varTotal * 10 / 100) + varTotal;
            }
            if (OptSegundoPiso.Checked == true)
            {
                varTotal = (varTotal * 5 / 100) + varTotal;
            }
            if (OptTercerPiso.Checked == true)
            {
                varTotal = (varTotal * 2 / 100) + varTotal;
            }
            if (OptCuartoPiso.Checked == true)
            {
                varTotal = varTotal - (varTotal * 5 / 100);
            }

            if (ChkMañana.Checked == true)
            {
                varTotal = varTotal + (varTotal * 5 / 100);
            }
            if (ChkTarde.Checked == true)
            {
                varTotal = varTotal + (varTotal * 3 / 100);
            }
            if (ChkNoche.Checked == true)
            {
                varTotal = varTotal + (varTotal * 1 / 100); ;
            }


            LblTotal.Text = varTotal.ToString();

        }
    }
}
