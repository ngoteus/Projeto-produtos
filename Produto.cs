namespace Projeto_produtos
{
    public class Produto
    {
        public int Codigo{get;set;}
        public string NomeProduto{get;set;}
        public float Preco{get;set;}
        public DateTime DataCadastro{get;set;}
        public Marca Marca = new Marca();
        public Usuario CadastradoPor {get;set;}
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
            
        }
        public void Listar()
        {
            foreach (var produto in ListaDeProdutos)
            {
                
        Console.WriteLine($"{produto.Codigo}");
        Console.WriteLine($"{produto.NomeProduto}");
        Console.WriteLine($"{produto.Preco}");
            }
        }
        public void Deletar(int codigo)
        {
            Console.WriteLine($"Informe o codigo do produto que deseja deletar: ");
            codigo = int.Parse(Console.ReadLine());
            
         Produto produto = ListaDeProdutos.Find(x => x.Codigo == codigo);
         ListaDeProdutos.Remove(produto);

        }

        
    }
}