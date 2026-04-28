namespace Projeto_final_Novo_e_atualizado_certo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btCarregarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btSalvarImagem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.carregar2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btSomarImagem = new System.Windows.Forms.Button();
            this.btSubtImagem = new System.Windows.Forms.Button();
            this.BrilhoUp = new System.Windows.Forms.NumericUpDown();
            this.Abrilho = new System.Windows.Forms.Button();
            this.BrilhoDown = new System.Windows.Forms.NumericUpDown();
            this.Dbrilho = new System.Windows.Forms.Button();
            this.btCinza = new System.Windows.Forms.Button();
            this.InvLat = new System.Windows.Forms.Button();
            this.InvVert = new System.Windows.Forms.Button();
            this.Diff = new System.Windows.Forms.Button();
            this.MultiplicarImagem = new System.Windows.Forms.Button();
            this.DividirImagem = new System.Windows.Forms.Button();
            this.ValorDiv = new System.Windows.Forms.NumericUpDown();
            this.ValorMultip = new System.Windows.Forms.NumericUpDown();
            this.BlendBttn = new System.Windows.Forms.Button();
            this.BlendNumber = new System.Windows.Forms.NumericUpDown();
            this.Média = new System.Windows.Forms.Button();
            this.AndAnd = new System.Windows.Forms.Button();
            this.OrOr = new System.Windows.Forms.Button();
            this.NotNot = new System.Windows.Forms.Button();
            this.XorXor = new System.Windows.Forms.Button();
            this.Limiazizacao = new System.Windows.Forms.Button();
            this.valorLimiar = new System.Windows.Forms.NumericUpDown();
            this.Negativo = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btEqualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMultip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlendNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLimiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // btCarregarImagem
            // 
            this.btCarregarImagem.Location = new System.Drawing.Point(37, 184);
            this.btCarregarImagem.Name = "btCarregarImagem";
            this.btCarregarImagem.Size = new System.Drawing.Size(163, 37);
            this.btCarregarImagem.TabIndex = 0;
            this.btCarregarImagem.Text = "Carregar Imagem";
            this.btCarregarImagem.UseVisualStyleBackColor = true;
            this.btCarregarImagem.Click += new System.EventHandler(this.btCarregarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(931, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // btSalvarImagem
            // 
            this.btSalvarImagem.Location = new System.Drawing.Point(947, 184);
            this.btSalvarImagem.Name = "btSalvarImagem";
            this.btSalvarImagem.Size = new System.Drawing.Size(163, 37);
            this.btSalvarImagem.TabIndex = 3;
            this.btSalvarImagem.Text = "Salvar Imagem";
            this.btSalvarImagem.UseVisualStyleBackColor = true;
            this.btSalvarImagem.Click += new System.EventHandler(this.btSalvarImagem_Click);
            // 
            // carregar2
            // 
            this.carregar2.Location = new System.Drawing.Point(300, 184);
            this.carregar2.Name = "carregar2";
            this.carregar2.Size = new System.Drawing.Size(163, 37);
            this.carregar2.TabIndex = 4;
            this.carregar2.Text = "Carregar Imagem";
            this.carregar2.UseVisualStyleBackColor = true;
            this.carregar2.Click += new System.EventHandler(this.carregar2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(280, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(202, 161);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btSomarImagem
            // 
            this.btSomarImagem.Location = new System.Drawing.Point(687, 13);
            this.btSomarImagem.Name = "btSomarImagem";
            this.btSomarImagem.Size = new System.Drawing.Size(128, 32);
            this.btSomarImagem.TabIndex = 6;
            this.btSomarImagem.Text = "Somar Imagem";
            this.btSomarImagem.UseVisualStyleBackColor = true;
            this.btSomarImagem.Click += new System.EventHandler(this.btSomarImagem_Click);
            // 
            // btSubtImagem
            // 
            this.btSubtImagem.Location = new System.Drawing.Point(687, 51);
            this.btSubtImagem.Name = "btSubtImagem";
            this.btSubtImagem.Size = new System.Drawing.Size(128, 30);
            this.btSubtImagem.TabIndex = 7;
            this.btSubtImagem.Text = "Subtrair Imagem";
            this.btSubtImagem.UseVisualStyleBackColor = true;
            this.btSubtImagem.Click += new System.EventHandler(this.btSubtImagem_Click);
            // 
            // BrilhoUp
            // 
            this.BrilhoUp.DecimalPlaces = 2;
            this.BrilhoUp.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.BrilhoUp.Location = new System.Drawing.Point(617, 22);
            this.BrilhoUp.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BrilhoUp.Name = "BrilhoUp";
            this.BrilhoUp.Size = new System.Drawing.Size(48, 20);
            this.BrilhoUp.TabIndex = 8;
            this.BrilhoUp.ValueChanged += new System.EventHandler(this.BrilhoUp_ValueChanged);
            // 
            // Abrilho
            // 
            this.Abrilho.Location = new System.Drawing.Point(513, 12);
            this.Abrilho.Name = "Abrilho";
            this.Abrilho.Size = new System.Drawing.Size(98, 37);
            this.Abrilho.TabIndex = 9;
            this.Abrilho.Text = "Aumentar brilho";
            this.Abrilho.UseVisualStyleBackColor = true;
            this.Abrilho.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrilhoDown
            // 
            this.BrilhoDown.DecimalPlaces = 2;
            this.BrilhoDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.BrilhoDown.Location = new System.Drawing.Point(617, 77);
            this.BrilhoDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BrilhoDown.Name = "BrilhoDown";
            this.BrilhoDown.Size = new System.Drawing.Size(48, 20);
            this.BrilhoDown.TabIndex = 10;
            this.BrilhoDown.ValueChanged += new System.EventHandler(this.BrilhoDown_ValueChanged);
            // 
            // Dbrilho
            // 
            this.Dbrilho.Location = new System.Drawing.Point(513, 67);
            this.Dbrilho.Name = "Dbrilho";
            this.Dbrilho.Size = new System.Drawing.Size(98, 37);
            this.Dbrilho.TabIndex = 11;
            this.Dbrilho.Text = "Diminuir brilho";
            this.Dbrilho.UseVisualStyleBackColor = true;
            this.Dbrilho.Click += new System.EventHandler(this.Dbrilho_Click);
            // 
            // btCinza
            // 
            this.btCinza.Location = new System.Drawing.Point(687, 87);
            this.btCinza.Name = "btCinza";
            this.btCinza.Size = new System.Drawing.Size(128, 30);
            this.btCinza.TabIndex = 12;
            this.btCinza.Text = "Acinzentar";
            this.btCinza.UseVisualStyleBackColor = true;
            this.btCinza.Click += new System.EventHandler(this.btCinza_Click_1);
            // 
            // InvLat
            // 
            this.InvLat.Location = new System.Drawing.Point(687, 123);
            this.InvLat.Name = "InvLat";
            this.InvLat.Size = new System.Drawing.Size(128, 30);
            this.InvLat.TabIndex = 13;
            this.InvLat.Text = "Inverção lateral";
            this.InvLat.UseVisualStyleBackColor = true;
            this.InvLat.Click += new System.EventHandler(this.InvLat_Click);
            // 
            // InvVert
            // 
            this.InvVert.Location = new System.Drawing.Point(687, 159);
            this.InvVert.Name = "InvVert";
            this.InvVert.Size = new System.Drawing.Size(128, 29);
            this.InvVert.TabIndex = 14;
            this.InvVert.Text = "Inverção Vertical";
            this.InvVert.UseVisualStyleBackColor = true;
            this.InvVert.Click += new System.EventHandler(this.InvVert_Click);
            // 
            // Diff
            // 
            this.Diff.Location = new System.Drawing.Point(687, 194);
            this.Diff.Name = "Diff";
            this.Diff.Size = new System.Drawing.Size(128, 27);
            this.Diff.TabIndex = 15;
            this.Diff.Text = "Diferença real";
            this.Diff.UseVisualStyleBackColor = true;
            this.Diff.Click += new System.EventHandler(this.Diff_Click);
            // 
            // MultiplicarImagem
            // 
            this.MultiplicarImagem.Location = new System.Drawing.Point(513, 119);
            this.MultiplicarImagem.Name = "MultiplicarImagem";
            this.MultiplicarImagem.Size = new System.Drawing.Size(98, 37);
            this.MultiplicarImagem.TabIndex = 16;
            this.MultiplicarImagem.Text = "Multiplicar";
            this.MultiplicarImagem.UseVisualStyleBackColor = true;
            this.MultiplicarImagem.Click += new System.EventHandler(this.MultiplicarImagem_Click_1);
            // 
            // DividirImagem
            // 
            this.DividirImagem.Location = new System.Drawing.Point(513, 171);
            this.DividirImagem.Name = "DividirImagem";
            this.DividirImagem.Size = new System.Drawing.Size(98, 37);
            this.DividirImagem.TabIndex = 17;
            this.DividirImagem.Text = "Dividir";
            this.DividirImagem.UseVisualStyleBackColor = true;
            this.DividirImagem.Click += new System.EventHandler(this.DividirImagem_Click_1);
            // 
            // ValorDiv
            // 
            this.ValorDiv.DecimalPlaces = 2;
            this.ValorDiv.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ValorDiv.Location = new System.Drawing.Point(617, 181);
            this.ValorDiv.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.ValorDiv.Name = "ValorDiv";
            this.ValorDiv.Size = new System.Drawing.Size(48, 20);
            this.ValorDiv.TabIndex = 18;
            this.ValorDiv.ValueChanged += new System.EventHandler(this.ValorDiv_ValueChanged_1);
            // 
            // ValorMultip
            // 
            this.ValorMultip.DecimalPlaces = 2;
            this.ValorMultip.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.ValorMultip.Location = new System.Drawing.Point(617, 129);
            this.ValorMultip.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.ValorMultip.Name = "ValorMultip";
            this.ValorMultip.Size = new System.Drawing.Size(48, 20);
            this.ValorMultip.TabIndex = 19;
            this.ValorMultip.ValueChanged += new System.EventHandler(this.ValorMultip_ValueChanged_1);
            // 
            // BlendBttn
            // 
            this.BlendBttn.Location = new System.Drawing.Point(513, 225);
            this.BlendBttn.Name = "BlendBttn";
            this.BlendBttn.Size = new System.Drawing.Size(98, 36);
            this.BlendBttn.TabIndex = 20;
            this.BlendBttn.Text = "Blending";
            this.BlendBttn.UseVisualStyleBackColor = true;
            this.BlendBttn.Click += new System.EventHandler(this.BlendBttn_Click);
            // 
            // BlendNumber
            // 
            this.BlendNumber.DecimalPlaces = 2;
            this.BlendNumber.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.BlendNumber.Location = new System.Drawing.Point(617, 235);
            this.BlendNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BlendNumber.Name = "BlendNumber";
            this.BlendNumber.Size = new System.Drawing.Size(48, 20);
            this.BlendNumber.TabIndex = 21;
            this.BlendNumber.ValueChanged += new System.EventHandler(this.BlendNumber_ValueChanged);
            // 
            // Média
            // 
            this.Média.Location = new System.Drawing.Point(687, 227);
            this.Média.Name = "Média";
            this.Média.Size = new System.Drawing.Size(128, 31);
            this.Média.TabIndex = 22;
            this.Média.Text = "Combinação linear";
            this.Média.UseVisualStyleBackColor = true;
            this.Média.Click += new System.EventHandler(this.Média_Click);
            // 
            // AndAnd
            // 
            this.AndAnd.Location = new System.Drawing.Point(687, 264);
            this.AndAnd.Name = "AndAnd";
            this.AndAnd.Size = new System.Drawing.Size(128, 28);
            this.AndAnd.TabIndex = 23;
            this.AndAnd.Text = "And";
            this.AndAnd.UseVisualStyleBackColor = true;
            this.AndAnd.Click += new System.EventHandler(this.AndAnd_Click);
            // 
            // OrOr
            // 
            this.OrOr.Location = new System.Drawing.Point(687, 298);
            this.OrOr.Name = "OrOr";
            this.OrOr.Size = new System.Drawing.Size(128, 30);
            this.OrOr.TabIndex = 24;
            this.OrOr.Text = "Or";
            this.OrOr.UseVisualStyleBackColor = true;
            this.OrOr.Click += new System.EventHandler(this.OrOr_Click);
            // 
            // NotNot
            // 
            this.NotNot.Location = new System.Drawing.Point(687, 334);
            this.NotNot.Name = "NotNot";
            this.NotNot.Size = new System.Drawing.Size(128, 28);
            this.NotNot.TabIndex = 25;
            this.NotNot.Text = "Not";
            this.NotNot.UseVisualStyleBackColor = true;
            this.NotNot.Click += new System.EventHandler(this.NotNot_Click);
            // 
            // XorXor
            // 
            this.XorXor.Location = new System.Drawing.Point(687, 368);
            this.XorXor.Name = "XorXor";
            this.XorXor.Size = new System.Drawing.Size(128, 27);
            this.XorXor.TabIndex = 26;
            this.XorXor.Text = "Xor";
            this.XorXor.UseVisualStyleBackColor = true;
            this.XorXor.Click += new System.EventHandler(this.XorXor_Click);
            // 
            // Limiazizacao
            // 
            this.Limiazizacao.Location = new System.Drawing.Point(513, 277);
            this.Limiazizacao.Name = "Limiazizacao";
            this.Limiazizacao.Size = new System.Drawing.Size(98, 35);
            this.Limiazizacao.TabIndex = 27;
            this.Limiazizacao.Text = "Limiarização";
            this.Limiazizacao.UseVisualStyleBackColor = true;
            this.Limiazizacao.Click += new System.EventHandler(this.Limiazizacao_Click);
            // 
            // valorLimiar
            // 
            this.valorLimiar.DecimalPlaces = 2;
            this.valorLimiar.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.valorLimiar.Location = new System.Drawing.Point(617, 286);
            this.valorLimiar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.valorLimiar.Name = "valorLimiar";
            this.valorLimiar.Size = new System.Drawing.Size(48, 20);
            this.valorLimiar.TabIndex = 28;
            this.valorLimiar.ValueChanged += new System.EventHandler(this.valorLimiar_ValueChanged);
            // 
            // Negativo
            // 
            this.Negativo.Location = new System.Drawing.Point(687, 401);
            this.Negativo.Name = "Negativo";
            this.Negativo.Size = new System.Drawing.Size(128, 27);
            this.Negativo.TabIndex = 29;
            this.Negativo.Text = "Negativo";
            this.Negativo.UseVisualStyleBackColor = true;
            this.Negativo.Click += new System.EventHandler(this.Negativo_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 405);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(303, 145);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.btEqualizar_Click);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(848, 405);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(303, 145);
            this.chart2.TabIndex = 31;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.btEqualizar_Click);
            // 
            // btEqualizar
            // 
            this.btEqualizar.Location = new System.Drawing.Point(687, 434);
            this.btEqualizar.Name = "btEqualizar";
            this.btEqualizar.Size = new System.Drawing.Size(128, 27);
            this.btEqualizar.TabIndex = 32;
            this.btEqualizar.Text = "Equalizar";
            this.btEqualizar.UseVisualStyleBackColor = true;
            this.btEqualizar.Click += new System.EventHandler(this.btEqualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 562);
            this.Controls.Add(this.btEqualizar);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Negativo);
            this.Controls.Add(this.valorLimiar);
            this.Controls.Add(this.Limiazizacao);
            this.Controls.Add(this.XorXor);
            this.Controls.Add(this.NotNot);
            this.Controls.Add(this.OrOr);
            this.Controls.Add(this.AndAnd);
            this.Controls.Add(this.Média);
            this.Controls.Add(this.BlendNumber);
            this.Controls.Add(this.BlendBttn);
            this.Controls.Add(this.ValorMultip);
            this.Controls.Add(this.ValorDiv);
            this.Controls.Add(this.DividirImagem);
            this.Controls.Add(this.MultiplicarImagem);
            this.Controls.Add(this.Diff);
            this.Controls.Add(this.InvVert);
            this.Controls.Add(this.InvLat);
            this.Controls.Add(this.btCinza);
            this.Controls.Add(this.Dbrilho);
            this.Controls.Add(this.BrilhoDown);
            this.Controls.Add(this.Abrilho);
            this.Controls.Add(this.BrilhoUp);
            this.Controls.Add(this.btSubtImagem);
            this.Controls.Add(this.btSomarImagem);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.carregar2);
            this.Controls.Add(this.btSalvarImagem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCarregarImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrilhoDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorMultip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlendNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valorLimiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCarregarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btSalvarImagem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button carregar2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btSomarImagem;
        private System.Windows.Forms.Button btSubtImagem;
        private System.Windows.Forms.NumericUpDown BrilhoUp;
        private System.Windows.Forms.Button Abrilho;
        private System.Windows.Forms.NumericUpDown BrilhoDown;
        private System.Windows.Forms.Button Dbrilho;
        private System.Windows.Forms.Button btCinza;
        private System.Windows.Forms.Button InvLat;
        private System.Windows.Forms.Button InvVert;
        private System.Windows.Forms.Button Diff;
        private System.Windows.Forms.Button MultiplicarImagem;
        private System.Windows.Forms.Button DividirImagem;
        private System.Windows.Forms.NumericUpDown ValorDiv;
        private System.Windows.Forms.NumericUpDown ValorMultip;
        private System.Windows.Forms.Button BlendBttn;
        private System.Windows.Forms.NumericUpDown BlendNumber;
        private System.Windows.Forms.Button Média;
        private System.Windows.Forms.Button AndAnd;
        private System.Windows.Forms.Button OrOr;
        private System.Windows.Forms.Button NotNot;
        private System.Windows.Forms.Button XorXor;
        private System.Windows.Forms.Button Limiazizacao;
        private System.Windows.Forms.NumericUpDown valorLimiar;
        private System.Windows.Forms.Button Negativo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btEqualizar;
    }
}

