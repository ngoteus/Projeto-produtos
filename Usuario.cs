namespace Projeto_produtos
{
    public class Usuario
    {

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar()
        {

            Console.WriteLine($"Informe seu Nome: ");
            this.Nome = Console.ReadLine();

            Console.WriteLine($"Informe seu email: ");
            this.Email = Console.ReadLine();

            Console.WriteLine($"Informe sua senha: ");
            this.Senha = Console.ReadLine();

            Console.WriteLine($"Dados cadastrados!");


        }

    }
}