using System;

namespace Actio.Common.Commands
{
    public class CreateActivity : IAuthenticatedCommnad
    {
        public Guid UserId { get; set; }
    }
}