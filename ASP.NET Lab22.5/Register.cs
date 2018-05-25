using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_Lab22._5
{
    public class Register
    {
        private string username;
        private string color;
        private string sport;

		public Register()
		{

		}

        public Register(string username, string color, string sport)
        //Leaving out for now.
        //public Car()
        //{
        //}


        {
            this.username = username;
            this.color = color;
            this.sport = sport;

        }

        public string Username { get => username; set => username = value; }
        public string Color { get => color; set => color = value; }
        public string Sport { get => sport; set => sport = value; }
    }
}