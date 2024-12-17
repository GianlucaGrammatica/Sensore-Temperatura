using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sensore_Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SensoreTemperatura sen = new SensoreTemperatura();
            sen.TemperaturaAlta += ClimaAcceso;

            while(true)
            {
                Console.WriteLine("Inserisci una nuova temperatura: ");
                string input = Console.ReadLine();
                if(input == "esci")
                {
                    break;
                }

                if(double.TryParse(input, out var val) )
                {
                    Console.WriteLine(sen.ImpostaTemperature(val));
                }
                else
                {
                    Console.WriteLine("Errore di inserimento");
                }
            }
        }

        static void ClimaAcceso(double val)
        {
            Console.WriteLine("Accensione Clima");
        }
    }

}
