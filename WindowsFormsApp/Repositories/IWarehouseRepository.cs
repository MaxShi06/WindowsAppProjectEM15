using WindowsFormsApp.Models;

namespace WindowsFormsApp.Repositories
{
    public interface IWarehouseRepository
    {
        void Save(Warehouse warehouse, int concernId);
        void Load(Warehouse warehouse, int concernId);
    }
}