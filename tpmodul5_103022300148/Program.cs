public class HaloGeneric() {
    public void SapaUser<T>(T x) {
        Console.WriteLine("Halo User " + x);
    }
}

public class Program() {
    public static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        String x = Console.ReadLine();
        halo.SapaUser(x);
    }
}
