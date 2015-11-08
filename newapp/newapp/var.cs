using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newapp
{
    public static class GlobalVar
    {
        /// <summary>
        /// Global variable that is constant.
        /// </summary>
        public static string Globalname = "Important Text";
        public static string Globalcontact = "Important Text";
        public static bool Globalg = true;
        public static bool Globalftb = false;
        public static bool Globalmv = false;
        public static bool Globaldisc = false;
        public static bool Globalcsgo = false;
        public static string Globalage = "Important Text";

        /// <summary>
        /// Static value protected by access routine.
        /// </summary>
        static int globalValue;

        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static int GlobalValue
        {
            get
            {
                return globalValue;
            }
            set
            {
                globalValue = value;
            }
        }

       
        /// <summary>
        /// Global static field.
        /// </summary>

    }
}