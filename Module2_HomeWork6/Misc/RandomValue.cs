public class RandomValue
{
    private Random random;

    public RandomValue()
    {
        random = new Random();
    }

    public string GenerateColor()
    {
        string[] colors = { "красный", "синий", "зеленый", "желтый", "черный", "белый" };
        int index = random.Next(colors.Length);
        return colors[index];
    }

    public bool GenerateIsPluggedIn()
    {
        return random.Next(2) == 0; 
    }

    public int GeneratePower()
    {
        return random.Next(100, 2001);
    }
}