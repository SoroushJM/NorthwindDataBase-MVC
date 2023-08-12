using System.Collections;

namespace NorthwindDataBase_MVC.Models.DTOS
{
    public class RequestsResult
    {
        public enum RequestStatsEnum
        {
            succeed,
            failed,
            EmailExist,
            EmailIsNotValid,
        }
        public RequestStatsEnum RequestStats;
        public List<string> ErrorMessages;
        public BaseDTO? Data { get; set; }
        public RequestsResult(RequestStatsEnum requestStats, BaseDTO? DtoToReturn)
        {
            ErrorMessages = new List<string> { };
            RequestStats = requestStats;
            switch (requestStats)
            {
                case RequestStatsEnum.succeed:
                    ErrorMessages.Add("There is no Error and request succeed");
                    break;
                case RequestStatsEnum.failed:
                    ErrorMessages.Add("Request Failed No Further Information");
                    break;
                case RequestStatsEnum.EmailExist:
                    ErrorMessages.Add("This Email is Already Exist Please sign in or sign up with different user");
                    break;
                default:
                    ErrorMessages.Add("default");
                    break;
            }

            Data = DtoToReturn;
            
        }
    }
}
