using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Role {Author, Reviewer }

    public class User
    {
        private int idUser;
        private String username;
        private String password;
        private String email;
        private Role role;

        public User()
        {
        }

        public User(int idUser, String username, String password, String email, Role role)
        {
            this.idUser = idUser;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }

        
        public virtual int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public virtual String Username
        {
            get { return username; }
            set { username = value; }
        }

        public virtual String Password
        {
            get { return password; }
            set { password = value; }
        }

        public virtual String Email
        {
            get { return email; }
            set { email = value; }
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
                return user.IdUser != this.IdUser || user.Username != this.Username || user.Password != this.Password || user.Role != this.Role;
            } 
            return false;
        }

        public override String ToString()
        {
            return IdUser + " " + Username + " " + Password + " " + Email + " " + Role + "\n";
        }
        


    }
}
