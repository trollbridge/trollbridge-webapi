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
        /// <summary>
        /// Gets SAS tokens to enable a device to access Azure blobs, queues, and event hubs.
        /// </summary>
        /// <param name="id">Id of device to return SAS tokens for.</param>
        /// <returns></returns>
        public TokenHolder Get(string id)
        {
            return SasTokenHelper.GetTokensUncompressed(id);
        }

        /// <summary>
        /// Gets SAS tokens to enable a device to access Azure blobs, queues, and event hubs.
        /// </summary>
        /// <param name="id">Id of device to return SAS tokens for.</param>
        /// <param name="compress">Whether or not compress the SAS tokens.</param>
        /// <returns></returns>
        public TokenHolder Get(string id, bool compress)
        {
            if (compress)
                return SasTokenHelper.GetTokensCompressed(id);
            else
                return SasTokenHelper.GetTokensUncompressed(id);
        }
    }
}
