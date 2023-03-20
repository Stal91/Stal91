using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao=0;

        public ListaDeContasCorrentes(int TamanhoInicial=5)
        {
            _itens= new ContaCorrente[TamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adiconando item na posicao {_proximaPosicao}");
            VerificarCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamahoNecessario)
        {
            if (_itens.Length >= tamahoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamahoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
            }
            _itens= novoArray;


        }
                                                 
        public void Remover(ContaCorrente conta) // 0 1 2 3 4
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente contaAtual = _itens[i];
                if (contaAtual == conta)
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < _itens.Length; i++)
            {
                if(_itens[i] != null)
                {   
                    var conta =_itens[i];
                    Console.WriteLine($" Indice[{i}] = Conta:{conta.Conta} - N° da Agência: {conta.Numero_agencia}");
                }
            }
        }

        public ContaCorrente RecuperarContaNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));

            }
            return _itens[indice];
        }
        public int Tamanho 
        {
            get
            {
                return _proximaPosicao;
            }
        } 

//Alternativa Correta. Para criar um indexador, 
//precisamos usar a palavra reservada this com um índice inteiro em uma 
//estrutura bem parecida a uma propriedade e definir a forma de recuperar um
//elemento do vetor interno da classe.
        public ContaCorrente this[int indice]
        {
            get
            {
                return RecuperarContaNoIndice(indice);
            }
        }
          
    }

    
}
