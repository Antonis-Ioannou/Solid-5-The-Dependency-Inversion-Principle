namespace ClassLibrary1
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}