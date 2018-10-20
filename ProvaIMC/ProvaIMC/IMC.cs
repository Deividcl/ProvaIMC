using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaIMC
{
    class IMC
    {
        private Double peso;
        private double altura;

        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;

        }

        public IMC(double peso, double altura)
        {

            this.peso = peso;
            this.altura = altura;

        }

        public double calcular(double peso, double altura)
        {
            double imc = ((peso) / (altura * altura));
            return imc;
        }

        public string classificar(double IMC)
        {
            if (IMC < 16 && IMC > 0)
            {
                return "MAGREZA GRAVE";
            }
            else if (IMC >= 16 && IMC < 17)
            {
                return "Magreza Moderada";
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                return "Magreza leve";
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                return "Saudável";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                return "Sobrepeso";
            }
            else if (IMC >= 30 && IMC < 35)
            {
                return "OBESIDADE GRAU |";
            }
            else if (IMC >= 35 && IMC < 40)
            {
                return "OBESIDADE GRAU ||";
            }
            else if (IMC > 40)
            {
                return "OBESIDADE GRAU |||";
            }

            return "erro";
        }
    }
}
