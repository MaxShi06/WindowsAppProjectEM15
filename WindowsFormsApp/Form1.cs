using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp.Models;
using WindowsFormsApp.Models.Resources;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Concern concern;
        private ConcernBuilder concernBuilder;

        public Form1()
        {
            InitializeComponent();
            InitializeConcern();
            RefreshProductions();
            RefreshWarehouse();
        }

        private void InitializeConcern()
        {
            concernBuilder = new ConcernBuilder(1, "Концерн Альфа");

            concernBuilder.AddInitialResources(ResourceType.Coal, 20);
            concernBuilder.AddPowerStation("Електростанція #1");
            concernBuilder.AddCoalMine("Вугільна шахта #1");
            concernBuilder.AddIronMine("Залізна шахта #1");
            concernBuilder.AddOilWell("Нафтова свердловина #1");
            concernBuilder.AddSteelPlant("Сталеливарний завод");
            concernBuilder.AddOilRefinery("Нафтопереробний завод");
            concernBuilder.AddApplianceFactory("Завод побутової техніки");

            concern = concernBuilder.Build();

            Text = "Симулятор концерну - " + concern.name;
        }

        private void RefreshProductions()
        {
            listBoxProductions.Items.Clear();

            foreach (Production p in concern.productionList)
            {
                listBoxProductions.Items.Add(p.name);
            }
        }

        private void RefreshWarehouse()
        {
            listViewWarehouse.Items.Clear();

            foreach (ResourceAmount r in concern.warehouse.ResourceList)
            {
                if (r.amount > 0)
                {
                    ListViewItem item = new ListViewItem(r.resourceType.DisplayName());
                    item.SubItems.Add(r.amount.ToString("F1"));
                    listViewWarehouse.Items.Add(item);
                }
            }
        }

        private void buttonAddPowerStation_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Електростанція #" + number;
            concernBuilder.AddPowerStation(name);
            RefreshProductions();
        }

        private void buttonAddCoalMine_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Вугільна шахта #" + number;
            concernBuilder.AddCoalMine(name);
            RefreshProductions();
        }

        private void buttonAddIronMine_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Залізна шахта #" + number;
            concernBuilder.AddIronMine(name);
            RefreshProductions();
        }

        private void buttonAddOilWell_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Нафтова свердловина #" + number;
            concernBuilder.AddOilWell(name);
            RefreshProductions();
        }

        private void buttonAddSteelPlant_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Сталеливарний завод #" + number;
            concernBuilder.AddSteelPlant(name);
            RefreshProductions();
        }

        private void buttonAddOilRefinery_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Нафтопереробний завод #" + number;
            concernBuilder.AddOilRefinery(name);
            RefreshProductions();
        }

        private void buttonAddApplianceFactory_Click(object sender, EventArgs e)
        {
            int number = concern.productionList.Count + 1;
            string name = "Завод побутової техніки #" + number;
            concernBuilder.AddApplianceFactory(name);
            RefreshProductions();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int days = (int)numericUpDownDays.Value;
            concern.RunCycle(days);

            richTextBoxLog.Clear();

            foreach (string line in concern.log)
            {
                richTextBoxLog.AppendText(line + "\n");
            }

            RefreshWarehouse();
            richTextBoxLog.ScrollToCaret();
        }

        private void buttonRun_MouseEnter(object sender, EventArgs e)
        {
            buttonRun.BackColor = Color.FromArgb(0, 99, 166);
        }

        private void buttonRun_MouseLeave(object sender, EventArgs e)
        {
            buttonRun.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void listBoxProductions_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
        }

        private void listViewWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
