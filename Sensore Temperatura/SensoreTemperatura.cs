using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensore_Temperatura
{
    public delegate void RaffreddamentoHandler(double Temperatura);
    internal class SensoreTemperatura
    {

        // Proprietà
        private double Temperatura;
        private const double Soglia = 30.0;

        public event RaffreddamentoHandler TemperaturaAlta;


        // Costruttori
        public SensoreTemperatura()
        {
            ImpostaTemperature(0);
        }

        public SensoreTemperatura(double val)
        {
            ImpostaTemperature(val);
        }


        // Metodi
        public string ImpostaTemperature(double val)
        {
            string Messaggio = "";

            if(!(val < 55.0 && val > -80.0))
            {
                Temperatura = val;
                Messaggio = $"Nuova temperature; {Temperatura}° C";

                if(Temperatura > Soglia)
                {
                    TemperaturaAlta?.Invoke(Temperatura);
                }
            }
            else
            {
                Messaggio = "Temperatura inserita non valida";
            }

            return Messaggio;
        }
    }
}
