using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WindowsFormsApp.Models;
using WindowsFormsApp.Models.Resources;
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        private ConnectionDatabaseService connector;

        public WarehouseRepository(ConnectionDatabaseService connector)
        {
            this.connector = connector;
        }

        public void Save(Warehouse warehouse, int concernId)
        {
            using (MySqlConnection conn = connector.getConnection())
            {
                conn.Open();

                MySqlCommand delete = new MySqlCommand(
                    "DELETE FROM WarehouseResources WHERE ConcernId = @id", conn);
                delete.Parameters.AddWithValue("@id", concernId);
                delete.ExecuteNonQuery();

                foreach (ResourceAmount r in warehouse.ResourceList)
                {
                    if (r.amount <= 0) continue;

                    MySqlCommand insert = new MySqlCommand(
                        "INSERT INTO WarehouseResources (ConcernId, ResourceType, Amount) VALUES (@cid, @rt, @amount)", conn);
                    insert.Parameters.AddWithValue("@cid", concernId);
                    insert.Parameters.AddWithValue("@rt", (int)r.resourceType);
                    insert.Parameters.AddWithValue("@amount", r.amount);
                    insert.ExecuteNonQuery();
                }
            }
        }

        public void Load(Warehouse warehouse, int concernId)
        {
            using (MySqlConnection conn = connector.getConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT ResourceType, Amount FROM WarehouseResources WHERE ConcernId = @id", conn);
                cmd.Parameters.AddWithValue("@id", concernId);

                List<ResourceAmount> resources = new List<ResourceAmount>();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ResourceType rt = (ResourceType)reader.GetInt32("ResourceType");
                        double amount = reader.GetDouble("Amount");
                        resources.Add(new ResourceAmount(rt, amount));
                    }
                }

                warehouse.AddResources(resources);
            }
        }
    }
}