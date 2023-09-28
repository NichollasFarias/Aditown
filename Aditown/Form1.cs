using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Aditown
{
    public partial class Form1 : Form
    {
        #region Variaveis Globais


        //Somatoria: SomaG 
        // Os Num01 e Num02 são variaveis globais para amazernar o valor dos randoms para executar uma verificação 
        // E os Ran01 e 02 são os randoms que irão executar uma somatoria aleatoria
        // RanFrut é um numero Randomico para escolher o ID da fruta e o NumFrut é o ID da Fruta
        //Cont01 e 02 são os pontos, o 01 é os acertos e o 02 são as erradas
        //Ligado é a variavel para controlar se liga ou desliga o audio
        // Inicio e Inicio2 são variaveis auxiliares para o inicio do jogo
        // Tempo = Tempo de jogo

        int SomaG = 0, Num01, Num02, cont01 = 0, cont02 = 0, NumFrut, tempo;
        Random Ran01 = new Random();
        Random Ran02 = new Random();
        Random RanFrut = new Random();
        bool Ligado = true, Inicio  = true, Inicio2 = true;

        #endregion

        #region Iniciador
        public Form1()
        {
            InitializeComponent();
            CriacaodaSomatoria();
        }
        #endregion

        #region Criador das Contas

        public void CriacaodaSomatoria()
        {
            Mensagens();
            timer1.Start();
            do
            {
                Num01 = Ran01.Next(1,11);
                do
                {
                    Num02 = Ran02.Next(1, 11);
                    NumFrut = RanFrut.Next(1, 6);

                } while (Num02 == Num01);
               

                SomaG = Num01 + Num02;
                NumFrut = RanFrut.Next(1,6);

            } while (SomaG > 10);
            

            Imagens();

        }
        #endregion

        #region Função MessageBox
        public void Mensagens()
        {
            if (Inicio)
            {
                
                SoundPlayer inicio = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\Inicio.wav");
                inicio.Play();
                if (MessageBox.Show("Você esta pronto para jogar?", "O Jogo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Inicio = false;
                    tempo = 10;
                    CriacaodaSomatoria();
                }
                else
                {
                    Mensagens();
                }
            }
            else
            {
                if (Inicio2)
                {
                    Inicio2 = false;
                }
                else
                {
                    if (Ligado)
                    {
                        SoundPlayer proxima = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\PP.wav");
                        proxima.Play();
                       
                    }
                    MessageBox.Show("Você esta pronto?");
                }
            }
        }
        #endregion

        #region IDdasFrutas

        public void Imagens()
        {
            #region Banana
            if (NumFrut == 1)
            {
                LB_Per.Text = "Quantas Bananas tem nessa imagem?";
                if (Ligado)
                {
                    SoundPlayer banana = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\QuantasBananas.wav");
                    banana.Play();
                }

                #region Primeiro Produto
                if (Num01 == 1)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban1.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num01 == 2)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban2.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num01 == 3)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban3.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num01 == 4)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban4.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num01 == 5)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban5.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num01 == 6)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban6.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num01 == 7)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban7.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num01 == 8)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban8.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num01 == 9)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban9.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
                #region Segundo Produto
                if (Num02 == 1)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban1.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num02 == 2)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban2.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num02 == 3)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban3.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num02 == 4)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban4.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num02 == 5)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban5.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num02 == 6)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban6.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num02 == 7)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban7.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num02 == 8)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban8.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num02 == 9)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ban9.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
            }
            #endregion

            #region Maçã
            if (NumFrut == 2)
            {
                LB_Per.Text = "Quantas Maçãs tem nessa imagem?";
                if (Ligado)
                {
                    SoundPlayer Maca = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\QuantasMaca.wav");
                    Maca.Play();
                }
                #region Primeiro Produto
                if (Num01 == 1)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma1.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num01 == 2)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma2.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num01 == 3)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma3.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num01 == 4)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma4.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num01 == 5)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma5.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num01 == 6)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma6.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num01 == 7)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma7.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num01 == 8)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma8.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num01 == 9)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma9.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
                #region Segundo Produto
                if (Num02 == 1)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma1.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num02 == 2)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma2.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num02 == 3)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma3.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num02 == 4)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma4.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num02 == 5)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma5.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num02 == 6)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma6.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num02 == 7)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma7.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num02 == 8)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma8.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num02 == 9)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ma9.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
            }
            #endregion

            #region Morango
            if (NumFrut == 3)
            {
                LB_Per.Text = "Quantos Morangos tem nessa imagem?";
                if (Ligado)
                {
                    SoundPlayer Morango = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\QuantosMorangos.wav");
                    Morango.Play();
                }
                #region Primeiro Produto
                if (Num01 == 1)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo1.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num01 == 2)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo2.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num01 == 3)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo3.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num01 == 4)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo4.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num01 == 5)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo5.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num01 == 6)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo6.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num01 == 7)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo7.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num01 == 8)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo8.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num01 == 9)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo9.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
                #region Segundo Produto
                if (Num02 == 1)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo1.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num02 == 2)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo2.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num02 == 3)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo3.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num02 == 4)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo4.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num02 == 5)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo5.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num02 == 6)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo6.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num02 == 7)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo7.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num02 == 8)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo8.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num02 == 9)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mo9.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
            }
            #endregion

            #region Manga
            if (NumFrut == 4)
            {
                LB_Per.Text = "Quantas Mangas tem nessa imagem?";
                if (Ligado)
                {
                    SoundPlayer Manga = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\QuantasMangas.wav");
                    Manga.Play();
                }
                #region Primeiro Produto
                if (Num01 == 1)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man1.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num01 == 2)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man2.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num01 == 3)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man3.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num01 == 4)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man4.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num01 == 5)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man5.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num01 == 6)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man6.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num01 == 7)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man7.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num01 == 8)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man8.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num01 == 9)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man9.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
                #region Segundo Produto
                if (Num02 == 1)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man1.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num02 == 2)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man2.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num02 == 3)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man3.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num02 == 4)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man4.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num02 == 5)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man5.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num02 == 6)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man6.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num02 == 7)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man7.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num02 == 8)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man8.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num02 == 9)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Man9.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
            }
            #endregion

            #region Uva
            if (NumFrut == 5)
            {
                LB_Per.Text = "Quantas Uvas tem nessa imagem?";
                if (Ligado)
                {
                    SoundPlayer Uva = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\QuantasUvas.wav");
                    Uva.Play();
                }
                #region Primeiro Produto
                if (Num01 == 1)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv1.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num01 == 2)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv2.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num01 == 3)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv3.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num01 == 4)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv4.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num01 == 5)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv5.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num01 == 6)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv6.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num01 == 7)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv7.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num01 == 8)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv8.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num01 == 9)
                {
                    PB_Frut01.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv9.png");
                    PB_Produto1.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
                #region Segundo Produto
                if (Num02 == 1)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv1.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\1.png");
                }
                if (Num02 == 2)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv2.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\2.png");
                }
                if (Num02 == 3)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv3.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\3.png");
                }
                if (Num02 == 4)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv4.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\4.png");
                }
                if (Num02 == 5)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv5.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\5.png");
                }
                if (Num02 == 6)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv6.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\6.png");
                }
                if (Num02 == 7)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv7.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\7.png");
                }
                if (Num02 == 8)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv8.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\8.png");
                }
                if (Num02 == 9)
                {
                    PB_Frut02.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Uv9.png");
                    PB_Produto2.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\9.png");
                }
                #endregion
            }
            #endregion
        }

        #endregion

        #region Botões

        public void Errado()
        {
            timer1.Stop();
            cont02++;
            LB_Erradas.Text = cont02.ToString();
            if (cont02 <= 4)
            {
                tempo = 10;
            }
            else
            {
                tempo = 20;
            }
            if (Ligado)
            {
                SoundPlayer Errou = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\Errou.wav");
                Errou.Play();
            }
            MessageBox.Show(Num01.ToString() + " + " + Num02.ToString() + " = " + SomaG.ToString(),"Resultado");

        }
        public void Certo()
        {
            timer1.Stop();
            if (cont02 <= 4)
            {
                tempo = 10;
            }
            else
            {
                tempo = 20;
            }
            cont01++;
            LB_Certas.Text = cont01.ToString();
        }

        private void BT_01_Click(object sender, EventArgs e)
        {
            if (SomaG == 1)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_02_Click(object sender, EventArgs e)
        {
            if (SomaG == 2)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_03_Click(object sender, EventArgs e)
        {
            if (SomaG == 3)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_04_Click(object sender, EventArgs e)
        {
            if (SomaG == 4)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_05_Click(object sender, EventArgs e)
        {
            if (SomaG == 5)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_06_Click(object sender, EventArgs e)
        {
            if (SomaG == 6)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_07_Click(object sender, EventArgs e)
        {
            if (SomaG == 7)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_08_Click(object sender, EventArgs e)
        {
            if (SomaG == 8)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_09_Click(object sender, EventArgs e)
        {
            if (SomaG == 9)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        private void BT_10_Click(object sender, EventArgs e)
        {
            if (SomaG == 10)
            {
                Certo();
            }
            else
            {
                Errado();
            }

            CriacaodaSomatoria();
        }

        #endregion

        #region Botão Reiniciar
        private void BT_Reniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (Ligado)
            {
                SoundPlayer re = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\Recomecar.wav");
                re.Play();
            }
            if (MessageBox.Show("Você deseja Reiniciar?", "Reiniciar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                cont01 = 0;
                cont02 = 0;
                LB_Certas.Text = cont01.ToString();
                LB_Erradas.Text = cont02.ToString();
                tempo = 10;
                CriacaodaSomatoria();
            }
            else
            {
                timer1.Start();
            }
            
        }
        #endregion

        #region Botão Autores


        private void BT_Autores_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Ligado)
            {
                SoundPlayer re = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\Autores.wav");
                re.Play();
            }
            MessageBox.Show("Mateus Gomes \nNichollas Farias", "Autores");
            timer1.Start();
        }
        #endregion

        #region Audio
        private void BT_Audio_Click(object sender, EventArgs e)
        {
            if (Ligado)
            {
                BT_Audio.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Mudo2.png");
                Ligado = false;
            }
            else
            {
                BT_Audio.BackgroundImage = Image.FromFile(Directory.GetCurrentDirectory() + "\\Ligado.png");
                Ligado = true;
            }
        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {

            tempo = tempo - 1;
            LB_Time.Text = tempo.ToString() + " s";
            if (tempo == 0)
            {
                timer1.Stop();
                Errado();

                if (cont02 <= 4)
                {
                    tempo = 10;
                    CriacaodaSomatoria();
                }
                else
                {
                    tempo = 20;
                    CriacaodaSomatoria();
                }
            }
            
        }
        #endregion

        #region Explição

        #endregion

        #region Sair
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (Ligado)
            {
                SoundPlayer re = new SoundPlayer(@Directory.GetCurrentDirectory() + "\\Sair.wav");
                re.Play();
            }
            if (MessageBox.Show("Você gostaria de fechar?", "Deseja Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                timer1.Start();
                e.Cancel = true;
            }
        }
        #endregion

    }
}
