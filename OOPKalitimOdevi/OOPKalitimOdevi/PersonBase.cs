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
        private string personType;


        public PersonBase()
        {
            
        }

        protected PersonBase(string personType,string id, string firstName, string lastName)
        {
            PersonType = personType;
            Id = id;
            LastName = lastName;
            FirstName = firstName;
        }

        public string PersonType { get => personType; set => personType = value.Trim().ToUpper(); }
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
            return $"Personel Bilgileri :\nÇalışma Şekli\t\t: {personType}\nSicil Numarası\t\t: {id}\nAdı Soyadı\t\t: {firstName} {lastName}";
        }

        

        
    }
}
