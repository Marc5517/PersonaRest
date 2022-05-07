using PersonaRest.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PersonaRest.DBUtil
{
    public class ManagePersona
    {
        private const String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PersonaDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private const String Get_All = "Select * from Persona";

        public IEnumerable<Persona> Get()
        {
            List<Persona> liste = new List<Persona>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(Get_All, conn))
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Persona per = ReadNextElement(reader);
                    liste.Add(per);
                }

                reader.Close();
            }

            return liste;
        }

        private Persona ReadNextElement(SqlDataReader reader)
        {
            Persona persona = new Persona();

            persona.PersonaId = reader.GetInt32(0);
            persona.Name = reader.GetString(1);
            persona.Level = reader.GetInt32(2);
            persona.Arcana = reader.GetString(3);

            return persona;
        }
    }
}
