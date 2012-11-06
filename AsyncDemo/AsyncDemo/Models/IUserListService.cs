using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AsyncDemo.Models
{
    [ServiceContract]
    public interface IUserListService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json)]
        List<User> GetUserList();
    }

    [DataContract]
    public class User
    {
        string firstname;
        string lastname;

        [DataMember]
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        [DataMember]
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
    }
}
