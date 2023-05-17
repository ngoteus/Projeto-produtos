namespace Projeto_produtos
{
    public class Marca
    {
        public int Codigo{get; set;}
        public string NomeMarca{get; set;}

        public DateTime DataCadastro{get; set;}

        List<Marca> listaDeMarcas = new List<Marca>();

        
        public void Cadastrar()
        {
            Marca marca = new Marca();
            
            Console.WriteLine($"Digite Codigo da sua marca:");
            marca.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da Marca: ");
            marca.NomeMarca = Console.ReadLine();
            
            
            
            
        }
        public List<Marca> Listar()
        {
            Console.WriteLine($"{listaDeMarcas}");
            return listaDeMarcas;
        }
        public void Deletar(int codigo)
        {
            Marca marca = listaDeMarcas.Find(x => x.Codigo == codigo );
            listaDeMarcas.Remove(marca);
        }
    }
}