// Classe abstrata para padronizar o envio de mensagens, garantindo polimorfismo:
public abstract class ChannelBase
{
    public abstract string Name { get; }

    // Método polimórfico
    public abstract void SendMessage(string destination, MessageBase message);
}