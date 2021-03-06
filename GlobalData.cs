using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDatabase
{
    // Use this class to store all global data for your application
    public static class GlobalData
    {

        // Database setup (either one works)
        public static string dataSource = @"Data Source=..\..\Database\DBMS.db";
        //public static string dataSource = @"Data Source=..\..\Databases\booksDatabase.db";
        
        //Stores the acc_Id of current logged user.
        public static string accId;

        // Stores the Inventory information of a user
        public static int InventoryId;

        // Stores the User account type
        public static string accType;

        // Stores department Id
        public static int DepartmentId;

        // stores finance Id
        public static int FinanceId;

        // stores service id
        public static int ServiceId;


    }
}
 