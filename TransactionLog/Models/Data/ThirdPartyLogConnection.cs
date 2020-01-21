using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TransactionLog.Utility.RequestEntity;

namespace TransactionLog.Models.Data
{
    public class ThirdPartyLogConnection : DbContext
    {
        public DbSet<TransactionModel> transactionModels { get; set; }
    }
}