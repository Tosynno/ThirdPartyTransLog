using Swashbuckle.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Description;

namespace TransactionLog.App_Start
{
    public class SwaggerAuthentication : IOperationFilter
    {
        public void Apply(Operation operation, SchemaRegistry schemaRegistry, ApiDescription apiDescription)
        {
            if (operation.parameters == null)
                operation.parameters = new List<Parameter>();

            operation.parameters.Add(new Parameter
            {
                name = "FCMBAppKey",
                @in = "header",
                type = "string",
                required = true,
                description = "FCMB App Key"
            });

            operation.parameters.Add(new Parameter
            {
                name = "FCMBSecretKey",
                @in = "header",
                type = "string",
                required = true,
                description = "FCMB Secret Key"
            });
        }
    }
}