namespace School.Application.Core
{
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string? Message { get; set; }

        public ServiceResult()
        {
            this.Success = true;
        }
    }

    
    public class ServiceResult<TData> : ServiceResult
    {
        public TData? Data { get; set; }
    }
}