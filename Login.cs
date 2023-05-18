namespace Projeto_produtos
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login()
        {
            Usuario user = new Usuario();

            // validacao se esta logado
            Logar(user);
            if (Logado == true)
            {
                GerarMenu();

            }
        }
        public void Logar(Usuario usuario)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine($"Hora de Logar!!");
            Console.ResetColor();
            Console.WriteLine($"Insira seu email cadastrado: ");
            string email = Console.ReadLine();

            Console.WriteLine($"Insira sua senha: ");
            string senha = Console.ReadLine();

            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"Login efetuado com sucesso!");
                Console.ResetColor();
            }
            else
            {
                this.Logado = false;
                Console.ForegroundColor=ConsoleColor.Red;
                Console.WriteLine($"Falha ao logar!");
                Console.ResetColor();

            }


        }
        public void Deslogar(Usuario usuario)
        {

        }
        public void GerarMenu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            string opcao;
            do
            {


                Console.WriteLine(@$"
                -----------------------
            [1] - Cadastrar Produto
            [2] - Listar Produto
            [3] - Remover Produto
            [4] - Cadastrar Marca
            [5] - Listar Marca
            [6] - Remover Marca
            [0] - Sair");

                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();

                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Informe o Codigo a ser removido: ");
                        int codigoProduto = int.Parse(Console.ReadLine());


                        produto.Deletar(codigoProduto);
                        break;
                    case "4":
                        Marca.Cadastrar();
                        break;
                    case "5":
                        Marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o Codigo a ser removido: ");
                        int codigoMarca = int.Parse(Console.ReadLine());

                        Marca.Deletar(codigoMarca);

                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"App encerrado!");
                        Console.ResetColor();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opcao invalida!");
                        Console.ResetColor();
                        break;
                }
            } while (opcao != "0");
        }
    }
}