public static class ApartmentExtensions
{
    public static ElectricalAppliance FindByType(Apartment apartment, string type)
    {
        foreach (ElectricalAppliance appliance in apartment.appliances)
        {
            if (appliance != null && appliance.GetType().Name == type)
            {
                return appliance;
            }
        }
        return null;
    }
}