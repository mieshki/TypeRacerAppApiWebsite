using System;
using System.ComponentModel.DataAnnotations;

namespace TypeRacerWebPageAndAPI.Models
{
    public class AccountModel
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public AccountModel() { }
        public AccountModel(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}