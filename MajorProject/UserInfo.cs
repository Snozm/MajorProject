using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    public class UserInfo
    {
        public string email;
        public string username;
        public Image picture;
        public string firstName;
        public string lastName;
        public string gender;
        public string role;
        public UserInfo(string email, string username, Image picture, string firstName, string lastName, string gender, string role)
        {
            this.email = email;
            this.username = username;
            this.picture = picture;
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.role = role;
        }
    }
}
