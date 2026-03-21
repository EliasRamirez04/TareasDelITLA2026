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

    // Versión genérica para cuando necesites retornar datos (ej. una lista o un objeto)
    public class ServiceResult<TData> : ServiceResult
    {
        public TData? Data { get; set; }
    }
}