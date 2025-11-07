namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // ----- atributos
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;

            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
        public void Dados()
        {
            Console.WriteLine($" Numero : {Numero} \n"
                            + $" Modelo : {Modelo} \n"
                            + $" IMEI   : {IMEI} \n"
                            + $" Memoria: {Memoria} \n");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
