class Blender : SmallKitchenAppliance, IPluggable
{
    public override void Cook()
    {
        Console.WriteLine(" Идет приготовление блюда в блендере");
    }

    public void PlugIn()
    {
        Console.Write("Блендер подключен к розетке.");
        IsPluggedIn = true;
    }

    public void Unplug()
    {
        Console.Write("Блендер отключен от розетки.");
        IsPluggedIn = false;
    }
}