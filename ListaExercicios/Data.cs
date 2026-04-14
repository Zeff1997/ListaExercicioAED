using System;
using System.Collections.Generic;
using System.Text;

namespace ListaExercicios
{
    internal class Data
    {
        private int dia, mes, ano;

        public Data(int dia, int mes, int ano)
        {
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public int getDia()
        {
            return this.dia;
        }

        public void setDia(int dia)
        {
            this.dia = dia;
        }
        public int getMes()
        {
            return this.mes;
        }
        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public int getAno()
        {
            return this.ano;
        }
        public void setAno(int ano)
        {
            this.ano = ano;
        }
        public string getData()
        {
            return $"{this.dia:D2}/{this.mes:D2}/{this.ano:D4}";
        }
        public bool validarData()
        {

            if (ano < 1900 || ano > 2099)
            {
                return false;
            }
            if (mes < 1 || mes > 12)
            {
                return false;
            }
            
            if (dia < 1)
            {
                return false;
            }

            bool bissexto = ((ano % 4 == 0) && (ano % 100 != 0)) || (ano % 400 == 0);
            int maxDia;

            if (mes == 2)
            {
                maxDia = bissexto ? 29 : 28;
            }
            
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                maxDia = 30;
            }
            
            else
            {
                maxDia = 31;
            }

            return dia <= maxDia;
        }
    }
}
