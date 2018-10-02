using System;

namespace Actio.Common.Commands
{
    public interface IAuthenticatedCommnad: ICommand
    {
        Guid UserId { get; set;}
    }
}