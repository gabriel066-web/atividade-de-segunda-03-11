//(Usam usuário como destino)
public class Instagram : ChannelBase
{
    public override string Name => "Instagram";

    public override void SendMessage(string usuario, MessageBase message)
    {
        Console.WriteLine($"[Instagram] Enviando mensagem para @{usuario}");
        Console.WriteLine($"Conteúdo: {message.Message}");
        Console.WriteLine($"Data de envio: {message.SendAt}\n");
    }
}