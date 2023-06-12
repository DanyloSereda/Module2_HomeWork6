public class Starter
{
    public void Run()
    {
        Apartment apartment = new Apartment(10);
        RandomValue randomValue = new RandomValue();

        ElectricalAppliance[] appliances = new ElectricalAppliance[4];
        AllDevice allDevice = new AllDevice(appliances);
        SwitchOn switchOn = new SwitchOn(appliances);
        SwitchOff switchOff = new SwitchOff(appliances);

        StereoSystem stereoSystem = new StereoSystem();
        stereoSystem.Name = "Стереосистема";
        stereoSystem.Power = randomValue.GeneratePower();
        stereoSystem.Brand = "Sony";
        stereoSystem.IsPluggedIn = randomValue.GenerateIsPluggedIn();
        stereoSystem.Volume = 10;
        stereoSystem.ColorName = randomValue.GenerateColor();
        appliances[3] = stereoSystem;

        Blender blender = new Blender();
        blender.Name = "Блендер";
        blender.Power = randomValue.GeneratePower();
        blender.HasTimer = true;
        blender.IsPluggedIn = randomValue.GenerateIsPluggedIn();
        blender.ColorName = randomValue.GenerateColor();
        appliances[0] = blender;

        Oven oven = new Oven();
        oven.Name = "Печь";
        oven.Power = randomValue.GeneratePower();
        oven.HasTimer = true;
        oven.IsPluggedIn = randomValue.GenerateIsPluggedIn();
        oven.ColorName = randomValue.GenerateColor();
        appliances[1] = oven;

        SmartTV smartTV = new SmartTV();
        smartTV.Name = "Телевизор";
        smartTV.Power = randomValue.GeneratePower();
        smartTV.Brand = "Samsung";
        smartTV.IsPluggedIn = randomValue.GenerateIsPluggedIn();
        smartTV.Channel = 4;
        smartTV.ColorName = randomValue.GenerateColor();
        appliances[2] = smartTV;

        for (int i = 0; i < appliances.Length; i++)
        {
            if (appliances[i] != null)
            {
                apartment.AddAppliance(appliances[i]);
            }
        }

        Console.WriteLine("Приборы в квартире: ");
        allDevice.ShowAppliances();

        Console.WriteLine("\nСписок включенных приборов:\n");
        switchOn.TurnOnAppliances();

        Console.WriteLine("\nСписок выключенных приборов:\n");
        switchOff.TurnOffAppliances();

        int totalPower = apartment.CalculateTotalPower();
        int currentPower = apartment.CalculateCurrentPower();
        Console.WriteLine($"\n\nОбщая потребляемая мощность: {totalPower} Вт (В текущий момент: {currentPower} Вт)" );
        foreach (ElectricalAppliance appliance in apartment.appliances)
        {
            if (appliance != null && appliance.IsPluggedIn && appliance.IsPluggedIn)
            {
                Console.WriteLine($"{appliance.Name} - Мощность: {appliance.Power} Вт");
            }
        }

        apartment.SortAppliancesByPower();

        Console.WriteLine("\nСортировка по мощности (от низкого к высокому):");
        for (int i = 0; i < apartment.ApplianceCount; i++)
        {
            if (apartment.appliances[i] != null)
            {
                Console.WriteLine($"{apartment.appliances[i].Name} - Мощность: {apartment.appliances[i].Power} Вт");
            }
        }

        string searchType = "Blender";
        ElectricalAppliance foundAppliance = ApartmentExtensions.FindByType(apartment, searchType);
        if (foundAppliance != null)
        {
            Console.WriteLine("\nНайден прибор типа " + searchType + ": " + foundAppliance.Name);
        }
        else
        {
            Console.WriteLine("\nПрибор типа " + searchType + " не найден в квартире");
        }
    }
}