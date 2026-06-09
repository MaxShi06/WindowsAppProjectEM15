namespace WindowsFormsApp.Models
{
    public class CoalMine : Production
    {
        public override void Produce(Warehouse warehouse, ref int availableElectricity)
        {
            ProduceWithElectricity(warehouse, ref availableElectricity);
        }
    }
}