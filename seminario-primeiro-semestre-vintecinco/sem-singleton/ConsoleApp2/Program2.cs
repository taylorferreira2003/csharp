using System;

public class GerenciadorDeConexao
{
    // Propriedade para armazenar a conexão ativa
    public string Conexao { get; private set; }

    // Construtor para inicializar a conexão
    public GerenciadorDeConexao()
    {
        Conexao = "Conexão estabelecida com a rede.";
    }

    // Método para simular a conexão de rede
    public void Conectar()
    {
        Console.WriteLine(Conexao);
    }

    // Método para desconectar
    public void Desconectar()
    {
        Conexao = "Conexão desconectada da rede.";
        Console.WriteLine(Conexao);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criação de duas instâncias separadas do GerenciadorDeConexao
        GerenciadorDeConexao conexao1 = new GerenciadorDeConexao();
        GerenciadorDeConexao conexao2 = new GerenciadorDeConexao();

        // Menu de interação com o usuário
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nMenu de Conexão de Rede:");
            Console.WriteLine("1. Conectar (Conexao1)");
            Console.WriteLine("2. Desconectar (Conexao1)");
            Console.WriteLine("3. Conectar (Conexao2)");
            Console.WriteLine("4. Desconectar (Conexao2)");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    conexao1.Conectar(); // Conectar usando a primeira instância
                    break;

                case "2":
                    conexao1.Desconectar(); // Desconectar usando a primeira instância
                    break;

                case "3":
                    conexao2.Conectar(); // Conectar usando a segunda instância
                    break;

                case "4":
                    conexao2.Desconectar(); // Desconectar usando a segunda instância
                    break;

                case "5":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}