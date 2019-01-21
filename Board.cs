using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


//ACIMA = 0
//ABAIXO = 1
//ESQUERDA = 2
//DIREITA = 3

namespace QLearningTrabalho
{
    public partial class Board : Form
    {
        DataTable estados_valores;
        DataTable dt;
        DataTable setas;
        Random rnd = new Random();
        float num_linhas;
        float num_colunas;
        float valor_base;
        float estado_inicial;
        int iteracoes;
        float estado_atual;
        int iteracoes_internas;
        ArrayList num_passos = new ArrayList();
        int numero_it;
        int divisor_iteracoes;


        public Board()
        {
            InitializeComponent();
        }
        
        private void Board_Load(object sender, EventArgs e)
        {
            

        }

        public void carregarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog carregaArquivo_janela = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            carregaArquivo_janela.DefaultExt = "*.txt";
            carregaArquivo_janela.Filter = "TXT Files|*.txt";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (carregaArquivo_janela.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               carregaArquivo_janela.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                string[] linhas_Arquivo = File.ReadAllLines(carregaArquivo_janela.FileName);
                //pegando numero de linhas e colunas do arquivo
                num_linhas = Convert.ToSingle((linhas_Arquivo[0].Remove(0, 2)), CultureInfo.InvariantCulture);
                num_colunas = Convert.ToSingle((linhas_Arquivo[1].Remove(0, 2)), CultureInfo.InvariantCulture);
                valor_base = Convert.ToSingle((linhas_Arquivo[2].Remove(0, 2)), CultureInfo.InvariantCulture);

                int num_estados = (int)num_linhas * (int)num_colunas;

                //Cria Tabela
                dt = new DataTable();
                for (int tab_col = 0; tab_col < num_colunas; tab_col++)
                {
                    dt.Columns.Add(Convert.ToString(tab_col), typeof(float));
                }

                for (int tab_lin = 0; tab_lin < num_linhas; tab_lin++)
                {
                    dt.Rows.Add();
                }
                
                dataGridQL.DataSource = dt;

                //Alinha valores no centro da célula
                for (int tab_col = 0; tab_col < num_colunas; tab_col++)
                {
                    this.dataGridQL.Columns[Convert.ToString(tab_col)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }

                this.dataGridQL.Rows[0].Selected = false; //zera seletor inicial

                //separar linhas do tabuleiro em colunas e colorir paredes
                for (int i = 3; i <= (num_linhas + 2);i++)
                {
                    string[] linha_separada = linhas_Arquivo[i].Split(' ');
                    for (int j = 0; j <= (num_colunas - 1); j++)
                    {
                        if (linha_separada[j] == "X" || linha_separada[j] == "x")
                        {
                            //pinta as paredes do cenario
                            this.dataGridQL.Rows[i-3].Cells[j].Style.BackColor = Color.Black;
                        }
                    }
                }

                //colocar os valores da matriz
                for (int i = ((int)num_linhas + 3); i < linhas_Arquivo.Length; i++)
                {
                   string[] linha_separada = linhas_Arquivo[i].Split(' ');
                   for (int j = 0; j <= (num_colunas - 1); j++)
                   {
                       
                       if (linha_separada[j] == "D" || linha_separada[j] == "d")
                       {
                           dt.Rows[i - ((int)num_linhas + 3)][j] = valor_base;
                           this.dataGridQL.Rows[i - ((int)num_linhas + 3)].Cells[j].Value = valor_base;
                       } else
                       {
                           if(linha_separada[j] != "X" && linha_separada[j] != "x" )
                           {
                               dt.Rows[i - ((int)num_linhas + 3)][j] = Convert.ToSingle(linha_separada[j], CultureInfo.InvariantCulture);
                               this.dataGridQL.Rows[i - ((int)num_linhas + 3)].Cells[j].Value = Convert.ToSingle(linha_separada[j], CultureInfo.InvariantCulture);
                               this.dataGridQL.Rows[i - ((int)num_linhas + 3)].Cells[j].Style.BackColor = Color.RoyalBlue;
                               this.dataGridQL.Rows[i - ((int)num_linhas + 3)].Cells[j].Style.ForeColor = Color.White;
                           }
                       }               
                   }
                }

                estados_valores = new DataTable();
                estados_valores.Columns.Add("Acima", typeof(float));
                estados_valores.Columns.Add("Abaixo", typeof(float));
                estados_valores.Columns.Add("Esquerda", typeof(float));
                estados_valores.Columns.Add("Direita", typeof(float));
                estados_valores.Columns.Add("Estado", typeof(float));

                float valor_estado = 0;
                float vezes = 0;
                
                //montar tabela de estados e valores de iteração, quinto é o indice na tabela
                for (int i = 1; i <= (int)(num_linhas * num_colunas); i++)
                {
                    
                    estados_valores.Rows.Add(0, 0, 0, 0, valor_estado);
                   

                    if (i % num_colunas == 0)
                    {
                        vezes++;
                        valor_estado = 10 * vezes;
                    }
                    else
                    {
                        valor_estado++;
                    }
                }
                estado_inicial = (num_linhas - 1) * 10;

                for(int linha = 0; linha < num_linhas; linha++)
                {
                    for (int coluna = 0; coluna < num_colunas; coluna++)
                    {
                        if(this.dataGridQL.Rows[linha].Cells[coluna].Style.BackColor == Color.RoyalBlue)
                        {
                            inserir_valor_tab_valores(linha, coluna, (float)dt.Rows[linha][coluna]);
                        }
                    }                        
                }

            }
        }

