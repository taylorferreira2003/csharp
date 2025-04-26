using System; // Importa o namespace System, que contém classes fundamentais para o funcionamento do C#.

public class ConfiguracaoComputador
{
    // Declaração da variável estática que contém a única instância da classe.
    private static ConfiguracaoComputador instance;

    // Propriedades para armazenar as configurações do computador.
    public string SistemaOperacional { get; private set; }
    public int MemoriaRAM { get; private set; }
    public string TipoArmazenamento { get; private set; }

    // Construtor privado para impedir a criação de instâncias fora da classe.
    private ConfiguracaoComputador()
    {
        // Inicializa as propriedades com valores padrão.
        SistemaOperacional = "Windows 10";
        MemoriaRAM = 8;
        TipoArmazenamento = "SSD";
    }

    // Método estático para obter a instância única da classe.
    public static ConfiguracaoComputador GetInstance()
    {
        // Verifica se a instância já foi criada.
        if (instance == null)
        {
            // Cria a instância se ela não existir.
            instance = new ConfiguracaoComputador();
        }
        // Retorna a instância única.
        return instance;
    }

    // Método para atualizar as configurações.
    public void AtualizarConfiguracao(string sistemaOperacional, int memoriaRAM, string tipoArmazenamento)
    {
        // Atualiza as propriedades com os novos valores fornecidos.
        SistemaOperacional = sistemaOperacional;
        MemoriaRAM = memoriaRAM;
        TipoArmazenamento = tipoArmazenamento;
    }

    // Método para exibir as configurações atuais.
    public void ExibirConfiguracao()
    {
        // Exibe as configurações atuais no console.
        Console.WriteLine(string.Format("Sistema Operacional: {0}", SistemaOperacional));
        Console.WriteLine(string.Format("Memória RAM: {0} GB", MemoriaRAM));
        Console.WriteLine(string.Format("Tipo de Armazenamento: {0}", TipoArmazenamento));
    }
}

class Program
{
    // Método principal que serve como ponto de entrada do programa.
    static void Main(string[] args)
    {
        // Obter a instância única da classe ConfiguracaoComputador.
        ConfiguracaoComputador config = ConfiguracaoComputador.GetInstance();

        // Variável para controlar o loop do menu.
        bool continuar = true;
        while (continuar)
        {
            // Exibir a configuração atual.
            Console.WriteLine("\nConfiguração atual do computador:");
            config.ExibirConfiguracao();

            // Exibir o menu de configurações.
            Console.WriteLine("\nMenu de Configurações:");
            Console.WriteLine("1. Alterar Sistema Operacional");
            Console.WriteLine("2. Alterar Memória RAM");
            Console.WriteLine("3. Alterar Tipo de Armazenamento");
            Console.WriteLine("4. Sair");

            // Solicitar ao usuário que escolha uma opção.
            Console.WriteLine("\nEscolha uma opção:");
            string opcao = Console.ReadLine();

            // Executar a ação correspondente à opção escolhida.
            switch (opcao)
            {
                case "1":
                    // Solicitar ao usuário que digite o novo Sistema Operacional.
                    Console.WriteLine("Digite o novo Sistema Operacional:");
                    string novoSO = Console.ReadLine();
                    // Atualizar a configuração com o novo Sistema Operacional.
                    config.AtualizarConfiguracao(novoSO, config.MemoriaRAM, config.TipoArmazenamento);
                    break;
                case "2":
                    // Solicitar ao usuário que digite a nova quantidade de Memória RAM.
                    Console.WriteLine("Digite a nova quantidade de Memória RAM (GB):");
                    int novaRAM = int.Parse(Console.ReadLine());
                    // Atualizar a configuração com a nova quantidade de Memória RAM.
                    config.AtualizarConfiguracao(config.SistemaOperacional, novaRAM, config.TipoArmazenamento);
                    break;
                case "3":
                    // Solicitar ao usuário que digite o novo Tipo de Armazenamento.
                    Console.WriteLine("Digite o novo Tipo de Armazenamento:");
                    string novoArmazenamento = Console.ReadLine();
                    // Atualizar a configuração com o novo Tipo de Armazenamento.
                    config.AtualizarConfiguracao(config.SistemaOperacional, config.MemoriaRAM, novoArmazenamento);
                    break;
                case "4":
                    // Sair do loop e encerrar o programa.
                    continuar = false;
                    break;
                default:
                    // Informar ao usuário que a opção escolhida é inválida.
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}