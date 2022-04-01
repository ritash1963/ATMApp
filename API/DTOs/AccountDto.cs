using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class AccountDto
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public float Balance { get; set; }   
    }
}
