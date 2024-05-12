using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;

namespace Employee_Manager
{
    public class FirebaseSetup
    {
        public static IFirebaseClient InitializeFirebase()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "i1jWD1zLnzcJlgIHpv9RzPlOARWduP997qTV8rIM",
                BasePath = "https://employee-management-f8bdf-default-rtdb.firebaseio.com/"
            };

            return new FireSharp.FirebaseClient(config);
        }
    }
}
