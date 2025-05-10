using System;

interface IMensagem
{
    void Enviar(string texto);
}

class Email : IMensagem
{
    public void Enviar(string texto)
    {
        Console.WriteLine("[E-MAIL] Mensagem enviada: " + texto);
    }
}

class SMS : IMensagem
{
    public void Enviar(string texto)
    {
        Console.WriteLine("[SMS] Mensagem enviada: " + texto);
    }
}

interface IMensagemFactory
{
    IMensagem CriarMensagem();
}

class EmailFactory : IMensagemFactory
{
    public IMensagem CriarMensagem()
    {
        return new Email();
    }
}

class SMSFactory : IMensagemFactory
{
    public IMensagem CriarMensagem()
    {
        return new SMS();
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o tipo de mensagem: 1 - Email, 2 - SMS");
        string escolha = Console.ReadLine();

        IMensagemFactory fabrica;

        if (escolha == "1")
            fabrica = new EmailFactory();
        else
            fabrica = new SMSFactory();

        IMensagem mensagem = fabrica.CriarMensagem();

        Console.Write("Digite a mensagem: ");
        string texto = Console.ReadLine();

        mensagem.Enviar(texto);
    }
}
