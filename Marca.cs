namespace Projeto_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;

        public static List<Marca> listaDeMarcas = new List<Marca>();


        public static void Cadastrar()
        {
            Marca marca = new Marca();

            Console.WriteLine($"Digite Codigo da sua marca:");
            marca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da Marca: ");
            marca.NomeMarca = Console.ReadLine();

            listaDeMarcas.Add(marca);



        }
        public static void Listar()
        {
            foreach (var marca in listaDeMarcas)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Codigo do produto: {marca.Codigo}");
                Console.WriteLine($"Nome do produto: {marca.NomeMarca}");
                Console.WriteLine($"Data de cadastro: {marca.DataCadastro}");
                Console.ResetColor();

            }


        }
        public static void Deletar(int codigo)
        {
            Marca marca = listaDeMarcas.Find(x => x.Codigo == codigo);
            listaDeMarcas.Remove(marca);
        }
    }
}