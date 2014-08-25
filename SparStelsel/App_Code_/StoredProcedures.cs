using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SparStelsel
{
    /// <summary>
    /// Stored Procedures is a collection of static readonly strings assosiated with the Stored Procedures in the Database.
    /// This is to allow the developers to only change a single member to propagate across the project. 
    /// </summary>
    public class StoredProcedures
    {       
        public static readonly string InsertUser = "Insert_User";
    }
}