using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenverTeradoLogin.Controller
{
    internal class AuthSession
    {
        private static AuthSession instance;

        public static AuthSession Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AuthSession(username: null, isActive:false);
                }
                return instance;
            }   
        }

        public string Username { get; set; }
        public bool isActive { get; set; } = false;
        public string FullName { get; set; }
        public string Role { get; set; }

        

        public AuthSession(string username, bool isActive)
        {
            this.Username = username;
            
            this.isActive = isActive;
        }

        public AuthSession(string username, string role)
        {
            this.Username = username;
            this.Role = role;
        }

        public void UpdateSession(string username, bool isActive)
        {
            this.Username = username;
           
            this.isActive = isActive;
        }

        public void UpdateSession(string username, bool isActive, string fullname, string role)
        {
            this.Username = username;
            
            this.FullName = fullname;
            this.Role = role;
            this.isActive = isActive;
        }
    }
}
