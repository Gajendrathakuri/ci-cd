using Microsoft.AspNetCore.SignalR;

namespace Deployment.Controllers
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
    }
}
