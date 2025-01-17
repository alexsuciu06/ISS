﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum Role {Author, Reviewer, Listener, PCMember}

    [Serializable]
    public class User
    {
        private int idUser;
        private string first_name;
        private string last_name;
        private string username;
        private string password;
        private string email;
        private string affilation;
        private int key;
        private bool is_validated = false;
        private Role role;

        public User()
        {
        }

        public User(string fist_name, string last_name, string affilation, string username, string password, string email, string role,int key)
        {
            this.First_name = first_name;
            this.Last_name = last_name;
            this.Affilation = affilation;
            this.username = username;
            this.password = password;
            this.email = email;
            this.Key = key;
            Role myStatus = default(Role);
            Enum.TryParse(role, out myStatus);
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
                Role myStatus = default(Role);
                Enum.TryParse(value, out myStatus);
                role = myStatus;
            }
        }

        public virtual Role Role
        {
            get { return role; }
            set { role = value; }
        }

        public virtual bool Is_validated
        {
            get
            {
                return is_validated;
            }

            set
            {
                is_validated = value;
            }
        }

        public virtual string First_name
        {
            get
            {
                return first_name;
            }

            set
            {
                first_name = value;
            }
        }

        public virtual string Last_name
        {
            get
            {
                return last_name;
            }

            set
            {
                last_name = value;
            }
        }

        public virtual string Affilation
        {
            get
            {
                return affilation;
            }

            set
            {
                affilation = value;
            }
        }

        public virtual int Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
            }
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
