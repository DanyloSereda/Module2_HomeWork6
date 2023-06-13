class StereoSystem : AudioDevice, IPluggable
{
    public override void Play()
    {
        Console.WriteLine(" Идет воспроизведение музыки на стереосистеме");
    }

    public void PlugIn()
    {
        Console.Write("Стереосистема подключена к розетке.");
        IsPluggedIn = true;
    }

    public void Unplug()
    {
        Console.Write("Стереосистема отключена от розетки.");
        IsPluggedIn = false;
    }
}