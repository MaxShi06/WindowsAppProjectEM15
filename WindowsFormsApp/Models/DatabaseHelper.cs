using MySql.Data.MySqlClient;
using WindowsFormsApp.Services;

namespace WindowsFormsApp.Data
{
    public class DatabaseHelper
    {
        private ConnectionDatabaseService connector;

        public DatabaseHelper()
        {
            connector = new ConnectionDatabaseService("concerndb", "root", "root");
        }

        public ConnectionDatabaseService GetConnector()
        {
            return connector;
        }

        public void EnsureTables()
        {
            using (MySqlConnection connection = connector.getConnection())
            {
                connection.Open();

                new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS `Concerns` (
                        `Id`   INT          NOT NULL AUTO_INCREMENT,
                        `Name` VARCHAR(255) NOT NULL,
                        PRIMARY KEY (`Id`)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8;", connection).ExecuteNonQuery();

                new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS `Productions` (
                        `Id`             INT NOT NULL AUTO_INCREMENT,
                        `ConcernId`      INT NOT NULL,
                        `ProductionType` INT NOT NULL,
                        `Name`           VARCHAR(255) NOT NULL,
                        `Efficiency`     DOUBLE NOT NULL DEFAULT 100,
                        PRIMARY KEY (`Id`),
                        FOREIGN KEY (`ConcernId`) REFERENCES `Concerns`(`Id`)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8;", connection).ExecuteNonQuery();

                new MySqlCommand(@"
                    CREATE TABLE IF NOT EXISTS `WarehouseResources` (
                        `ConcernId`    INT    NOT NULL,
                        `ResourceType` INT    NOT NULL,
                        `Amount`       DOUBLE NOT NULL,
                        PRIMARY KEY (`ConcernId`, `ResourceType`),
                        FOREIGN KEY (`ConcernId`) REFERENCES `Concerns`(`Id`)
                    ) ENGINE=InnoDB DEFAULT CHARSET=utf8;", connection).ExecuteNonQuery();
            }
        }
    }
}
