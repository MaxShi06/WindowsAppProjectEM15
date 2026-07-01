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

        public ConcernBuilder AddInitialResources(ResourceType type, double amount)
        {
            List<ResourceAmount> resources = new List<ResourceAmount>();
            resources.Add(new ResourceAmount(type, amount));
            concern.warehouse.AddResources(resources);
            return this;
        }

        public ConcernBuilder AddPowerStation(string name)
        {
            concern.productionList.Add(PowerStation.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddCoalMine(string name)
        {
            concern.productionList.Add(CoalMine.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddIronMine(string name)
        {
            concern.productionList.Add(IronMine.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddOilWell(string name)
        {
            concern.productionList.Add(OilWell.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddSteelPlant(string name)
        {
            concern.productionList.Add(SteelPlant.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddOilRefinery(string name)
        {
            concern.productionList.Add(OilRefinery.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public ConcernBuilder AddApplianceFactory(string name)
        {
            concern.productionList.Add(ApplianceFactory.Create(nextId, name));
            nextId = nextId + 1;
            return this;
        }

        public Concern Build()
        {
            return concern;
        }
    }
}
