using System;
using System.Collections;
using System.Collections.Generic;

namespace API.Entities
{
    public class Operation
    {
        public int Id { get; set; }
        public int OperationType { get; set; }
        public float OperationSum { get; set; }
        public float Commissions { get; set; }
        public string CreDate { get; set; }
        public int AccountId { get; set; }
        public int DocumentType { get; set; }
        public string DocumentRef { get; set; }
    }
}