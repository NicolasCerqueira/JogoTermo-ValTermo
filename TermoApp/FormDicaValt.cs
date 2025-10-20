using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TermoApp
{
    public partial class FormDicaValt : Form
    {
        public bool aceitouDicaValt = false;
        private FormJogo formPrincipal;

        public FormDicaValt(FormJogo formJogo) 
        {
            InitializeComponent();
            this.formPrincipal = formJogo; 
        }
        private void aceitarDica_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eu sei que você usa break no código,\n" +
                            "vai ficar sem dica e perdeu uma tentativa",
                            "Valtão ta na maldade", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            aceitouDicaValt = true;
            formPrincipal.aceitarDica_Consequencias();
            this.Close();

        }

        private void negarDica_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
