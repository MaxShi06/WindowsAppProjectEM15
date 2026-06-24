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

            concern.productionList.Add(PowerStation.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddCoalMine(string name)
        {
            concern.productionList.Add(CoalMine.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddIronMine(string name)
        {
            concern.productionList.Add(IronMine.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddOilWell(string name)
        {
            concern.productionList.Add(OilWell.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddSteelPlant(string name)
        {
            concern.productionList.Add(SteelPlant.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddOilRefinery(string name)
        { 
            concern.productionList.Add(OilRefinery.Create(nextId, name));
            nextId = nextId + 1;
        }

        public void AddApplianceFactory(string name)
        {
            concern.productionList.Add(ApplianceFactory.Create(nextId, name));
            nextId = nextId + 1;
        }

        public Concern Build()
        {
            return concern;
        }
    }
}
