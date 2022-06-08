namespace PunishmentOrg.ServiceModels.ServiceResponse.Anu;

public class ResponseMessage
{
    //public ResponseMessage()
    //{
    //    Successful = false;
    //    Message = "";
    //    Number = "-1";
    //    Description = "";
    //    Code = "";
    //}
    private bool Successful { get; set; }
    private string Message { get; set; }
    private string Number { get; set; }
    private string Description { get; set; }
    private string Code { get; set; }

    public interface IResponseMessage
    {
        public ResponseMessage ResponseMessage { get; set; }
    }

}