using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios
{
    internal class NoLista
    {
        public int chave;
        public NoLista prox;
        public NoLista(int c)
        {
            chave = c;
            prox = null;
        }
    }

    class Lista
    {
        private NoLista prim, ult;

        public Lista()
        {
            prim = ult = null;
        }

        public void Inserir(NoLista item)
        {
            if (prim == null)
                prim = item;
            else
                ult.prox = item;
            ult = item;
        }

        public void Imprimir()
        {
            NoLista aux = prim;
            while (aux != null)
            {
                Console.WriteLine(aux.chave);
                aux = aux.prox;
            }
        }

        public NoLista Pesquisar(int c)
        {
            NoLista aux = prim;
            while (aux != null && aux.chave != c)
            {
                aux = aux.prox;
            }
            return aux;
        }

        public bool Remover(int c)
        {
            NoLista aux = prim, ant = null;
            while (aux != null && aux.chave != c)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux != null)
            {
                if (ant != null) // não é o primeiro 
                    ant.prox = aux.prox;
                else // é o primeiro
                    prim = aux.prox;
                if (aux == ult) // é o último
                    ult = ant;
                aux.prox = null; // desconecta o nó da lista
                return true;
            }
            return false;
        }

        public double GetMediaChave()
        {
            // a) Escreva um método que calcule e retorne a média das chaves armazenadas nos nós.
            NoLista aux = prim;
            int media, cont;
            media = cont = 0;
            while (aux != null)
            {
                cont++;
                media = aux.chave;
                aux = aux.prox;
            }
            return (double)media / cont;
        }

        public int GetLength()
        {
            // b) Escreva um método que retorne o número de elementos armazenados na lista.
            int tamanho = 0;
            NoLista aux = prim;
            while (aux != null)
            {
                tamanho++;
                aux = aux.prox;
            }
            return tamanho;
        }

        public NoLista GetNo(int indice)
        {
            /* c) Escreva um método denominado GetNo que retorne o nó correspondente ao número passado
            como parâmetro. Caso o nó não exista, retorne null.Ex.: GetNo(0) deverá retornar o primeiro nó
            da lista, GetNo(1) o segundo e assim sucessivamente.
            */

            NoLista aux = prim;
            int cont = 0;
            while (aux != null)
            {
                if (cont == indice)
                {
                    Console.WriteLine(aux.chave);
                    return aux;
                }

                cont++;
                aux = aux.prox;
            }
            Console.WriteLine("Null");
            return null;
        }

        public NoLista GetMaiorChave()
        {
            // d) Escreva um método que retorne o nó com a maior chave.
            NoLista aux = prim;
            NoLista maior = prim;
            while(aux != null)
            {
                if (aux.chave > maior.chave)
                {
                    maior = aux;
                }
                aux = aux.prox;
            }
            Console.WriteLine(maior.chave);
            return maior;
        }

        public void AddItens(Fila f)
        {
            // e) Escreva um método que receba como parâmetro uma Fila e adicione os itens desta fila na lista. 
            while(!f.Vazia())
            {
                Inserir(new NoLista(f.Desenfileirar()));     
            }
        }


        public void TrocarChaves()
        {
            /*
              f) Escreva um método que troque as chaves entre os nós da seguinte maneira: o primeiro receberá a
              chave do segundo, o segundo receberá a do terceiro e assim sucessivamente, até que o último
              receba a chave do primeiro.
             */
            /*
            ult = prim;
            NoLista aux = ult;
            prim.prox = null;

            while(aux != null)
            {
                aux = aux.prox;
            }
            */
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
              
            NoLista aux = prim;
                int chaveAux = aux.chave;
                while (aux != ult)
                {
                    aux.chave = aux.prox.chave;
                    aux = aux.prox;
                }
                ult.chave = chaveAux;
                ult.prox = null;

            
        }


    }
}