        private void salvarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvaArquivo_janela = new SaveFileDialog();
            salvaArquivo_janela.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (salvaArquivo_janela.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(salvaArquivo_janela.FileName))
                {
                    sw.WriteLine("Número de Iterações: " + numero_iteracoes.Text + " | Divisor de Iterações: " + divisorIteracoes.Text + " | Alfa: " + alfaText.Text + " | Beta: " + gamaText.Text);
                    sw.WriteLine("\n Iterações -  Passos  ");
                    int j = 1;
                    foreach (int i in num_passos)
                    {
                        sw.WriteLine(" " + j + " - " + i + "\n");
                        j++;
                    }
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void inserir_valor_tab_valores (int linha, int coluna, float valor)
        {
            float estado = (linha * 10) + coluna;
            int linha_do_estado = 0;

            for(int i = 0; i < (num_colunas * num_linhas); i++)
            {
                if(estado == (float)estados_valores.Rows[i][4])
                {
                    linha_do_estado = i;
                }
            }

            for(int j = 0; j < 4; j++)
            {
                estados_valores.Rows[linha_do_estado][j] = valor;
            }

        }

        //verifica se existe o estado passado na tabela de estados
        public Boolean existe_estado (float estado_atual)
        {
            Boolean existe_estado = false;

            for (int i = 0; i < (int)(num_linhas * num_colunas); i++)
            {
                if ((float)estados_valores.Rows[i][4] == estado_atual)
                {
                    existe_estado = true;
                }
            }

            return existe_estado;
        }

        public float retorna_valor_tabela_estados_valores (int linha, int coluna)
        {
            float estado = linha * 10 + coluna;
            int linha_estado = 0;
            float maior_valor = -9999999;

            for(int i = 0; i < (num_colunas*num_linhas); i++)
            {
                if(estado == (float)estados_valores.Rows[i][4])
                {
                    linha_estado = i;
                }
            }

            for (int j = 0; j < 4; j++)
            {
                if((float)estados_valores.Rows[linha_estado][j] > maior_valor)
                {
                    maior_valor = (float)estados_valores.Rows[linha_estado][j]; 
                }
            }

            return maior_valor;
        }

        //procura o maior valor na tabela de estados
        public int maior_valor_dos_estados_proximos(float estado_atual) 
        {
            int lado_a_seguir = 5;

            float maior_valor = -999999;
            //procura na tabela de valores dos lados o estado_atual e verifica o maior valor entre os lados
            //retorna o lado a seguir
            int linha = (int)estado_atual / 10;
            int coluna = (int)estado_atual - (linha * 10);

            

            //procura acima
            if ((verifica_fora_da_tabela(linha - 1, coluna) == false) && (verifica_parede(linha - 1, coluna) == false))
            {
                if (maior_valor < retorna_valor_tabela_estados_valores(linha - 1, coluna))
                {
                    maior_valor = retorna_valor_tabela_estados_valores(linha - 1,coluna);
                    lado_a_seguir = 0;
                }
            }
            //procura abaixo
            if ((verifica_fora_da_tabela(linha + 1, coluna) == false) && (verifica_parede(linha + 1, coluna) == false))
            {
                if (maior_valor < retorna_valor_tabela_estados_valores(linha + 1, coluna))
                {
                    maior_valor = retorna_valor_tabela_estados_valores(linha + 1, coluna);
                    lado_a_seguir = 1;
                }
            }
           //procura esquerda
            if ((verifica_fora_da_tabela(linha, coluna - 1) == false) && (verifica_parede(linha, coluna - 1) == false))
            {
                if (maior_valor < retorna_valor_tabela_estados_valores(linha, coluna - 1))
                {
                    maior_valor = retorna_valor_tabela_estados_valores(linha, coluna - 1);
                    lado_a_seguir = 2;
                }
            }
           //procura direita
            if ((verifica_fora_da_tabela(linha, coluna + 1) == false) && (verifica_parede(linha, coluna + 1) == false))
            {
                if (maior_valor < retorna_valor_tabela_estados_valores(linha, coluna + 1))
                {
                    maior_valor = retorna_valor_tabela_estados_valores(linha, coluna + 1);
                    lado_a_seguir = 3;
                }
            }

            if(lado_a_seguir == 5)
            {
                MessageBox.Show("Não há lados disponíveis para ir partindo deste estado.", "Nenhum passo possível!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lado_a_seguir;
        }

        public float qual_estado (int lado, float estado_atual)
        {
            float estado_a_seguir = 0;
           
            int linha = (int)estado_atual / 10;
            int coluna = (int)estado_atual - (linha * 10);       

            switch (lado)
            {
                case 0:
                    //ACIMA
                    linha--;
                    break;
                case 1:
                    //ABAIXO
                    linha++;
                    break;
                case 2:
                    //ESQUERDA
                    coluna--;
                    break;
                default:
                    //DIREITA
                    coluna++;
                    break;
            }

            if( verifica_fora_da_tabela(linha, coluna))
            {
                estado_a_seguir = -99;
            }
            else
            {
                estado_a_seguir = (linha * 10) + (coluna);
            }

            return estado_a_seguir;
        }

        public Boolean verifica_fora_da_tabela (int linha, int coluna)
        {
            Boolean verifica_fora_da_tabela = false;

            if( ((linha >= num_linhas) || (linha < 0)) || ((coluna >= num_colunas) || (coluna < 0) ))
            {
                verifica_fora_da_tabela = true;
            }

            return verifica_fora_da_tabela;
        }

        public Boolean verifica_parede (int linha, int coluna)
        {
            Boolean verifica_parede = false;

            if(dataGridQL.Rows[linha].Cells[coluna].Style.BackColor == Color.Black)
            {
                verifica_parede = true;
            }

            return verifica_parede;
        }

        public float retorna_valor_estado (int linha, int coluna)
        {
            float valor;

            valor = (float)dataGridQL.Rows[linha].Cells[coluna].Value;

            return valor;
        }

        public int atualiza_valor_tabelaQ (float estado_anterior, float estado_proximo, int lado_a_atualizar, float alfa, float gama)
        {
            float maior_valor = -99999999999999999;
            //procura na tabela de valores dos lados o estado_atual e verifica o maior valor entre os lados
            int linha = (int)estado_proximo / 10;
            int coluna = (int)estado_proximo - (linha * 10);
            int linha_do_estado_anterior = 0;
            int linha_do_proximo_estado = 0;

            //procura linha que tem o mesmo valor na tabela estados_valores;
            for (int j = 0; j < (num_colunas * num_linhas); j++)
            {
                if((float)estados_valores.Rows[j][4] == estado_anterior)
                {
                    linha_do_estado_anterior = j;
                }
            }

            //procura linha que tem o mesmo valor na tabela estados_valores;
            for (int j = 0; j < (num_colunas * num_linhas); j++)
            {
                if ((float)estados_valores.Rows[j][4] == estado_proximo)
                {
                    linha_do_proximo_estado = j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if ((float)estados_valores.Rows[linha_do_proximo_estado][i] > maior_valor)
                {
                    maior_valor = (float)estados_valores.Rows[linha_do_proximo_estado][i];
                }
            }


            //
            //Q(estado_anterior, lado_selecionado_para_ir) = (1 - alfa) * (valor atual do Q(estado_anterior, lado_selecionado_para_ir)) + alfa * (recompensa do estado que quer ir + (gama * maior_valor_do_proximo_estado)))
            //
            // se o próximo estado é terminal, atualiza seu valor também
            if ((float)dt.Rows[linha][coluna] != valor_base)
            {
                estados_valores.Rows[linha_do_estado_anterior][lado_a_atualizar] = (((1 - alfa) * ((float)estados_valores.Rows[linha_do_estado_anterior][lado_a_atualizar])) + (alfa * (retorna_valor_estado(linha, coluna))));
            }
            else
            {
                estados_valores.Rows[linha_do_estado_anterior][lado_a_atualizar] = (((1 - alfa) * ((float)estados_valores.Rows[linha_do_estado_anterior][lado_a_atualizar])) + (alfa * (retorna_valor_estado(linha, coluna) + (gama * maior_valor))));
            }
            return 0;
        }

        public float QLearning (float alfa, float gama, float r, float estado_atual, Boolean explorar)
        {
            int lado_random = 0;
            int lado_a_seguir = 0;
            int linha;
            int coluna;

            float novo_estado = 0;

            //verifica se o modo explorador esta ativado
            if (explorar == true)
            {
                lado_a_seguir = rnd.Next(0,4);
            }
            else //se nao tiver so acha o maior valor entre os lados
            {
                lado_a_seguir = maior_valor_dos_estados_proximos(estado_atual);
            }

            

            int chance_acertar = rnd.Next(0, 101);

            if (chance_acertar > 80)
            {
                if(lado_a_seguir == 0)
                {
                    lado_random = rnd.Next(2, 4);

                    if(lado_a_seguir == 2)
                    {
                        lado_a_seguir = 2;
                    }
                    else
                    {
                        lado_a_seguir = 3;
                    }
                }
                if (lado_a_seguir == 1)
                {
                    lado_random = rnd.Next(2, 4);

                    if (lado_a_seguir == 2)
                    {
                        lado_a_seguir = 2;
                    }
                    else
                    {
                        lado_a_seguir = 3;
                    }
                }
                if (lado_a_seguir == 2)
                {
                    lado_random = rnd.Next(0, 2);

                    if (lado_a_seguir == 0)
                    {
                        lado_a_seguir = 0;
                    }
                    else
                    {
                        lado_a_seguir = 1;
                    }
                }
                if (lado_a_seguir == 3)
                {
                    lado_random = rnd.Next(0, 2);

                    if (lado_a_seguir == 0)
                    {
                        lado_a_seguir = 0;
                    }
                    else
                    {
                        lado_a_seguir = 1;
                    }
                }
            }

            novo_estado = qual_estado(lado_a_seguir, estado_atual);

            //testa se o lado a seguir é parede ou se nao faz parte do mapa
            linha = (int)novo_estado / 10;
            coluna = (int)novo_estado - (linha * 10);

            //verifica parede e verifica se esta fora dos limites da tabela, se tiver qualquer uma dessas condições não pode atualizar o valor na tabela, mantem em zero o valor, só repassa novamente o estado atual
            if(verifica_fora_da_tabela(linha, coluna))
            {
                novo_estado = estado_atual;
            }
            else //se não for parede ou fora da tabela, atualiza valor e determina o novo estado
            {
                if(verifica_parede(linha,coluna))
                {
                    novo_estado = estado_atual;
                }
                else
                {
                    atualiza_valor_tabelaQ(estado_atual, novo_estado, lado_a_seguir, alfa, gama);
                }
            }

            return novo_estado;
        }

        private void botaoRodar_Click(object sender, EventArgs e)
        {
            //zera iterações
            iteracoes = 0;
            divisor_iteracoes = Convert.ToInt32(divisorIteracoes.Text);
            //pega valores alfa e gama do text
            float alfa = Convert.ToSingle(alfaText.Text, CultureInfo.InvariantCulture);
            float gama = Convert.ToSingle(gamaText.Text, CultureInfo.InvariantCulture);
            int mostrar = Convert.ToInt32(mostrarQuantas.Text);
            numero_it = int.Parse(numero_iteracoes.Text);

            //pega a linha inicial e a coluna que é sempre zero para iniciar o while
            int linha = (int)estado_inicial/10;
            int coluna = 0;
            int chance;
            estado_atual = estado_inicial;

            num_passos.Clear();

            //Enquanto não clicar no botão STOP
            while (iteracoes < numero_it)
            {
                estado_atual = estado_inicial;
                iteracoes++;
                iteracoes_internas = 0;

                //Enquanto for igual ao valor base continua rodando o algoritmo
                while ((float)dt.Rows[linha][coluna] == valor_base)
                {
                    //colorir o estado_atual
                    dataGridQL.Rows[linha].Cells[coluna].Style.BackColor = Color.LightSteelBlue;

                    if ((iteracoes > (numero_it - (1 + (int)(mostrar / 2)))) || (iteracoes < (int)(mostrar / 2)))
                    {
                        dataGridQL.Update();
                        Thread.Sleep(10);
                    }

                    //calcula chance de exploração
                    if (iteracoes > (int)(numero_it / divisor_iteracoes))
                    {
                        chance = 99;
                    }
                    else
                    {
                        chance = 50;
                    }
                    int random_chance = rnd.Next(0, 101);

                    //EXPLORER MODE ON
                    if(random_chance >= chance)
                    {
                        dataGridQL.Rows[linha].Cells[coluna].Style.BackColor = Color.SteelBlue;
                        estado_atual = QLearning(alfa,gama,valor_base,estado_atual,true);
                     }
                    else //EXPLORER OFF
                    {
                        dataGridQL.Rows[linha].Cells[coluna].Style.BackColor = Color.SteelBlue;
                        estado_atual = QLearning(alfa, gama, valor_base,estado_atual, false);
                     }

                    iteracoes_internas++;

                    
                    //calcula linha e coluna do estado atual, para verificar se é igual valor base
                    linha = (int)estado_atual / 10;
                    coluna = (int)estado_atual - (linha * 10);
                    dataGridQL.Rows[linha].Cells[coluna].Style.BackColor = Color.LightSteelBlue;

                }

                num_passos.Add(iteracoes_internas);

                if ((iteracoes > (numero_it - (1 + (int)(mostrar / 2)))) || (iteracoes < (int)(mostrar / 2)))
                {
                    dataGridQL.Update();
                    Thread.Sleep(1000);
                }

                //volta pra posicao inicial quando achar um estado terminal
                linha = (int)estado_inicial / 10;
                coluna = 0;

                //RESETA CORES DO DATAGRID
                for (int i = 0; i < num_linhas; i++)
                {
                    for (int j = 0; j < num_colunas; j++)
                    {
                        if (dataGridQL.Rows[i].Cells[j].Style.BackColor == Color.SteelBlue)
                        {
                            dataGridQL.Rows[i].Cells[j].Style.BackColor = Color.White;
                        }

                        if(dataGridQL.Rows[i].Cells[j].Style.ForeColor == Color.White)
                        {
                            dataGridQL.Rows[i].Cells[j].Style.BackColor = Color.RoyalBlue;
                        }
                    }
                }
            }

            

        }

        private void gerarVisualizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeResultados resultados = new ExibeResultados();
            ExibeSetas setas_form = new ExibeSetas();

            setas = new DataTable();

            for (int tab_col = 0; tab_col < num_colunas; tab_col++)
            {
                setas.Columns.Add(Convert.ToString(tab_col), typeof(string));
            }

            for (int tab_lin = 0; tab_lin < num_linhas; tab_lin++)
            {
                setas.Rows.Add();
            }

            int lado_maior_valor = 0;
            float maior_valor = -999999;
            int lin = 0;
            int col = 0;
            string lado = "";

            for(int i = 0; i < (int)(num_linhas * num_colunas); i++)
            {
                maior_valor = -999999;

                for(int j = 0; j < 4; j++)
                {
                    if((float)estados_valores.Rows[i][j] > maior_valor)
                    {
                        if((float)estados_valores.Rows[i][j] != 0)
                        {
                            lado_maior_valor = j;
                            maior_valor = (float)estados_valores.Rows[i][j];
                        }
                    }
                }

                if(lado_maior_valor == 0)
                {
                    lado = "↑";
                }
                if (lado_maior_valor == 1)
                {
                    lado = "↓";
                }
                if (lado_maior_valor == 2)
                {
                    lado = "←";
                }
                if (lado_maior_valor == 3)
                {
                    lado = "→";
                }

                if(col < num_colunas)
                {
                    setas.Rows[lin][col] = lado;
                    if(dataGridQL.Rows[lin].Cells[col].Style.BackColor == Color.Black)
                    {
                        setas.Rows[lin][col] = "X";
                    }
                    col++;
                }
                else 
                {
                    col = 0;
                    lin++;
                    setas.Rows[lin][col] = lado;
                    if (dataGridQL.Rows[lin].Cells[col].Style.BackColor == Color.Black)
                    {
                        setas.Rows[lin][col] = "X";
                    }
                    col++;
                }               

            }

            //procura terminais e seta como Terminais
            for (int linhas = 0; linhas < num_linhas; linhas++)
            {
                for (int colunas = 0; colunas < num_colunas; colunas++)
                {
                    if (dataGridQL.Rows[linhas].Cells[colunas].Style.BackColor == Color.RoyalBlue)
                    {
                      setas.Rows[linhas][colunas] = "Terminal";
                    }
                }
            }

            setas_form.dataGridSetas.DataSource = setas;

            for (int tab_col = 0; tab_col < num_colunas; tab_col++)
            {
                setas_form.dataGridSetas.Columns[Convert.ToString(tab_col)].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            setas_form.Show();

            resultados.dataGridValoresEstados.DataSource = estados_valores;
            resultados.Show();

        }

        private void numeroDePassosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumeroPassos numeroPassos = new NumeroPassos();
            int j = 1;
            foreach (int i in num_passos)
            {
                numeroPassos.graficoPassos.Series["Passos"].Points.AddXY(j,i);
                j++;
            }

            numeroPassos.Show();
                
        }

    }
}


