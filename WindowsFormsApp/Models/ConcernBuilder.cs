using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class ConcernBuilder
    {
        private Concern concern;
        private int nextId;

        public ConcernBuilder(int id, string name)
        {
            concern = new Concern(id, name);
            Warehouse warehouse = new Warehouse(id);
            concern.warehouse = warehouse;
            nextId = 1;
        }

        public void AddInitialResources(ResourceType type, double amount)
        {
            List<ResourceAmount> resources = new List<ResourceAmount>();
            ResourceAmount resourceAmount = new ResourceAmount(type, amount);
            resources.Add(resourceAmount);
            concern.warehouse.AddResources(resources);
        }

        public void AddPowerStation(string name)
        {
            PowerStation station = PowerStation.Create(nextId, name);
            concern.productionList.Add(station);
            nextId = nextId + 1;
        }

        public void AddCoalMine(string name)
        {
            CoalMine mine = CoalMine.Create(nextId, name);
            concern.productionList.Add(mine);
            nextId = nextId + 1;
        }

        public void AddIronMine(string name)
        {
            IronMine mine = IronMine.Create(nextId, name);
            concern.productionList.Add(mine);
            nextId = nextId + 1;
        }

        public void AddOilWell(string name)
        {
            OilWell well = OilWell.Create(nextId, name);
            concern.productionList.Add(well);
            nextId = nextId + 1;
        }

        public void AddSteelPlant(string name)
        {
            SteelPlant plant = SteelPlant.Create(nextId, name);
            concern.productionList.Add(plant);
            nextId = nextId + 1;
        }

        public void AddOilRefinery(string name)
        {
            OilRefinery refinery = OilRefinery.Create(nextId, name);
            concern.productionList.Add(refinery);
            nextId = nextId + 1;
        }

        public void AddApplianceFactory(string name)
        {
            ApplianceFactory factory = ApplianceFactory.Create(nextId, name);
            concern.productionList.Add(factory);
            nextId = nextId + 1;
        }

        public Concern Build()
        {
            return concern;
        }
    }
}
