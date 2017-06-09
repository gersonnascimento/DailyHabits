using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyHabits
{
    public partial class Inicio : Form
    {
        ListHabitos form = new ListHabitos();
        public string[] habitos = new string[5];
        public int control = 0;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            habitos[control++] = txtHabito.Text;
            switch (control)
            {
                case 1: form.habilita1();
                    break;
                case 2: form.habilita2();
                    break;
                case 3: form.habilita4();
                    break;
                case 4: form.habilita3();
                    break;
                case 5: form.habilita5();
                    break;
            }
            txtHabito.Text = "";
            if (control == 5)
            {
                this.btnAdicionar.Enabled = false;
                this.txtHabito.Enabled = false;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {


        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            form.habitos = this.habitos;
            form.passaString();
            form.Show();
            this.Hide();
        }
    }
}
