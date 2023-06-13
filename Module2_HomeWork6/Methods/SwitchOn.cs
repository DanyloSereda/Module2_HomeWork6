class SwitchOn
{
    private ElectricalAppliance[] appliances;

    public SwitchOn(ElectricalAppliance[] appliances)
    {
        this.appliances = appliances;
    }

    public void TurnOnAppliances()
    {
        foreach (ElectricalAppliance appliance in appliances)
        {
            if (appliance != null && appliance.IsPluggedIn)
            {
                if (appliance is Blender blender)
                {
                    blender.PlugIn();
                    blender.Cook();
                }
                else if (appliance is Oven oven)
                {
                    oven.PlugIn();
                    oven.Cook();
                }
                else if (appliance is SmartTV smartTV)
                {
                    smartTV.PlugIn();
                    smartTV.Play();
                }
                else if (appliance is StereoSystem stereoSystem)
                {
                    stereoSystem.PlugIn();
                    stereoSystem.Play();
                }
            }
        }
    }
}