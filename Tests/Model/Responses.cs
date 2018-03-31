namespace Tests.Model
{
    using System.Net;

    public class Responses<T> where T : class
    {
        public T Content { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }
}