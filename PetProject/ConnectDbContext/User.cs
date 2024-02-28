using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.ConnectDbContext
{
    public class User
    {
        public int Id { get; set; }
        public string LastName {  get; set; }
        public string FirstName { get; set; }
        public string MiddleName {  get; set; }
        public string Email {  get; set; }
        public string Login {  get; set; }
        public string Password { get; set; }
        [DefaultValue(0)]
        public decimal Balance { get; set; }
    }
}
