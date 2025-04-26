using System; // Importa funcionalidades básicas

// Classe concreta para envio por E-mail
class Email
{
    public void Enviar(string texto)
    {
        Console.WriteLine("[E-MAIL] Mensagem enviada: " + texto);
    }
}

// Classe concreta para envio por SMS
class SMS
{
    public void Enviar(string texto)
    {
        Console.WriteLine("[SMS] Mensagem enviada: " + texto);
    }
}

// Classe principal do programa
class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tipo de mensagem: 1 - Email, 2 - SMS");
        string escolha = Console.ReadLine();

        Console.Write("Digite a mensagem: ");
        string texto = Console.ReadLine();

        // Aqui o código depende diretamente das classes concretas Email e SMS
        // Comentário: Poderia ser usado um Factory Method para encapsular essa criação

        if (escolha == "1")
        {
            // Criação direta do objeto Email
            Email email = new Email();
            email.Enviar(texto);
        }
        else
        {
            // Criação direta do objeto SMS
            SMS sms = new SMS();
            sms.Enviar(texto);
        }

        // Consequência de não usar Factory Method:
        // - O código está acoplado às classes concretas Email e SMS
        // - Se quiser adicionar WhatsApp, Telegram ou outro canal,
        //   será necessário alterar essa estrutura (violando o Princípio Aberto/Fechado - SOLID)
        // - Dificulta testes unitários, pois não há interface para simular
    }
}