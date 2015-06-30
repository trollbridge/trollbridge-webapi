using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Trollbridge.Core;

namespace Trollbridge.WebApi.Controllers
{
    public class TokensController : ApiController
    {
        public TokenHolder Get(string id)
        {
            return SasTokenHelper.GetTokensUncompressed(id);
        }


        public TokenHolder Get(string id, bool compress)
        {
            if (compress)
                return SasTokenHelper.GetTokensCompressed(id);
            else
                return SasTokenHelper.GetTokensUncompressed(id);
        }
    }
}
