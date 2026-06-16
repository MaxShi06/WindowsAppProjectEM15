using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Concern _concern;

        public Form1()
        {
            InitializeComponent();
            InitializeConcern();
            RefreshProductions();
            RefreshWarehouse();
        }

        private void InitializeConcern()
        {
            _concern = new Concern { id = 1, name = "Концерн Альфа" };
            _concern.warehouse = new Warehouse { id = 1 };
            this.Text = $"Симулятор концерну — {_concern.name}";

            _concern.warehouse.AddResources(new List<ResourceAmount>
            {
                new ResourceAmount(ResourceType.Coal, 20)
            });

            var ps = new PowerStation { id = 1, name = "Електростанція #1", maxCapacity = 100 };
            var psRecipe = new Recipe(1, "Вугілля -> Електрика", 1);
            psRecipe.AddRequiredResource(ResourceType.Coal, 1);
            psRecipe.AddReceivedResource(ResourceType.Electricity, 10);
            ps.recipeList.Add(psRecipe);
            ps.SetActiveRecipe(psRecipe);

            var cm = new CoalMine { id = 2, name = "Вугільна шахта #1" };
            var cmRecipe = new Recipe(2, "Видобуток вугілля", 1);
            cmRecipe.AddRequiredResource(ResourceType.Electricity, 3);
            cmRecipe.AddReceivedResource(ResourceType.Coal, 10);
            cm.recipeList.Add(cmRecipe);
            cm.SetActiveRecipe(cmRecipe);

            var im = new IronMine { id = 3, name = "Залізна шахта #1" };
            var imRecipe = new Recipe(3, "Видобуток залізної руди", 1);
            imRecipe.AddRequiredResource(ResourceType.Electricity, 5);
            imRecipe.AddReceivedResource(ResourceType.IronOre, 10);
            im.recipeList.Add(imRecipe);
            im.SetActiveRecipe(imRecipe);

            var ow = new OilWell { id = 4, name = "Нафтова свердловина #1" };
            var owRecipe = new Recipe(4, "Видобуток нафти", 1);
            owRecipe.AddRequiredResource(ResourceType.Electricity, 3);
            owRecipe.AddReceivedResource(ResourceType.Oil, 5);
            ow.recipeList.Add(owRecipe);
            ow.SetActiveRecipe(owRecipe);

            var sp = new SteelPlant { id = 5, name = "Сталеливарний завод" };
            var spRecipe = new Recipe(5, "Залізна руда -> Метали", 1);
            spRecipe.AddRequiredResource(ResourceType.IronOre, 10);
            spRecipe.AddRequiredResource(ResourceType.Electricity, 10);
            spRecipe.AddReceivedResource(ResourceType.Iron, 8);
            spRecipe.AddReceivedResource(ResourceType.Copper, 1);
            spRecipe.AddReceivedResource(ResourceType.Lead, 1);
            sp.recipeList.Add(spRecipe);
            sp.SetActiveRecipe(spRecipe);

            var orf = new OilRefinery { id = 6, name = "Нафтопереробний завод" };
            var orfRecipe = new Recipe(6, "Нафта -> Паливо і Пластик", 1);
            orfRecipe.AddRequiredResource(ResourceType.Oil, 12);
            orfRecipe.AddRequiredResource(ResourceType.Electricity, 10);
            orfRecipe.AddReceivedResource(ResourceType.Fuel, 8);
            orfRecipe.AddReceivedResource(ResourceType.Plastic, 2);
            orf.recipeList.Add(orfRecipe);
            orf.SetActiveRecipe(orfRecipe);

            var af = new ApplianceFactory { id = 7, name = "Завод побутової техніки" };
            var afRecipe = new Recipe(7, "Виробництво чайників", 1);
            afRecipe.AddRequiredResource(ResourceType.Electricity, 5);
            afRecipe.AddRequiredResource(ResourceType.Iron, 2);
            afRecipe.AddRequiredResource(ResourceType.Copper, 1);
            afRecipe.AddRequiredResource(ResourceType.Plastic, 3);
            afRecipe.AddReceivedResource(ResourceType.Kettle, 1);
            af.recipeList.Add(afRecipe);
            af.SetActiveRecipe(afRecipe);

            _concern.productionList.AddRange(new Production[] { ps, cm, im, ow, sp, orf, af });
        }

        private void RefreshProductions()
        {
            listBoxProductions.Items.Clear();
            foreach (var p in _concern.productionList)
                listBoxProductions.Items.Add(p.name);
        }

        private void RefreshWarehouse()
        {
            listViewWarehouse.Items.Clear();
            foreach (var r in _concern.warehouse.resourceList)
            {
                if (r.amount <= 0) continue;
                var item = new ListViewItem(r.resourceType.DisplayName());
                item.SubItems.Add(r.amount.ToString("F1"));
                listViewWarehouse.Items.Add(item);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            _concern.RunCycle((int)numericUpDownDays.Value, msg => richTextBoxLog.AppendText(msg + "\n"));
            RefreshWarehouse();
            richTextBoxLog.ScrollToCaret();
        }

        private void listBoxProductions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
