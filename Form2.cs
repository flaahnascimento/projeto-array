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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       

        int[] numeros = new int[4];
        int indice = 0;
        int total;
        int maior, menor;

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            total = numeros.Sum();
            txttotal.Text = total.ToString(); 
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
           int maior = numeros[0];
           int menor = numeros[0];

            txtmaior.Text = maior.ToString();
            txtmenor.Text = menor.ToString();


            for (int j = 1; j < numeros.Length; j++)
            {
                if (numeros[j] > maior)
                {
                   
                    maior = (numeros[j]);

                }

                else if (numeros[j] < menor)
                {
                   
                    menor = numeros[j];
                }
            }
            txtmaior.Text = maior.ToString();
            txtmenor.Text = menor.ToString();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (indice < numeros.Length)
            {
                numeros[indice] = int.Parse(txtnumero.Text);
                indice++; 


                txtnumero.Clear();
                txtnumero.Focus();

            }
            else
            {
                BtnAdd.Enabled = false;
            }

            #region
            /* explicançao
             * 
             * criando um vetor publico, para acessar em todas etapas e botoes.
             * criando variavel indice=0 que inicializa no zero, lembrando que o vetor tem 3 indices "0,1,2,3" e 4 elementos "4 posicoes"
             * criei outras variaveis publicas
             * 
             * // e vou codificar em uma area local/privada do botaoadd 
             * if (indice < numeros.Length)
             (se o indice que inicia no zero for menor que o numero total de elementos ) execute as chaves
             * numeros[indice] = int.Parse(txtnumero.Text); indice++; 
             (vetor numeros[indice] recebe o que o usuario digitou no textbox) (indice soma mais 1 e na proxima execuçao mostra o valor do proximo elemento)
             * limpei a caixinha pro proximo numero e sem preisar clicar o usuario pode digitar outro numero
             * botao adicionar recebe o tipo bool false para tirar a funcionalidade e evitar 2 clicks e atrapalhar a execuçao
             
             * //e vou codificar em uma area local/privada do botaocalcule
             * variavel total recebe vetor.Sum(); que soma todo o conteudo do array
             * textbox.text consegue mostrar o que esta na variavel atraves do ToString();
             * 
             * //e vou codificar em uma area local/privada do botaoexibir
             * coloquei as duas variaveis maior e menor para receberem o vetor no indice zero para ser sempre valido
             * fiz com que os textbox mostrem em texto o que esta nas variaveis
             * enquanto (variavel que declarei so pro for recebe o incrementador; j que agora e o incrementador ser menor que o total de elementos, j soma mais 1)
             se o vetor[indice definido pelo j que soma 1 e muda a cada execuçao for maior que a variavel maior que inicia no zero] execute maior recebe o vetor e seu indice
            *por fim faço o textbox mostrar o que esta dentro das variaveis maior e menor atravez da conversao dos valores das variveis para texto .Tostring
             */
            #endregion
        }

    }
}
