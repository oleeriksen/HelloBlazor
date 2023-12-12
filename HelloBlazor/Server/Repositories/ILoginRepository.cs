using System;
using HelloBlazor.Shared;

namespace HelloBlazor.Server.Repositories
{
    public interface ILoginRepository
    {
        bool Verify(string email, string password);

        BEUser[] GetUsers(string email);
    }
}

