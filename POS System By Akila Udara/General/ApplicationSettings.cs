using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace POS_System_By_Akila_Udara.General
{
    public class ApplicationSettings
    {
        public static string ConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
        }
    }
}
