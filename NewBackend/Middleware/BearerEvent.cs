using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBackend.Middleware
{
    public class BearerEvent : JwtBearerEvents
    {
        public override Task TokenValidated(TokenValidatedContext context)
        {
          //  context.Fail("fail abc");
            return base.TokenValidated(context);
        }
    }
}
