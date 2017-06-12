namespace Um45.Models.Rest
{
    public class Error
    {
        public bool HasError { get; set; } = false;

        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public ErrorType Type { get; set; }
    }
}