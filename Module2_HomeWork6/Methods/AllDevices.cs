class AllDevice
{
    private ElectricalAppliance[] appliances;

    public AllDevice(ElectricalAppliance[] appliances)
    {
        this.appliances = appliances;
    }

    public void ShowAppliances()
    {
        foreach (ElectricalAppliance appliance in appliances)
        {
            if (appliance != null)
            {
                Console.WriteLine($"\n{appliance.Name}");
                Console.WriteLine($"Мощность: {appliance.Power} Вт");

                if (appliance is Blender blender)
                {
                    Console.WriteLine($"Таймер: {(blender.HasTimer ? "Есть" : "Нет")}");
                    Console.WriteLine($"Цвет: {blender.ColorName}");
                }
                else if (appliance is Oven oven)
                {
                    Console.WriteLine($"Таймер: {(oven.HasTimer ? "Есть" : "Нет")}");
                    Console.WriteLine($"Цвет: {oven.ColorName}");
                }
                else if (appliance is SmartTV smartTV)
                {
                    Console.WriteLine($"Марка: {smartTV.Brand}");
                    Console.WriteLine($"Канал: {smartTV.Channel}");
                    Console.WriteLine($"Цвет: {smartTV.ColorName}");
                }
                else if (appliance is StereoSystem stereoSystem)
                {
                    Console.WriteLine($"Марка: {stereoSystem.Brand}");
                    Console.WriteLine($"Громкость: {stereoSystem.Volume}");
                    Console.WriteLine($"Цвет: {stereoSystem.ColorName}");
                }
            }
        }
    }
}