using System; // Importa o namespace necessário para interações com o console

// Interface que define o modelo para qualquer tipo de mensagem
interface IMensagem
{
    void Enviar(string texto); // Método que todas as mensagens devem implementar
}

// Classe concreta que representa o envio por E-mail
class Email : IMensagem
{
    public void Enviar(string texto) // Implementação do envio por e-mail
    {
        Console.WriteLine("[E-MAIL] Mensagem enviada: " + texto);
    }
}

// Classe concreta que representa o envio por SMS
class SMS : IMensagem
{
    public void Enviar(string texto) // Implementação do envio por SMS
    {
        Console.WriteLine("[SMS] Mensagem enviada: " + texto);
    }
}

// Interface da fábrica que define o modelo para criação de mensagens
interface IMensagemFactory
{
    IMensagem CriarMensagem(); // Método para retornar uma instância de mensagem
}

// Fábrica concreta que cria mensagens do tipo Email
class EmailFactory : IMensagemFactory
{
    public IMensagem CriarMensagem() // Retorna uma nova instância de Email
    {
        return new Email();
    }
}

// Fábrica concreta que cria mensagens do tipo SMS
class SMSFactory : IMensagemFactory
{
    public IMensagem CriarMensagem() // Retorna uma nova instância de SMS
    {
        return new SMS();
    }
}

// Classe principal que representa o cliente do padrão Factory Method
class Program
{
    static void Main() // Ponto de entrada da aplicação
    {
        Console.WriteLine("Escolha o tipo de mensagem: 1 - Email, 2 - SMS");
        string escolha = Console.ReadLine(); // Lê a escolha do usuário

        IMensagemFactory fabrica; // Declara uma fábrica genérica

        // Decide qual fábrica instanciar com base na escolha do usuário
        if (escolha == "1")
            fabrica = new EmailFactory(); // Usa a fábrica de E-mail
        else
            fabrica = new SMSFactory(); // Usa a fábrica de SMS

        IMensagem mensagem = fabrica.CriarMensagem(); // Cria o produto (mensagem) através da fábrica

        Console.Write("Digite a mensagem: ");
        string texto = Console.ReadLine(); // Lê o conteúdo da mensagem

        mensagem.Enviar(texto); // Envia a mensagem usando o método definido pela interface
    }
}
