using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransactionLog.Utility;
using TransactionLog.Utility.Entities;
using TransactionLog.Utility.RequestEntity;

namespace TransactionLog.Businesslogic
{
    public class GeneralClass
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private GeneralEntity generalEntity;

        internal TransactionModel isTransactionPersisted(TransactionRequest model, string FCMBAppKey)
        {
            generalEntity = new GeneralEntity();
            return generalEntity.isTransactionPersisted(model, FCMBAppKey);

        }
    }
}