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
                AuthSecret = "Za2NHhoGe0Af8NERiHM1lRVyonuESkRsuypN1WS2",
                BasePath = "https://test-59665-default-rtdb.firebaseio.com/"
            };

            return new FireSharp.FirebaseClient(config);
        }
    }
}
