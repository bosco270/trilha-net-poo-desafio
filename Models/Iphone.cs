namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone 
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
         : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"Iphone criado com sucesso {Modelo}");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Aplicativo instalado via IOS");
        }

       
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}
