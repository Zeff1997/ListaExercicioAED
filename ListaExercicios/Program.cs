using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Random random = new Random();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine();
                Console.Write("Número do exercicio, digite 0 para sair -> ");
                int exercicio = int.Parse(Console.ReadLine() ?? "0");

                switch (exercicio)
                {
                    case 0:
                        exit = false;
                        break;

                    case 1:
                        /*
                         Escreva um programa que preencha um vetor de N elementos inteiros, calcule a soma, a média
                         aritmética, a quantidade de elementos abaixo da média, o índice do maior e o índice do menor. O valor
                         de N deverá ser informado pelo usuário no início da execução.
                         */
                        Console.Write("Informe o tamanho do vetor: ");
                        int nVetor = int.Parse(Console.ReadLine() ?? "0");
                        int[] vetor = new int[nVetor];
                        int somaVetor = 0;
                        for (int i = 0; i < nVetor; i++)
                        {
                            vetor[i] = random.Next(1, 101);
                            Console.Write(vetor[i] + " ");
                            somaVetor += vetor[i];

                        }
                        int mediaVetor = somaVetor / nVetor;
                        int quantidadeAbaixoMedia = 0;
                        int maiorValor = int.MinValue;
                        int menorValor = int.MaxValue;
                        int indiceMaiorValor = 0;
                        int indiceMenorValor = 0;

                        for (int i = 0; i < nVetor; i++)
                        {
                            if (vetor[i] < mediaVetor)
                            {
                                quantidadeAbaixoMedia++;
                            }

                            if (vetor[i] > maiorValor)
                            {
                                maiorValor = vetor[i];
                                indiceMaiorValor = i;
                            }

                            if (vetor[i] < menorValor)
                            {
                                menorValor = vetor[i];
                                indiceMenorValor = i;
                            }
                        }

                        Console.WriteLine();
                        Console.WriteLine("Soma dos valores do vetor: " + somaVetor);
                        Console.WriteLine("Média dos valores do vetor: " + mediaVetor);
                        Console.WriteLine("Quantidade de valores abaixo da média: " + quantidadeAbaixoMedia);
                        Console.WriteLine("Indice do maior valor do vetor: " + indiceMaiorValor);
                        Console.WriteLine("Indice do menor valor do vetor: " + indiceMenorValor);
                        break;

                    case 2:
                        /*
                         Escreva um programa que preencha aleatoriamente uma matriz real de 6x6, calcule a soma e a média
                         dos elementos situados acima da diagonal secundária, incluindo a própria diagonal.
                        */
                        int[,] matriz = new int[6,6];
                        int somaMatriz = 0;
                        for(int linha = 0; linha < matriz.GetLength(0); linha++) {
                            for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                            {
                                matriz[linha, coluna] = random.Next(1, 10);

                                //  if a mais só para usar consoleColor e deixar meu console mais bonito.
                                if (linha + coluna < matriz.GetLength(0) - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.Write(matriz[linha, coluna] + " ");                               
                                }

                                else if  (linha + coluna == matriz.GetLength(0) - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                    Console.Write(matriz[linha, coluna] + " ");       
                                } 

                                else
                                {
                                    Console.Write(matriz[linha, coluna] + " ");
                                }

                                if (linha + coluna <= matriz.GetLength(0) - 1)
                                {
                                    somaMatriz += matriz[linha, coluna];
                                }
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("Soma total do elementos da matriz: " + somaMatriz);
                        Console.WriteLine("Média dos elementos da matriz: " + somaMatriz / (matriz.GetLength(0) * matriz.GetLength(1)));
                        break;

                    case 3:
                        /* 
                         O IBOPE deseja fazer uma pesquisa de audiência das rádios locais. Para tal, cada entrevistado deverá
                         informar:
                         IDADE
                         SEXO (1-Masculino, 2-Feminino)
                         ESTADO CIVIL (1-Casado, 2-Solteiro, 3-Viúvo, 4-Divorciado)
                         RÁDIO PREFERIDA (1-BHfm, 2-98fm, 3-Jovem Pan, 4-Itatiaia, 5-CDL)
                         Qualquer outro valor deverá ser contabilizado como "Outros".
                         A entrevista se encerrará quando for digitada idade igual a 0. Calcular e imprimir:
                         a) % de audiência de cada rádio (incluindo outros);
                         b) no de mulheres casadas que preferem BHfm;
                         c) no de homens maiores de 21 anos que preferem Jovem Pan;
                         d) média das idades;
                         e) % de homens e de mulheres. 
                         */
                        int idade = int.MinValue;
                        int totalEntrevistados = 0;
                        int totalOutros = 0;
                        int totalBHfm,total98fm, totalJovemPan, totalItatiaia, totalCDL;
                        totalBHfm = total98fm = totalJovemPan = totalItatiaia = totalCDL = 0;
                        int b = 0;
                        int c = 0;
                        int idadeSoma = 0;
                        int tHomem, tMulher;
                        tHomem = tMulher = 0;



                        while (idade != 0)
                        {
                            Console.Write("Idade: ");
                            idade = int.Parse(Console.ReadLine() ?? "0");
                            idadeSoma += idade;
                            Console.Write("\nSexo: 1- masculino, 2- feminino: ");
                            int sexo = int.Parse(Console.ReadLine() ?? "0");
                            if (sexo == 1)
                            {
                                tHomem++;
                            }
                            else if (sexo == 2)
                            {
                                tMulher++;
                            }
                            Console.Write("\nEstado civil 1-Casado, 2-Solteiro, 3-Viúvo, 4-Divorciado: ");
                            int estadoCivil = int.Parse(Console.ReadLine() ?? "0");
                            Console.Write("\nRádio preferida 1-BHfm, 2-98fm, 3-Jovem Pan, 4-Itatiaia, 5-CDL: ");
                            int radioPreferida = int.Parse(Console.ReadLine() ?? "0");
                            totalEntrevistados++;
                            if (radioPreferida <= 0 || radioPreferida > 5)
                            {
                                totalOutros++;
                            }
                            else if (radioPreferida == 1)
                            {
                                totalBHfm++;
                            }
                            else if (radioPreferida == 2)
                            {
                                total98fm++;
                            }
                            else if (radioPreferida == 3)
                            {
                                totalJovemPan++;
                            }
                            else if (radioPreferida == 4)
                            {
                                totalItatiaia++;
                            }
                            else if (radioPreferida == 5)
                            {
                                totalCDL++;
                            }
                            
                            if (sexo == 2 && estadoCivil == 1 && radioPreferida == 1)
                            {
                                b++;
                            }
                            if (sexo == 1 && idade >= 21)
                            {
                                c++;
                            }


                        }
                        Console.WriteLine($"% de audiência de cada rádio (incluindo outros\nBHfm:{totalBHfm / totalEntrevistados * 100}" +
                            $"\n98fm:{total98fm / totalEntrevistados * 100}" +
                            $"\nJovem Pan:{totalJovemPan / totalEntrevistados * 100}" +
                            $"\nItatiaia:{totalItatiaia / totalEntrevistados * 100}" +
                            $"\nCDL:{totalCDL / totalEntrevistados * 100}" +
                            $"\nOutros:{totalOutros / totalEntrevistados * 100}");
                        Console.WriteLine("Número de mulheres casadas que preferem BHfm: " + b);
                        Console.WriteLine("Número de homens maiores de 21 anos que preferem Jovem Pan: " + c);
                        Console.WriteLine("Média das idades: " + idadeSoma / totalEntrevistados);
                        Console.WriteLine($"% de homens:{tHomem / totalEntrevistados * 100}\n% de mulheres:{tMulher / totalEntrevistados * 100}");

                        break;

                    case 4:
                        /*
                         * Dê a codificação completa da classe Aluno, de acordo com o seguinte diagrama:
                            Aluno
                            - matricula: int
                            - nome: string
                            - nota1: double
                            - nota2: double
                            - nota3: double
                            + Aluno(int mat, string nom, double n1, double n2, double n3)
                            + GetMatricula(): int
                            + GetNome(): string
                            + GetNotaFinal(): double
                            + GetResultado(): string
                            
                        O método GetNotaFinal() deverá calcular e retornar a nota final do aluno, que consiste na
                        média aritmética das três notas.
                        
                        O método GetResultado() deverá retornar um string contendo o resultado final do aluno, de
                        acordo com a seguinte tabela:
                        "Aprovado": nota final maior ou igual a 60 pontos.
                        "Recuperação": nota final entre 40 e 59 pontos, inclusive.
                        "Reprovado": nota inferior a 40 pontos.
                         */
                        Console.WriteLine("using System;\r\nusing System.Collections.Generic;\r\nusing System.Text;\r\n\r\nnamespace ListaExercicios\r\n{\r\n    internal class Aluno\r\n    {\r\n        private int matricula;\r\n        private string nome;\r\n        private double nota1;\r\n        private double nota2;\r\n        private double nota3;\r\n\r\n        public Aluno(int matricula, string nome, double nota1, double nota2, double nota3)\r\n        {\r\n            this.matricula = matricula;\r\n            this.nome = nome;\r\n            this.nota1 = nota1;\r\n            this.nota2 = nota2;\r\n            this.nota3 = nota3;\r\n        }\r\n\r\n        public int getMatricula() { \r\n        \r\n            return this.matricula;\r\n        }\r\n\r\n        public string getNome() { \r\n            return this.nome;\r\n        }\r\n\r\n        public double getNotaFinal() {\r\n            return (this.nota1 + this.nota2 + this.nota3) / 3;\r\n        }\r\n\r\n        public string getResultado()\r\n        {\r\n            double notaFinal = getNotaFinal();\r\n            if (notaFinal >= 60)\r\n            {\r\n                return \"Aprovado\";\r\n            }\r\n            else if (notaFinal > 40 && notaFinal <= 59)\r\n            {\r\n                return \"Recuperação\";\r\n            }\r\n            else\r\n            {\r\n                return \"Reprovado\";\r\n            }\r\n        }\r\n    }\r\n}\r\n");

                        break;

                    case 5:
                        /*
                           Escreva a classe TestaAluno que deverá permitir o cadastro de N alunos, onde N será informado pelo
                           usuário (dica: use um vetor de objetos). Ao final, imprimir nome e resultado final dos N alunos.
                        */
                        Console.WriteLine("Número de alunos");
                        int nAlunos = int.Parse(Console.ReadLine() ?? "0");
                        TestAluno[] alunos = new TestAluno[nAlunos];
                        for(int i = 0; i < nAlunos; i++)
                        {
                            Console.WriteLine("Nome do aluno: ");
                            string nome = Console.ReadLine() ?? "";
                            Console.WriteLine("Nota 1: ");
                            int nota1 = int.Parse(Console.ReadLine() ?? "0");
                            Console.WriteLine("Nota 2: ");
                            int nota2 = int.Parse(Console.ReadLine() ?? "0");
                            Console.WriteLine("Nota 3: ");
                            int nota3 = int.Parse(Console.ReadLine() ?? "0");

                            alunos[i] = new TestAluno(nome, nota1, nota2, nota3);
                        }

                        for(int i = 0; i < nAlunos; i++)
                        {
                            Console.WriteLine($"Nome: {alunos[i].getNome()} - Resultado: {alunos[i].getResultado()}");
                        }

                        break;

                    case 6:
                        /*
                         Projete uma classe denominada Data que deverá armazenar dia, mês e ano como valores inteiros
                         (não é permitido usar a classe DateTime ou similares). Crie o método construtor, os métodos get e
                         set, e um método para retornar a data como string, no formato "dd/mm/aaaa". Construa um
                         método booleano para validar esta data, que deverá ser sempre superior a 31/12/1899 e inferior a
                         01/01/2100 (considerar os anos bissextos).
                         a) Dê o diagrama de classe correspondente a este enunciado.
                         b) Escreva o código correspondente.
                         c) Faça a classe TestaData contendo o método Main que ilustre todas as suas funcionalidades.
                          */

                        Console.WriteLine("Informe uma data (dd/mm/aaaa): ");
                        string data = Console.ReadLine() ?? "";
                        string[] partes = data.Split('/');
                        Data dataTest;
                        if (partes.Length == 3)
                        {
                            int dia = int.Parse(partes[0]);
                            int mes = int.Parse(partes[1]);
                            int ano = int.Parse(partes[2]);

                            
                            dataTest = new Data(dia, mes, ano);
                            if (dataTest.validarData())
                            {
                                Console.WriteLine("Data válida: " + dataTest.getData());
                                Console.WriteLine($"Gets -> dia {dataTest.getDia()} mês {dataTest.getMes()} ano {dataTest.getAno()}");
                                Console.WriteLine("Modificando data com set");
                                Console.WriteLine("Informe um novo dia: ");
                                int invalidandoDia = int.Parse(Console.ReadLine());
                                Console.WriteLine("Informe um novo mês: ");
                                int invalidandoMes = int.Parse(Console.ReadLine());
                                Console.WriteLine("Informe um novo ano: ");
                                int invalidandoAno = int.Parse(Console.ReadLine());
                                
                                dataTest.setDia(invalidandoDia);
                                dataTest.setMes(invalidandoMes);
                                dataTest.setAno(invalidandoAno);
                                Console.WriteLine("Data modificada: " + dataTest.getData());
                               

                                if (dataTest.validarData())
                                {
                                    Console.WriteLine("Data válida após modificação: " + dataTest.getData());
                                }
                                else
                                {
                                    Console.WriteLine("Data inválida após modificação.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Data inválida.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Data inválida.");
                        }
                        
                        break;

                    case 7:

                        Console.WriteLine("Tamanho da lista: ");
                        int tamanhoLista = int.Parse(Console.ReadLine());
                        Lista lista = new Lista();
                        for(int i  = 0; i < tamanhoLista; i++)
                        {
                            Console.WriteLine("Número para adicionar a lista: ");
                            int numAddLista = int.Parse(Console.ReadLine());
                            NoLista noLista = new NoLista(numAddLista);
                            lista.Inserir(noLista);
                        }
                        Console.WriteLine("Lista imprimir:"); 
                        lista.Imprimir();
                        Console.WriteLine("Lista GetLength: " + lista.GetLength());
                        Console.Write("Lista GetNo(1): ");
                        lista.GetNo(1);
                        Console.WriteLine("Lista GetMediaChave: " + lista.GetMediaChave());
                        Console.Write("Lista GetMaiorChave: ");
                        lista.GetMaiorChave();
                        Console.WriteLine("Tamanho da Fila: ");
                        int tamanhoFila = int.Parse(Console.ReadLine());
                        Fila fila = new Fila(tamanhoFila);
                        for(int i = 0; i < tamanhoFila ; i++)
                        {
                            fila.Enfileirar(i*2);
                        }
                        Console.WriteLine("Adicionando elementos da fila a lista...");
                        lista.AddItens(fila);
                        lista.Imprimir();
                        Console.WriteLine("Trocando as chaves...");
                        lista.TrocarChaves();
                        lista.Imprimir();




                        break;

                    default:
                        Console.WriteLine("Exercício não encontrado.");
                        break;

                }
            }

            Console.ResetColor();
        }
    }
}
