using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Market.Objects
{
    public class Client
    {
        [Key]
        public int Id_Client{get; private set;}
        public string Name_Client{get; private set;}
        public string? CPF_Client{get; private set;}
        public string? City_Client{get; private set;}
        public string? Estate_Client{get; private set;}
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Regis_Client{get; private set;}

        protected Client(){}

        public Client(string Name_Client)
        {
            this.Name_Client = Name_Client; 
        }


    }
}
 