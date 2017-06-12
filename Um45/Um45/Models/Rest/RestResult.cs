namespace Um45.Models.Rest
{
    public class RestResult<T>
    {
        public Error Error { get; set; }=new Error();
        public T Data { get; set; }
        public string Raw { get; set; }

       
    }
}