public class Apartment
{
    public ElectricalAppliance[] appliances;

    public int ApplianceCount
    {
        get { return appliances.Length; }
    }

    public Apartment(int maxAppliances)
    {
        appliances = new ElectricalAppliance[maxAppliances];
    }

    public void AddAppliance(ElectricalAppliance appliance)
    {
        if (appliances.Length > 0)
        {
            int index = Array.IndexOf(appliances, null);
            if (index >= 0)
            {
                appliances[index] = appliance;
            }
            else
            {
                Console.WriteLine("Невозможно добавить больше приборов в квартиру");
            }
        }
        else
        {
            Console.WriteLine("Невозможно добавить приборы в квартиру");
        }
    }

    public int CalculateTotalPower()
    {
        int totalPower = 0;

        foreach (ElectricalAppliance appliance in appliances)
        {
            if (appliance != null)
            {
                totalPower += appliance.Power;
            }
        }

        return totalPower;
    }

    public int CalculateCurrentPower()
    {
        int currentPower = 0;

        foreach (ElectricalAppliance appliance in appliances)
        {
            if (appliance != null && appliance.IsPluggedIn)
            {
                currentPower += appliance.Power;
            }
        }

        return currentPower;
    }

    public void SortAppliancesByPower()
    {
        Array.Sort(appliances, 0, ApplianceCount, Comparer<ElectricalAppliance>.Create((x, y) =>
        {
            if (x == null || y == null)
                return 1;

            int powerComparison = x.Power.CompareTo(y.Power);
            if (powerComparison != 0)
                return powerComparison;

            return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase);
        }));
    }
}
