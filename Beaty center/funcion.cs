using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beaty_center
{
    internal class funcion
    {
        public class ServiceInfo
        {
            public string ServiceName { get; set; }
            public string ServiceType { get; set; }

            public string ServicePicture { get; set; }

            public string Price { get; set; }

            public override string ToString()
            {
                return $"{ServiceName}|{ServiceType}|{ServicePicture}|{Price}";
            }

            public static ServiceInfo FromString(string line)
            {
                var parts = line.Split('|');
                return new ServiceInfo
                {
                    ServiceName = parts[0],
                    ServiceType = parts[1],
                    ServicePicture = parts[2],
                    Price = parts[3]
                };
            }
        }
    }
}
