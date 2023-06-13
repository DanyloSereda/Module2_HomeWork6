class Oven : LargeKitchenAppliance, IPluggable
{
    public override void Cook()
    {
        Console.WriteLine(" Пища готовится в печи");
    }

    public void PlugIn()
    {
        Console.Write("Печь подключена к розетке.");
        IsPluggedIn = true;
    }

    public void Unplug()
    {
        Console.Write("Печь отключена от розетки.");
        IsPluggedIn = false;
    }
}
