using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TransactionLog.Businesslogic;
using TransactionLog.Utility.Entities;
using TransactionLog.Utility.RequestEntity;

namespace TransactionLog.Controllers
{
    public class ValuesController : ApiController
    {
        //private GeneralClass generalClass;
        private TransactionModel transactionModel;
        Logger logger = LogManager.GetCurrentClassLogger();
        private string FCMBAppKey = string.Empty;
        private string FCMBSecretKey = string.Empty;
        [HttpPost]
        [Route("Transactionlog")]
        public TransactionModel Transaction(TransactionRequest model)
        {
            try
            {


                if (Request.Headers.Contains("FCMBAppKey"))
                {
                    FCMBAppKey = Request.Headers.GetValues("FCMBAppKey").First();
                }

                if (Request.Headers.Contains("FCMBSecretKey"))
                {
                    FCMBSecretKey = Request.Headers.GetValues("FCMBSecretKey").First();
                }

                
                AccessAuthentication accessAuthentication = new AccessAuthentication();
                if (accessAuthentication.AuthenticateAccess(FCMBAppKey, FCMBSecretKey))
                {
                     var generalClass = new GeneralClass();
                    return generalClass.isTransactionPersisted(model, FCMBAppKey);
                   
                }
                else
                {
                    transactionModel = new TransactionModel();
                    transactionModel.ResponseCode = "99";
                    transactionModel.ResponseDescription = "Invalid Username or Password supplied.";
                    return transactionModel;
                }



            }
            catch (Exception c)
            {
                logger.Error("GetException" + c.InnerException);
                transactionModel = new TransactionModel();
                transactionModel.ResponseCode = "99";
                transactionModel.ResponseDescription = "Unable to process request at the moment.";
                return transactionModel;
            }


        }


    }
}
