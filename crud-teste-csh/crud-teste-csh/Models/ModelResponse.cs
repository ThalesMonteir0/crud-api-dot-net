namespace crud_teste_csh.Models
{
    public class ModelResponse<T>
    {
        public T? Data {  get; set; } 
        public string Message { get; set; } = string.Empty;
        public bool Sucess {get; set;}
    }
}
