using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TransactionLog.Utility.Entities
{
    public class TransactionRequest
    {

        public string SmartcardNo { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal Amount { get; set; }
        public string DSTV_Mode { get; set; }
        public string TraceRef { get; set; }
        public string STAN { get; set; }
        public string Hash { get; set; }
        public string User_Id { get; set; }
        public string Branch { get; set; }
        public string Reverser_Flag { get; set; }
        public string PAN { get; set; }
        public string TerminalId { get; set; }
        public string TranDate { get;  set; }
       
    }
}