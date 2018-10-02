using System;

namespace Actio.Common.Events
{
    public interface IAuthenticatedEven: IEvent
    {
        Guid UserId { get; set; }
    }
}