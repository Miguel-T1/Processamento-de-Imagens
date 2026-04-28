using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final_Novo_e_atualizado_certo
{

    public partial class Form1 : Form
    {
        Bitmap resultadoGlobal;
        Bitmap img1;
        Bitmap img2;
        Bitmap img3;
        Bitmap img4;
        Bitmap A;
        Bitmap C;
        Bitmap D1;
        int brilhoAtual = 0;
        float valorCalculo = 0;
        float Blending = 0;
        float valorlim=0;
        byte[,] somarsomarR;
        byte[,] somarsomarG;
        byte[,] somarsomarB;
        byte[,] vImg1Gray;

        byte[,] vImg1R;
        byte[,] vImg1G;
        byte[,] vImg1B;
        byte[,] vImg1A;




        public Form1()
        {

            InitializeComponent();
        }


        private void btCarregarImagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    img1 = new Bitmap(openFileDialog1.FileName);
                    pictureBox1.Image = img1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                int[] hist = new int[256];

                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        Color pixel = img1.GetPixel(i, j);
                        int gray = (pixel.R + pixel.G + pixel.B) / 3;
                        hist[gray]++;
                    }
                }

                chart1.Series[0].Points.Clear();

                for (int i = 0; i < 256; i++)
                {
                    chart1.Series[0].Points.AddXY(i, hist[i]);
                }
            }
        }

        private void btSalvarImagem_Click(object sender, EventArgs e)
        {
            if (img2 == null)
                return;

            // Configurações iniciais da saveFileDialog1
            var filePath = string.Empty;
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;


            ImageFormat format = img2.RawFormat;

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".tif":
                        format = ImageFormat.Tiff;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }

                //pictureBox3.Image.Save(saveFileDialog1.FileName, format);
                img2.Save(saveFileDialog1.FileName, format);
            }
        }


        private void carregar2_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            openFileDialog1.InitialDirectory = "C:\\Matlab";
            openFileDialog1.Filter = "TIFF image (*.tif)|*.tif|JPG image (*.jpg)|*.jpg|BMP image (*.bmp)|*.bmp|PNG image (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                bool bLoadImgOK = false;

                try
                {
                    img3 = new Bitmap(filePath);
                    bLoadImgOK = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao abrir imagem...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    bLoadImgOK = false;
                }

                if (bLoadImgOK == true)
                {
                    pictureBox3.Image = img3;
                }
            }
        }
        private void btSomarImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho!");
                return;
            }

            img4 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int R = pixel.R + pixel3.R;
                    int G = pixel.G + pixel3.G;
                    int B = pixel.B + pixel3.B;
                    int A = pixel.A + pixel3.A;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (A > 255) A = 255;

                    Color cor = Color.FromArgb(A, R, G, B);

                    img4.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = img4;
        }

        private void btSubtImagem_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho!");
                return;
            }
            img4 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int R = pixel.R - pixel3.R;
                    int G = pixel.G - pixel3.G;
                    int B = pixel.B - pixel3.B;


                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;


                    Color cor = Color.FromArgb(R, G, B);

                    img4.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = img4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = pixel.R + brilhoAtual;
                    int G = pixel.G + brilhoAtual;
                    int B = pixel.B + brilhoAtual;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
        }




        private void BrilhoUp_ValueChanged(object sender, EventArgs e)
        {
            brilhoAtual = (int)BrilhoUp.Value;
        }

        private void BrilhoDown_ValueChanged(object sender, EventArgs e)
        {
            brilhoAtual = (int)BrilhoDown.Value;
        }

        private void Dbrilho_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = pixel.R - brilhoAtual;
                    int G = pixel.G - brilhoAtual;
                    int B = pixel.B - brilhoAtual;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
        }


        private void btCinza_Click_1(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            img2 = new Bitmap(img1.Width, img1.Height);

            vImg1Gray = new byte[img1.Width, img1.Height];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    byte pixelIntensity = Convert.ToByte((pixel.R + pixel.G + pixel.B) / 3);

                    vImg1Gray[i, j] = pixelIntensity;

                    Color cor = Color.FromArgb(
                        255,
                        vImg1Gray[i, j],
                        vImg1Gray[i, j],
                        vImg1Gray[i, j]
                    );

                    img2.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = img2;
        }

        private void InvLat_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            img2 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int novoX = img1.Width - 1 - i;

                    img2.SetPixel(novoX, j, pixel);
                }
            }

            pictureBox2.Image = img2;
        }


        private void InvVert_Click(object sender, EventArgs e)
        {
            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            img2 = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int novoY = img1.Height - 1 - j;

                    img2.SetPixel(i, novoY, pixel);
                }
            }

            pictureBox2.Image = img2;
        }

        private void Diff_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }

            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel1 = img1.GetPixel(i, j);
                    Color pixel2 = img3.GetPixel(i, j);

                    int R = Math.Abs(pixel1.R - pixel2.R);
                    int G = Math.Abs(pixel1.G - pixel2.G);
                    int B = Math.Abs(pixel1.B - pixel2.B);

                    Color cor = Color.FromArgb(R, G, B);

                    resultado.SetPixel(i, j, cor);
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void ValorMultip_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                valorCalculo = (float)ValorMultip.Value;


                if (valorCalculo < 0.1 || valorCalculo > 1.5)
                {
                    throw new Exception("Valor fora do intervalo permitido (0.1 - 1.5)");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Insira um valor entre 0.1 e 1.5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void MultiplicarImagem_Click_1(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = (int)(pixel.R * valorCalculo);
                    int G = (int)(pixel.G * valorCalculo);
                    int B = (int)(pixel.B * valorCalculo);

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;


                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;

        }

        private void ValorDiv_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                valorCalculo = (float)ValorDiv.Value;


                if (valorCalculo < 0.1 || valorCalculo > 1.5)
                {
                    throw new Exception("Valor fora do intervalo permitido (0.1 - 1.5)");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Insira um valor entre 0.1 e 1.5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DividirImagem_Click_1(object sender, EventArgs e)
        {

            if (valorCalculo == 0)
            {
                MessageBox.Show("O valor de divisão não pode ser 0.");
                return;
            }

            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = (int)(pixel.R / valorCalculo);
                    int G = (int)(pixel.G / valorCalculo);
                    int B = (int)(pixel.B / valorCalculo);

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
            img2 = resultado;

        }

        private void BlendNumber_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                Blending = (float)BlendNumber.Value;


                if (Blending < 0.0 || Blending > 1)
                {
                    throw new Exception("Valor fora do intervalo permitido (0.1 - 1.0)");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Insira um valor entre 0.1 e 1.5", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BlendBttn_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }

            float C = Blending;

            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel1 = img1.GetPixel(i, j);
                    Color pixel2 = img3.GetPixel(i, j);

                    int R = (int)(C * pixel1.R + (1 - C) * pixel2.R);
                    int G = (int)(C * pixel1.G + (1 - C) * pixel2.G);
                    int B = (int)(C * pixel1.B + (1 - C) * pixel2.B);

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;

        }

        private void Média_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int R = (pixel.R + pixel3.R) / 2;
                    int G = (pixel.G + pixel3.G) / 2;
                    int B = (pixel.B + pixel3.B) / 2;
                    int A = (pixel.A + pixel3.A) / 2;


                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;

        }

        private void AndAnd_Click(object sender, EventArgs e)
        {

            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int PeB = (pixel.R == 255 && pixel3.R == 255) ? 255 : 0;

                    resultado.SetPixel(i, j, Color.FromArgb(PeB, PeB, PeB));
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;


        }

        private void OrOr_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);

                    int PeB = (pixel.R == 255 || pixel3.R == 255) ? 255 : 0;

                    resultado.SetPixel(i, j, Color.FromArgb(PeB, PeB, PeB));
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void NotNot_Click(object sender, EventArgs e)
        {

            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color cor = Color.Aqua;

                    if (pixel.R == 0)
                    {
                        cor = Color.White;
                    }
                    if (pixel.R == 255)
                    {
                        cor = Color.Black;
                    }

                    resultado.SetPixel(i, j, cor);
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void XorXor_Click(object sender, EventArgs e)
        {
            if (img1 == null || img3 == null)
            {
                MessageBox.Show("Carregue as duas imagens primeiro.");
                return;
            }

            if (img1.Width != img3.Width || img1.Height != img3.Height)
            {
                MessageBox.Show("As imagens precisam ter o mesmo tamanho.");
                return;
            }
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color pixel3 = img3.GetPixel(i, j);
                    Color cor = Color.Aqua;

                    if (pixel.R == 0 && pixel3.R ==255)
                    {
                        cor = Color.White;
                    }
                    else if (pixel.R == 255 && pixel3.R == 0)
                    {
                        cor = Color.White;
                    }
                    else cor = Color.Black;

                    resultado.SetPixel(i, j, cor);
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void Limiazizacao_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {

                    Color pixel = img1.GetPixel(i, j);
                    Color cor = Color.White;

                    if (pixel.R < valorlim)
                    {
                        cor = Color.Black;
                    }
                    if (pixel.R >= valorlim)
                    {
                        cor = Color.White;
                    }

                    resultado.SetPixel(i, j, cor);
                }
            }
            pictureBox2.Image = resultado;
            img2 = resultado;
        }

        private void valorLimiar_ValueChanged(object sender, EventArgs e)
        {
            valorlim = (float)valorLimiar.Value;
        }

        private void Negativo_Click(object sender, EventArgs e)
        {
            Bitmap resultado = new Bitmap(img1.Width, img1.Height);

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int R = 255 - pixel.R;
                    int G = 255 -  pixel.G;
                    int B = 255 - pixel.B ;

                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;

                    resultado.SetPixel(i, j, Color.FromArgb(R, G, B));
                }
            }

            pictureBox2.Image = resultado;
        }

        private void btEqualizar_Click(object sender, EventArgs e)
        {
            

            if (img1 == null)
            {
                MessageBox.Show("Carregue uma imagem primeiro.");
                return;
            }

            int width = img1.Width;
            int height = img1.Height;
            int totalPixels = width * height;

            Bitmap resultado = new Bitmap(width, height);
           

            int[] hist = new int[256];


            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    hist[gray]++;
                }
            } 
        

            
            int[] cdf = new int[256];
            cdf[0] = hist[0];

            for (int i = 1; i < 256; i++)
            {
                cdf[i] = cdf[i - 1] + hist[i];
            }

           
            int cdfMin = 0;
            for (int i = 0; i < 256; i++)
            {
                if (cdf[i] != 0)
                {
                    cdfMin = cdf[i];
                    break;
                }
            }

            
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);

                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    int newGray = (int)(((double)(cdf[gray] - cdfMin) / (totalPixels - cdfMin)) * 255);

                    
                    if (newGray < 0) newGray = 0;
                    if (newGray > 255) newGray = 255;

                    Color cor = Color.FromArgb(newGray, newGray, newGray);

                    resultado.SetPixel(i, j, cor);
                }
            }
            int[] hist2 = new int[256];

            for (int i = 0; i < resultado.Width; i++)
            {
                for (int j = 0; j < resultado.Height; j++)
                {
                    Color pixel = resultado.GetPixel(i, j);
                    int gray = pixel.R;

                    hist2[gray]++;
                }
            }

            chart2.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                chart2.Series[0].Points.AddXY(i, hist2[i]);
            }

            pictureBox2.Image = resultado;
            img2 = resultado;
            resultadoGlobal = resultado;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

            if (img1 == null)
            {
                MessageBox.Show("Carregue a imagem primeiro!");
                return;
            }

            int[] hist = new int[256];

            for (int i = 0; i < img1.Width; i++)
            {
                for (int j = 0; j < img1.Height; j++)
                {
                    Color pixel = img1.GetPixel(i, j);
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;
                    hist[gray]++;
                }
            }

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                chart1.Series[0].Points.AddXY(i, hist[i]);
            }
        }
        

        private void chart2_Click(object sender, EventArgs e)
        {
           
            if (resultadoGlobal == null)
            {
                MessageBox.Show("Faça a equalização primeiro!");
                return;
            }

            int[] hist2 = new int[256];

            for (int i = 0; i < resultadoGlobal.Width; i++)
            {
                for (int j = 0; j < resultadoGlobal.Height; j++)
                {
                    Color pixel = resultadoGlobal.GetPixel(i, j);
                    int gray = pixel.R;

                    hist2[gray]++;
                }
            }

            chart2.Series[0].Points.Clear();

            for (int i = 0; i < 256; i++)
            {
                chart2.Series[0].Points.AddXY(i, hist2[i]);
            }
        }

    }
}




