namespace Salinto.Util;

public static class PesoFormatter
{
    public static string ToPesos(int amount) => $"₱{amount:N0}";
}
