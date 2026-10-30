namespace lab1;

internal static class Alphabet
{
    public const string Characters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

    public static int NormalizeIndex(int value)
    {
        while (value < 0)
        {
            value += Characters.Length;
        }

        while (value >= Characters.Length)
        {
            value -= Characters.Length;
        }

        return value;
    }
}
