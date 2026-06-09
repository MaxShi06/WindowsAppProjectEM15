using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            var concern = new Concern { id = 1, name = "Концерн Альфа" };
            concern.warehouse = new Warehouse { id = 1 };

          
            concern.warehouse.AddResources(new List<ResourceAmount>
            {
                new ResourceAmount(ResourceType.Coal, 20)
            });

           
            var ps = new PowerStation { id = 1, name = "Електростанція #1", maxCapacity = 100 };
            var psRecipe = new Recipe
            {
                id = 1, name = "Вугілля -> Електрика", duration = 1,
                requiredResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Coal, 1) },
                receivedResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Electricity, 10) }
            };
            ps.recipeList.Add(psRecipe);
            ps.SetActiveRecipe(psRecipe);

            
            var cm = new CoalMine { id = 2, name = "Вугільна шахта #1" };
            var cmRecipe = new Recipe
            {
                id = 2, name = "Видобуток вугілля", duration = 1,
                requiredResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Electricity, 3) },
                receivedResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Coal, 10) }
            };
            cm.recipeList.Add(cmRecipe);
            cm.SetActiveRecipe(cmRecipe);


            var im = new IronMine { id = 3, name = "Залізна шахта #1" };
            var imRecipe = new Recipe
            {
                id = 3, name = "Видобуток залізної руди", duration = 1,
                requiredResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Electricity, 5) },
                receivedResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.IronOre, 10) }
            };
            im.recipeList.Add(imRecipe);
            im.SetActiveRecipe(imRecipe);

        
            var ow = new OilWell { id = 4, name = "Нафтова свердловина #1" };
            var owRecipe = new Recipe
            {
                id = 4, name = "Видобуток нафти", duration = 1,
                requiredResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Electricity, 3) },
                receivedResourcesList = new List<ResourceAmount> { new ResourceAmount(ResourceType.Oil, 5) }
            };
            ow.recipeList.Add(owRecipe);
            ow.SetActiveRecipe(owRecipe);

          
            var sp = new SteelPlant { id = 5, name = "Сталеливарний завод" };
            var spRecipe = new Recipe
            {
                id = 5, name = "Залізна руда -> Метали", duration = 1,
                requiredResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.IronOre, 10),
                    new ResourceAmount(ResourceType.Electricity, 10)
                },
                receivedResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.Iron, 8),
                    new ResourceAmount(ResourceType.Copper, 1),
                    new ResourceAmount(ResourceType.Lead, 1)
                }
            };
            sp.recipeList.Add(spRecipe);
            sp.SetActiveRecipe(spRecipe);


            var orf = new OilRefinery { id = 6, name = "Нафтопереробний завод" };
            var orfRecipe = new Recipe
            {
                id = 6, name = "Нафта -> Паливо і Пластик", duration = 1,
                requiredResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.Oil, 12),
                    new ResourceAmount(ResourceType.Electricity, 10)
                },
                receivedResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.Fuel, 8),
                    new ResourceAmount(ResourceType.Plastic, 2)
                }
            };
            orf.recipeList.Add(orfRecipe);
            orf.SetActiveRecipe(orfRecipe);

          
            var af = new ApplianceFactory { id = 7, name = "Завод побутової техніки" };
            var afRecipe = new Recipe
            {
                id = 7, name = "Виробництво чайників", duration = 1,
                requiredResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.Electricity, 5),
                    new ResourceAmount(ResourceType.Iron, 2),
                    new ResourceAmount(ResourceType.Copper, 1),
                    new ResourceAmount(ResourceType.Plastic, 3)
                },
                receivedResourcesList = new List<ResourceAmount>
                {
                    new ResourceAmount(ResourceType.Kettle, 1)
                }
            };
            af.recipeList.Add(afRecipe);
            af.SetActiveRecipe(afRecipe);

            concern.productionList.Add(ps);
            concern.productionList.Add(cm);
            concern.productionList.Add(im);
            concern.productionList.Add(ow);
            concern.productionList.Add(sp);
            concern.productionList.Add(orf);
            concern.productionList.Add(af);

            Console.WriteLine($"=== Симуляція: {concern.name} ===");
            concern.RunCycle(10);

            Console.WriteLine("\nНатисніть будь-яку клавішу...");
            Console.ReadKey();

            // форму ще не робив,поки через консоль тестував.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}