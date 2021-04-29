﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public override bool Equals(object obj)
        {
            var user = obj as User;
        if (user==null)
	        {
            return false;
	        }
            return FirstName==user.FirstName&&SecondName==user.SecondName;
        }
        public​ ​ override​ ​ int​ ​ GetHashCode​()
        {
            int firstNameHashCode = FirstName?.GetHashCode() ?? 0;
            int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
            return firstNameHashCode ^ secondNameHashCode;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var​ hashSet = ​ new​ HashSet<User>();
​            var​ user = ​ new​ User() { FirstName = ​ "Barbara"​ , SecondName = ​ "Santa"​ };
            hashSet.Add(user);
​            var​ searchUsser = ​ new​ User(){FirstName = ​ "Barbara"​ , SecondName = "Santa"​ };
                         

            Console.WriteLine(​ $"contains user ​ {hashSet.Contains(user)}​ , contains searchUsser ​ { hashSet.Contains(searchUsser)}​ "​ );
        }
    }


