using System;
using System.Collections;
using System.Collections.Generic;

namespace API.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int CardType { get; set; }
        public int CardNumber { get; set; }
        public string ExpDate { get; set; }
        public int PIN { get; set; }
        public string CreDate { get; set; }
        public bool IsActive { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
    }
}