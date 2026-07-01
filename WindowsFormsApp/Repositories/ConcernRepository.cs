using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using WindowsFormsApp.Models;
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Repositories
{
    public class ConcernRepository : IConcernRepository
    {
        private ConnectionDatabaseService connector;
        private IWarehouseRepository warehouseRepository;

        public ConcernRepository(ConnectionDatabaseService connector)
        {
            this.connector = connector;
            this.warehouseRepository = new WarehouseRepository(connector);
        }

        public int Save(Concern concern)
        {
            int concernId;

            using (MySqlConnection conn = connector.getConnection())
            {
                conn.Open();

                if (concern.id == 0)
                {
                    MySqlCommand insert = new MySqlCommand(
                        "INSERT INTO Concerns (Name) VALUES (@name)", conn);
                    insert.Parameters.AddWithValue("@name", concern.name);
                    insert.ExecuteNonQuery();
                    concernId = (int)insert.LastInsertedId;
                }
                else
                {
                    MySqlCommand upsert = new MySqlCommand(
                        "INSERT INTO Concerns (Id, Name) VALUES (@id, @name) ON DUPLICATE KEY UPDATE Name = @name", conn);
                    upsert.Parameters.AddWithValue("@id", concern.id);
                    upsert.Parameters.AddWithValue("@name", concern.name);
                    upsert.ExecuteNonQuery();
                    concernId = concern.id;
                }

                MySqlCommand deleteProds = new MySqlCommand(
                    "DELETE FROM Productions WHERE ConcernId = @id", conn);
                deleteProds.Parameters.AddWithValue("@id", concernId);
                deleteProds.ExecuteNonQuery();

                foreach (Production p in concern.productionList)
                {
                    int typeInt = (int)p.GetProductionType();
                    MySqlCommand insertProd = new MySqlCommand(
                        "INSERT INTO Productions (ConcernId, ProductionType, Name, Efficiency) VALUES (@cid, @type, @name, @eff)", conn);
                    insertProd.Parameters.AddWithValue("@cid", concernId);
                    insertProd.Parameters.AddWithValue("@type", typeInt);
                    insertProd.Parameters.AddWithValue("@name", p.name);
                    insertProd.Parameters.AddWithValue("@eff", p.efficiency);
                    insertProd.ExecuteNonQuery();
                }
            }

            warehouseRepository.Save(concern.warehouse, concernId);

            return concernId;
        }

        public Concern Load(int id)
        {
            Concern concern;

            using (MySqlConnection conn = connector.getConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT Name FROM Concerns WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) return null;
                    concern = new Concern(id, reader.GetString("Name"));
                }

                MySqlCommand prodCmd = new MySqlCommand(
                    "SELECT Id, ProductionType, Name, Efficiency FROM Productions WHERE ConcernId = @id", conn);
                prodCmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = prodCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int prodId   = reader.GetInt32("Id");
                        int typeInt  = reader.GetInt32("ProductionType");
                        string name  = reader.GetString("Name");
                        double eff   = reader.GetDouble("Efficiency");

                        Production p = Production.Create(prodId, name, (ProductionType)typeInt, eff);
                        if (p != null) concern.productionList.Add(p);
                    }
                }
            }

            warehouseRepository.Load(concern.warehouse, id);

            return concern;
        }

        public List<(int Id, string Name)> GetAll()
        {
            List<(int Id, string Name)> result = new List<(int Id, string Name)>();

            using (MySqlConnection conn = connector.getConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT Id, Name FROM Concerns", conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        result.Add((reader.GetInt32("Id"), reader.GetString("Name")));
                }
            }

            return result;
        }

    }
}
