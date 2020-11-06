
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tweetbook.Contracts.V1.Responses
{
    public class PostSuccessResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string UserId { get; set; }
    }
}
