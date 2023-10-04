namespace Shared
{
    public interface IMessage
    {
        public string text { get; set; }
        public bool isSuccess { get; set; }
        public string messageType  { get; set; } //success , warning , error
    }
}