using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class User
   
    {

        private string login;
        private string name;
        private string sureName;
        private int years;
        private int dateOf;


        public string Login 
        { 
            get
            {
                return login;

            }

            set
            {
                login = value;
            }
        }
        public string Name 
        {
            get
            {
                return name;

            }

            set
            {
                name = value;
            }
        }
        public string SureName 
        {
            get
            {
                return sureName;

            }

            set
            {
                sureName = value;
            }

        }
        public int Years
        { 
            get
            {
                return years;

            }

            set
            {
                years = value;
            }
        }
        public int DateOf
        {
            get
            {
                return dateOf;

            }

            set
            {
                dateOf = value;
            }
        }
        public string GetUser()
        {
            return $"Login: {login}; Name: {name}; SureName: {sureName}; Years: {years}; DateOf: {dateOf}";
        }



    }
}
