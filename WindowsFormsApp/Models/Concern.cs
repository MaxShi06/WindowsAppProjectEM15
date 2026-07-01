using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Concern
    {
        public int id { get; private set; }

        private string _name;
        public string name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                    throw new ArgumentException("Назва концерну не може бути порожньою");
            }
        }

        public List<Production> productionList = new List<Production>();
        public Warehouse warehouse = null;
        public int availableElectricity = 0;
        public List<string> log = new List<string>();

        public Concern(int id, string name)
        {
            this.id = id;
            this.name = name;
            warehouse = new Warehouse(id);
        }

        public void RunCycle(int days)
        {
            log.Clear();

            for (int day = 1; day <= days; day++)
            {
                log.Add($"=== День {day} ===");

                foreach (var p in productionList)
                    if (p is PowerStation)
                        p.Produce(warehouse, log);

                log.Add($"  Електрика: {warehouse.GetAmount(ResourceType.Electricity)}");

                foreach (var p in productionList)
                    if (!(p is PowerStation))
                        p.Produce(warehouse, log);

                log.Add("  [Склад]");
                foreach (var r in warehouse.ResourceList)
                    if (r.amount > 0)
                        log.Add($"    {r.resourceType.DisplayName()}: {r.amount:F1}");
            }
        }
    }
}
