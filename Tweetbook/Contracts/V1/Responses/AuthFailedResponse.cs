
using System.Collections.Generic;

namespace Tweetbook.Contracts.V1.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Error { get; set; }
    }
}
