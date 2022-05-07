using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaRest.Controllers
{
    internal class ConnectionString
    {
        public static readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
