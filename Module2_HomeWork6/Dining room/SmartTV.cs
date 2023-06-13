class SmartTV : Television
{
    public override void Play()
    {
        Console.WriteLine(" Телевизор воспроизводит программу в режиме Smart TV");
    }

    public void PlugIn()
    {
        Console.Write("Телевизор подключен к розетке.");
        IsPluggedIn = true;
    }

    public void Unplug()
    {
        Console.Write("Телевизор отключен от розетки.");
        IsPluggedIn = false;
    }
}