namespace WindowsFormsApp.Models
{
    public class ApplianceFactory : Production
    {
        public override void Produce(Warehouse warehouse, ref int availableElectricity)
        {
            ProduceWithElectricity(warehouse, ref availableElectricity);
        }
    }
}