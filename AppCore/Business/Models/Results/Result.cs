using AppCore.Business.Models.Results.Bases;

namespace AppCore.Business.Models.Results
{
    public class Result
    {
        public bool IsSuccessful { get; } // readonly: sadece constructor üzerinden set edilebilir
        public string Message { get; set; }

        public Result(bool isSuccesful, string message)
        {
            IsSuccessful = isSuccesful;
            Message = message;
        }
    }

    public class Result<TResultType> : Result, IResultData<TResultType>
    {
        public TResultType Data { get; }
        public Result(bool isSuccesful, string message, TResultType data) : base(isSuccesful, message)
        {
            Data = data;
        }
    }
}
