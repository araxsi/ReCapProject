using Core.Entities.Concrete;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<Entities.Concrete.OperationClaim> operationClaims);
    }
}