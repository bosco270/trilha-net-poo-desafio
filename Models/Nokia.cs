using System.Reflection;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Nokia criado com sucesso {Modelo}");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo instaldo via Android");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
