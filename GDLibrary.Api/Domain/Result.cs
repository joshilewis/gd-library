namespace GDLibrary.Api.Domain
{
    public class Result
    {
        public Result(string message)
        {
            IsSuccessful = false;
            Message = message;
        }

        public Result()
        {
            IsSuccessful = true;
            Message = null;
        }

        public bool IsSuccessful { get; }
        public string? Message { get; }


    }
}
