using System.Collections.Generic;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Repositories
{
    public interface IConcernRepository
    {
        int  Save(Concern concern);
        Concern Load(int id);
        List<(int Id, string Name)> GetAll();
    }
}
