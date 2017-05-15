using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Role {Author, Reviewer}

    public class User
    {
        private int idUser;
        private string username;
        private string password;
        private string email;
        private Role role;

        public User()
        {
        }

        public User(string username, string password, string email, string role)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            Enum.TryParse(role, out Role myStatus);
            this.role = myStatus;
        }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        
        public virtual int Id
        {
            get { return idUser; }
            protected set { idUser = value; }
        }

        public virtual string Username
        {
            get { return username; }
            set { username = value; }
        }

        public virtual string Password
        {
            get { return password; }
            set { password = value; }
        }

        public virtual string Email
        {
            get { return email; }
            set { email = value; }
        }

        public virtual string Rol
        {
            get
            {
                return role.ToString();
            }

            set
            {
                Enum.TryParse(value, out Role myStatus);
                role = myStatus;
            }
        }

        public virtual Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public override bool Equals(Object ob)
        {
            if (ob != null && ob.GetType() == GetType())
            {
                User user = (User)ob;
                return user.Id != this.Id || user.Username != this.Username || user.Password != this.Password || user.Role != this.Role;
            } 
            return false;
        }

        public override string ToString()
        {
            return Id + " " + Username + " " + Password + " " + Email + " " + Role + "\n";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
