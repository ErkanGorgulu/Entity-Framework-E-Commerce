using Northwind.Helpers.Properties;
//burayı unutmayın...

namespace Northwind.Helpers
{
    public class ConnectionTools
    {
        public static string ConnectionString
        {
            get
            {
                return Configuration.Default.ConnectionPath;
            }
        }
    }
}