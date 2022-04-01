using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public float Balance { get; set; }   
        public string CreDate { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Card> CardsTbl { get; set; }
    }
}