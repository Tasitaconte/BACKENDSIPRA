using System.Net;

namespace SIPRA_FESC.Application.ViewModels.Responses
{
    public class ResponseModel<T>
    {
        public int? Code { get; set; } = 0;
        public T? Data { get; set; }
        public List<string> Messages { get; set; } = new List<string>();

        public ResponseModel()
        {

        }

        public ResponseModel(HttpStatusCode code)
        {
            SetCode(code);
        }

        public ResponseModel(T data)
        {
            SetData(data);
        }

        public ResponseModel(HttpStatusCode code, T data, List<string> messages)
        {
            SetCode(code);
            Data = data;
            Messages = messages;
        }

        public void AddMessage(string message) => this.Messages.Add(message);
        public void SetData(T? data) => this.Data = data;
        public void SetCode(HttpStatusCode code) => this.Code = (int)code;
    }
}
