using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios
{
    internal class TestAluno
    {
        
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;

        public TestAluno( string nome, double nota1, double nota2, double nota3)
        {
            
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

      

        public string getNome()
        {
            return this.nome;
        }

        public double getNotaFinal()
        {
            return (this.nota1 + this.nota2 + this.nota3) / 3;
        }

        public string getResultado()
        {
            double notaFinal = getNotaFinal();
            if (notaFinal >= 60)
            {
                return "Aprovado";
            }
            else if (notaFinal >= 40 && notaFinal <= 59)
            {
                return "Recuperação";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
