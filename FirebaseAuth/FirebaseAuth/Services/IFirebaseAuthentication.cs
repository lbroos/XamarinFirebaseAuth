using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FirebaseAuth.Services
{
    public interface IFirebaseAuthentication
    {
        Task<string> LoginWithEmailAndPassword(string email, string password);

        bool SignOut();

        bool IsSignIn();
    }
}
