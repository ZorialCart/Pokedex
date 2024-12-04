using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Xama1.Connection
{
    public class Cconnection
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedex-d7311-default-rtdb.firebaseio.com/");
    }
}
