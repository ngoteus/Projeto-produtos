namespace Projeto_produtos
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.UtcNow;
        public Marca Marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        public List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {

            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o Codigo do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome do produto: ");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Informe o preco do produto: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            ListaDeProdutos.Add(novoProduto);

            Console.WriteLine($"Digite Codigo da sua marca:");
            int CodigoMarca = int.Parse(Console.ReadLine());

            Marca marca = Marca.listaDeMarcas.Find(x => x.Codigo == CodigoMarca);
            if (marca != null)
            {
                novoProduto.Marca = marca;
            }
            else
            {
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"Marca nao encontrada, Voce tera que registrar uma nova marca! ");
                Console.ResetColor();
    
            }


        }


        public void Listar()
        {
            foreach (var produto in ListaDeProdutos)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Codigo do produto: {produto.Codigo}");
                Console.WriteLine($"Nome do produto: {produto.NomeProduto}");
                Console.WriteLine($"Preço do produto: {produto.Preco:c}");
                Console.ResetColor();
                if (produto.Marca != null)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Marca do produto: {produto.Marca.NomeMarca}");
                    Console.WriteLine($"Codigo do produto: {produto.Marca.Codigo}");
                    Console.WriteLine($"Data de cadastro: {DataCadastro}");
                    Console.ResetColor();

                }
                else if (produto.Marca == null)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine($"Data de cadastro: {DataCadastro}");
                    Console.ResetColor();
                }

            }
        }
        public void Deletar(int codigo)
        {

            Produto produto = ListaDeProdutos.Find(x => x.Codigo == codigo);
            ListaDeProdutos.Remove(produto);

        }


    }
}