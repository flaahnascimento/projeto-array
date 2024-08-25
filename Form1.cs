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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numeros = new int[4];
        int indice = 0;
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (indice < numeros.Length)
            {

                numeros[indice] = int.Parse(txtnum.Text);
                indice++;


                txtnum.Clear();
                txtnum.Focus();


               
            }
            else
            {
                BtnAdicionar.Enabled = false;
            }
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {

            for (indice = 0; indice <= numeros.Length - 1; indice++)
            {

                txtlist.Items.Add(numeros[indice]);

            }
            indice = 0;


            #region
            /*

             -----// * variavel //

             1-vetor publico, para acessar em todas etapas e botoes.

             2- vetor com o tipo int, 4 posiçoes : int[] numeros = new int[4];


            -----// * if //

             1- o indice define a posicao do vetor. Que nesse caso, Inicia no zero :int indice = 0;

             2- se o indice "0,1,2,3" for menor que a quantidade de posicoes[4], execute
             if(indice < numeros.Length)

             3-vetor recebe o numero que o usuario digitou e some +1 no indice, que muda a posicao consequentemente

             4-limpei o textbox e voltei o foco para ele sem o usuario precisar de clicar

             5 - messagebox.show " contatena com a variavel indice para mostrar o num, posiçao
            MessageBox.Show("agora o indice e: " + indice);


            ----// * else //:  botao adicionar hablitado = false; botao iniciar interrupçao.

            // * for //
            1-enquanto o (indice  que inicia no zero; indice for menor ou igual 
             ao numero q representa a quantidade de posicoes [4] - 1 pois: "0,1,2,3"
             no caso nao tem o 4 no indice, e sim na posicao por isso precisa sub 1; indice soma + 1)

            2- o .Length obtem o numero total de posiçoes -
            "for (indice = 0; indice<=numeros.Length-1; indice++)"

            3-adicionando o (X) valor q esta guardado no vetor que a variavel indice

            4- mostra a cada posicao que vai executando (lembrando indice inicia no zero).
              txtlist.Items.Add(numeros[indice]);

            5-indice= 0;
             */
            #endregion

        }
    }
}
