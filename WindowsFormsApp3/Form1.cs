using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public System.Drawing.Graphics picture;
        private void Form1_Load(object sender, EventArgs e)
        {
            picture = pictureBox1.CreateGraphics();
        }
        Rectangle[] cav = new Rectangle[6];
        Rectangle cavx = new Rectangle();
        string[] Apostadores = new string[6];
        int[] PontosApostadores = new int[5] { 100, 100, 100, 100, 100 };
        string IdentificacaoCor ;
        int IdentificacaoApostador = 0;
        int LiberarComeçar = 0;
        int TotalAposta = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            cavx.Width = 2;
            cavx.Height = 2;

            for ( int i=1; i<6; i++)
            {
                cav[i].Height = 1;
                cav[i].Width = 1;
                cav[i].X = 5;
                cav[i].Y = 40 * i;
                picture.DrawRectangle(Pens.Black, cav[i]);
            }
            int sort;
            bool acabou = false;
            Random ra = new Random(System.DateTime.Now.Millisecond);

            while (!acabou)
            {
                sort = ra.Next(2000000);

                switch (sort)
                {
                    case 1:
                        {
                            cav[1].X = cav[1].X + 1;
                            picture.DrawRectangle(Pens.Yellow, cav[1]);
                            if (cav[1].X > 540)
                            {
                                IdentificacaoCor = "amarelo";
                                label6.Text = "Amarelo venceu!";
                                acabou = true;
                                for ( int i=1; i<Apostadores.Length; i++)
                                {
                                    if (Apostadores[i] == IdentificacaoCor)
                                        PontosApostadores[i] += TotalAposta;
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            cav[2].X = cav[2].X + 2;
                            picture.DrawRectangle(Pens.White, cav[2]);
                            if (cav[2].X > 540)
                            {
                                IdentificacaoCor = "Branco";
                                label6.Text = "Branco venceu!";
                                acabou = true;
                                for (int i = 1; i < Apostadores.Length; i++)
                                {
                                    if (Apostadores[i] == IdentificacaoCor)
                                        PontosApostadores[i] += TotalAposta;
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            cav[3].X = cav[3].X + 2;
                            picture.DrawRectangle(Pens.SpringGreen, cav[3]);
                            if (cav[3].X > 540)
                            {
                                IdentificacaoCor = "Verde";
                                label6.Text = "Verde venceu!";
                                acabou = true;
                                for (int i = 1; i < Apostadores.Length; i++)
                                {
                                    if (Apostadores[i] == IdentificacaoCor)
                                        PontosApostadores[i] += TotalAposta;
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            cav[4].X = cav[4].X + 2;
                            picture.DrawRectangle(Pens.Red, cav[4]);
                            if (cav[4].X > 540)
                            {
                                IdentificacaoCor = "Vermelho";
                                label6.Text = "Vermelho venceu!";
                                acabou = true;
                                for (int i = 1; i < Apostadores.Length; i++)
                                {
                                    if (Apostadores[i] == IdentificacaoCor)
                                        PontosApostadores[i] += TotalAposta;
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            cav[5].X = cav[5].X + 2;
                            picture.DrawRectangle(Pens.DeepSkyBlue, cav[5]);
                            if (cav[5].X > 540)
                            {
                                IdentificacaoCor = "Azul";
                                label6.Text = "Azul venceu!";
                                acabou = true;
                              for ( int i=1; i<Apostadores.Length; i++)
                                {
                                    if (Apostadores[i] == IdentificacaoCor)
                                        PontosApostadores[i] += TotalAposta;
                                }
                            }
                            break;
                        }
                }
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                cav[i].X = 5;
                cav[i].Y = 40 * i;
                picture.Clear(Color.Black);
                label6.Text = "Facam suas apostas em ordem crescente, jogadores !";
                btnAmarelo.Enabled = true;
                btnAzul.Enabled = true;
                btnVerde.Enabled = true;
                btnVermelho.Enabled = true;
                btnBranco.Enabled = true;
                IdentificacaoApostador = 0;
                IdentificacaoCor = "";
                TotalAposta = 0;
                LiberarComeçar = 0;
                button1.Enabled = false; 
                apo1.Text = PontosApostadores[0].ToString();
                apo2.Text = PontosApostadores[1].ToString();
                apo3.Text = PontosApostadores[2].ToString();
                apo4.Text = PontosApostadores[3].ToString();
                apo5.Text = PontosApostadores[4].ToString();
                for (int a = 0; a< PontosApostadores.Length; a++)
                {
                    if ( PontosApostadores[a] >= 200)
                    {
                        a++;
                        textBox1.Text = "E O GRANDE VENCEDOR É O JOGADOR NUMERO";
                        label13.Text = a.ToString();
                    }
                }
            }
        }

        private void btnClick(object sender, EventArgs e)
        {
            var btn = ((Button)sender);
            LiberarComeçar++;
            IdentificacaoCor = btn.Text;
            btn.Enabled = false;
            NumeroApostador();
            PontosApostadores[IdentificacaoApostador] -= 10;
            IdentificacaoApostador++;
            TotalAposta += 10;
        }

        private void NumeroApostador()
        {
            Apostadores[IdentificacaoApostador] = IdentificacaoCor;
            if (LiberarComeçar == 2)
                button1.Enabled = true;
        }

    }
}
