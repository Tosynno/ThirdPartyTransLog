using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TransactionLog.Utility.RequestEntity
{
    [Table("TransactionLog")]
    public class TransactionModel
    {
        [Key]
        [IgnoreDataMember]
        public int RecID { get; set; }
        [IgnoreDataMember]
        public string ClientID { get; set; }
        public string ResponseCode { get; internal set; }
        public string TranDate { get; set; }
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
      public string Status { get; set; }
        public string ResponseDescription { get; internal set; }
        [IgnoreDataMember]
        public DateTime CreatedDate { get; set; }
    }
}