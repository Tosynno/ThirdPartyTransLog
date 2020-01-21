using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TransactionLog.Utility;
using TransactionLog.Utility.RequestEntity;

namespace TransactionLog.Businesslogic
{
    public class AccessAuthentication
    {
        Logger logger = LogManager.GetCurrentClassLogger();
        public AccessAuthentication() { }

        internal bool AuthenticateAccess(string FCMBAppKey, string FCMBSecretKey)
        {
        //    var ipEntry = Dns.GetHostEntry(Dns.GetHostName());
        //    IPAddress[] addr = ipEntry.AddressList;
            AuthenticationRequest authenticationRequest = new AuthenticationRequest();
            authenticationRequest.AppID = FCMBAppKey;
            authenticationRequest.Appkey = FCMBSecretKey;
            //authenticationRequest.ClientIP = addr[2].ToString();
            GeneralEntity generalEntity = new GeneralEntity();
            return generalEntity.isClientAuthenticated(authenticationRequest) ? true : false;
        }
    }
}