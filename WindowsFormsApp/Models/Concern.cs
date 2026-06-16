using System;
using System.Collections.Generic;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp.Models
{
    public class Concern
    {
        public int id;

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
        public Warehouse warehouse;
        public int availableElectricity;

        public void RunCycle(int days, Action<string> log = null)
        {
            for (int day = 1; day <= days; day++)
            {
                availableElectricity = 0;
                log?.Invoke($"=== День {day} ===");

                foreach (var p in productionList)
                    if (p is PowerStation)
                        p.Produce(warehouse, ref availableElectricity, log);

                log?.Invoke($"  Електрика: {availableElectricity}");

                foreach (var p in productionList)
                    if (!(p is PowerStation))
                        p.Produce(warehouse, ref availableElectricity, log);

                log?.Invoke("  [Склад]");
                foreach (var r in warehouse.resourceList)
                    if (r.amount > 0)
                        log?.Invoke($"    {r.resourceType.DisplayName()}: {r.amount:F1}");
            }
        }
    }
}
