using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_arrays
{
    public partial class Form3 : Form
    {

       
        public Form3()
        {
            InitializeComponent();
        }
        int coluna = 0;
        int linha = 0;

        int[,] matriz = new int[3, 3];

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            matriz[linha,coluna] = int.Parse(txtnumero.Text); 
            coluna++;

            if (coluna == 3) 
            {
                linha++;
                coluna = 0;

            }
            if (linha == 3 && coluna == 0)
            { 

                BtnAdicionar.Enabled = false;

            }

        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            for (linha = 0; linha < 3; linha++)
            {
                for (coluna = 0; coluna < 3; coluna++)
                {
                    txtlist.Items.Add("matriz[" + linha + "]" + "[" + coluna + "]" + " = " + matriz[linha, coluna]);

                }

                #region
                /*
                 * criei duas variaveis e iniciei no zero
                 * criei uma matriz do tipo int com 3 linhas, 3 colunas
                 *  .,btnadd
                 * matriz recebendo oq o usuario digitou no textbox
                 * coluna soma mais 1 quando executa a linha
                 * se (coluna for igual a 3) execute o que esta nas chaves[some mais 1 linha e a coluna inicia no zero]
                 * executou e caiu se (linha for igual a 3 e coluna for igual a 0) execute as chaves [ botao adicionar sem funcionalidade
                 *  .,btnexibir
                 *  enquanto linha (linha iniciar no zero; linha for menor que 3; linha some +1) execute as chaves
                 *  executou a chave - enquanto coluna( coluna iniciar no zero; coluna for menor que 3; coluna some +1) execute as chaves
                 *  execute - adicionando no txt list ("texto" contatena com [+linha]) contatena [+colunha] contatena "texto" contatena com amatriz)

                 */
                #endregion
            }
        
        }  
    }
}
