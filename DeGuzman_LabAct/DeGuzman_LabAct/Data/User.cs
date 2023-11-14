using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace DeGuzman_LabAct.Data
{
    public class User : IdentityUser
    {
        public string FName { get; set; }
        public string LName { get; set; }
    }
}
