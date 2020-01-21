using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransactionLog.Models.Data;
using TransactionLog.Utility.Entities;
using TransactionLog.Utility.RequestEntity;

namespace TransactionLog.Utility
{
    public class GeneralEntity
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        private TransactionModel TransactionModels;

        internal bool isClientAuthenticated(AuthenticationRequest authenticationRequest)
        {
            try
            {
                using (var db = new AuthenticationUtilityDBContext())
                {

                    var rspVariable = db.AuthenticationRequests.Where(d => d.AppID == authenticationRequest.AppID && d.Appkey == authenticationRequest.Appkey).FirstOrDefault();
                    return (rspVariable != null);
                }


            }
            catch (Exception ex)
            {
                logger.Error("isClientAuthenticated :" + ex.Message);
                return false;
            }
        }

        internal TransactionModel isTransactionPersisted(TransactionRequest model, string FCMBAppKey)
        {
            try
            {
                
                TransactionModel sa = new TransactionModel();

                sa.Name = model.Name;
                sa.SmartcardNo = model.SmartcardNo;
                sa.Phone = model.Phone;
                sa.Amount = model.Amount;
                sa.DSTV_Mode = model.DSTV_Mode;
                sa.TraceRef = model.TraceRef;
                sa.STAN = model.STAN;
                sa.Hash = model.Hash;
                sa.User_Id = model.User_Id;
                sa.Branch = model.Branch;
                sa.Reverser_Flag = model.Reverser_Flag;
                sa.PAN = model.PAN;
                sa.TerminalId = model.TerminalId;
                sa.Status = "True";
                sa.TranDate = model.TranDate;
                sa.ClientID = FCMBAppKey;
                sa.CreatedDate = DateTime.Now;
                sa.ResponseCode = "200";
                sa.ResponseDescription = "Record has been inserted Successful.";

                using (var db = new ThirdPartyLogConnection())
                {
                    db.transactionModels.Add(sa);
                    db.SaveChanges();

                 
                }

                return sa;
            }
            catch (Exception ex)
            {
                logger.Error("isAccountBlockPersisted :" + ex.Message);
                TransactionModels = new TransactionModel();
                TransactionModels.ResponseCode = "99";
                TransactionModels.ResponseDescription = "Failed";
                return TransactionModels;
               
            }
        }
    }
}