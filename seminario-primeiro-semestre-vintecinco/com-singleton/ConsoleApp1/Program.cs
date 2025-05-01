using System;

public class GerenciadorDeConexao
{
    private static GerenciadorDeConexao instance;

    // Propriedade para armazenar a conexão ativa
    public string Conexao { get; private set; }

    // Construtor privado para evitar a criação de instâncias fora da classe
    private GerenciadorDeConexao()
    {
        Conexao = "Conexão estabelecida com a rede.";
    }

    // Método estático para obter a instância única
    public static GerenciadorDeConexao GetInstance()
    {
        if (instance == null)
        {
            instance = new GerenciadorDeConexao();
        }
        return instance;
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
        // Obtém a instância única do GerenciadorDeConexao
        GerenciadorDeConexao conexao1 = GerenciadorDeConexao.GetInstance();
        GerenciadorDeConexao conexao2 = GerenciadorDeConexao.GetInstance();

        // Menu de interação com o usuário
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("\nMenu de Conexão de Rede:");
            Console.WriteLine("1. Conectar");
            Console.WriteLine("2. Desconectar");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    conexao1.Conectar(); // Conectar utilizando a instância única
                    break;

                case "2":
                    conexao1.Desconectar(); // Desconectar utilizando a instância única
                    break;

                case "3":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}