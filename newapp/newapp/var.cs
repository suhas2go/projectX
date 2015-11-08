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
        public static bool GlobalBoolean;
    }
}