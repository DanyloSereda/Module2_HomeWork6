class SwitchOff
{
    private ElectricalAppliance[] appliances;

    public SwitchOff(ElectricalAppliance[] appliances)
    {
        this.appliances = appliances;
    }

    public void TurnOffAppliances()
    {
        bool allAppliancesArePluggedIn = true;

        foreach (ElectricalAppliance appliance in appliances)
        {
            if (appliance != null && !appliance.IsPluggedIn)
            {
                allAppliancesArePluggedIn = false;
                if (appliance is Blender blender)
                {
                    blender.Unplug();
                    Console.WriteLine(string.Empty);
                }
                else if (appliance is Oven oven)
                {
                    oven.Unplug();
                    Console.WriteLine(string.Empty);
                }
                else if (appliance is SmartTV smartTV)
                {
                    smartTV.Unplug();
                    Console.WriteLine(string.Empty);
                }
                else if (appliance is StereoSystem stereoSystem)
                {
                    stereoSystem.Unplug();
                }
            }
        }

        if (allAppliancesArePluggedIn)
        {
            Console.WriteLine("Все приборы включены");
        }
    }
}