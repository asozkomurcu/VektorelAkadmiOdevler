using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPKalitimOdevi
{
    public abstract class PersonBase
    {
        private string id;
        private string firstName;
        private string lastName;


        public PersonBase()
        {
            
        }

        protected PersonBase(string id, string firstName, string lastName)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }

        
        public string Id
        {
            get => id;
            set
            {
                string a = "";
                for (int i = 0; i < 5 - value.Length; i++)
                {
                    a = a + 0;
                }
                id= a + value;
            }
        }
            
        public string FirstName { get => firstName; set => firstName = value.Trim().ToUpper(); }
            
        public string LastName { get => lastName; set => lastName = value.Trim().ToUpper(); }


        public virtual string AdSoyadGetir()
        {
            return $"Personel Bilgileri :\nSicil Numarası : {id}\nAdı Soyadı : {firstName} {lastName}";
        }

        

        
    }
}
