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

    public partial class ListHabitos : Form
    {
        public int[] valores = new int[5];
        public string[] habitos = new string[5];
        public string[] frases = new string[9];
        
        public void passaString()
        {
            this.hb1.Text = habitos[0];
            this.hb2.Text = habitos[1];
            this.hb3.Text = habitos[2];
            this.hb4.Text = habitos[3];
            this.hb5.Text = habitos[4];
        }
        public void habilita1()
        {
            this.panel1.Visible = true;
            this.hb1.Visible = true;
            this.pictureBox1.Visible = true;
        }

        public void habilita2()
        {
            this.panel2.Visible = true;
            this.hb2.Visible = true;
            this.pictureBox2.Visible = true;
        }
        public void habilita3()
        {
            this.panel3.Visible = true;
            this.hb3.Visible = true;
            this.pictureBox3.Visible = true;
        }

        public void habilita4()
        {
            this.panel4.Visible = true;
            this.hb4.Visible = true;
            this.pictureBox4.Visible = true;
        }

        public void habilita5()
        {
            this.panel5.Visible = true;
            this.hb5.Visible = true;
            this.pictureBox5.Visible = true;
        }
        //Ver primeiro
        public void ver1()
        {
            if (valores[0] < 3)
            {
                pictureBox1.Image = Properties.Resources.low;
            }
            else if (valores[0] < 6)
            {
                pictureBox1.Image = Properties.Resources.medium;
                panel1.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.high;
                panel1.BackColor = Color.LawnGreen;
            }
        }

        //ver segundo
        public void ver2()
        {
            if (valores[1] < 3)
            {
                pictureBox2.Image = Properties.Resources.low;
            }
            else if (valores[1] < 6)
            {
                pictureBox2.Image = Properties.Resources.medium;
                panel2.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.high;
                panel2.BackColor = Color.LawnGreen;
            }
        }

        //ver terceiro

        public void ver3()
        {
            if (valores[2] < 3)
            {
                pictureBox3.Image = Properties.Resources.low;
            }
            else if (valores[2] < 6)
            {
                pictureBox3.Image = Properties.Resources.medium;
                panel3.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.high;
                panel3.BackColor = Color.LawnGreen;

            }
        }

        //ver quarto

        public void ver4()
        {
            if (valores[3] < 3)
            {
                pictureBox4.Image = Properties.Resources.low;
            }
            else if (valores[3] < 6)
            {
                pictureBox4.Image = Properties.Resources.medium;
                panel4.BackColor = Color.Yellow;

            }
            else
            {
                pictureBox4.Image = Properties.Resources.high;
                panel4.BackColor = Color.LawnGreen;
            }
        }

        //ver quinto

        public void ver5()
        {
            if (valores[4] < 3)
            {
                pictureBox5.Image = Properties.Resources.low;
            }
            else if (valores[4] < 6)
            {
                pictureBox5.Image = Properties.Resources.medium;
                panel5.BackColor = Color.Yellow;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.high;
                panel5.BackColor = Color.LawnGreen;
            }
        }

        public void atualizar()
        {
            ver1();
            ver2();
            ver3();
            ver4();
            ver5();
        }
        public ListHabitos()
        {
            InitializeComponent();
        }

        private void hb1_Click(object sender, EventArgs e)
        {
            valores[0]++;
            atualizar();
            if(valores[0]<9)
            MessageBox.Show(frases[valores[0]]);

        }

        private void hb2_Click(object sender, EventArgs e)
        {
            valores[1]++;
            atualizar();
            if (valores[1] < 9)
                MessageBox.Show(frases[valores[1]]);
        }

        private void hb3_Click(object sender, EventArgs e)
        {
            valores[3]++;
            atualizar();
            if (valores[3] < 9)
                MessageBox.Show(frases[valores[3]]);
        }

        private void hb4_Click(object sender, EventArgs e)
        {
            valores[2]++;
            atualizar();
            if (valores[2] < 9)
                MessageBox.Show(frases[valores[2]]);
        }

        private void hb5_Click(object sender, EventArgs e)
        {
            valores[4]++;
            atualizar();
            if (valores[4] < 9)
                MessageBox.Show(frases[valores[4]]);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            frases[0] = "O primeiro passo foi dado!";
            frases[1] = "Você consegue!";
            frases[2] = "Continue firme!";
            frases[3] = "Você está indo muito bem!";
            frases[4] = "Seja persistente";
            frases[5] = "Uau, está sendo incrível!";
            frases[6] = "Aê Conseguiu!";
            frases[7] = "Falei que você conseguiu por que está clicando novamente?";
            frases[8] = "Não vou falar mais nada pra você."; 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
