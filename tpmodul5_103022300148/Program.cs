
﻿public class DataGeneric<T>(T data) {
    private T data = data;

    public void PrintData() {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
﻿public class HaloGeneric() {
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
        DataGeneric<long> data = new DataGeneric<long>(103022300148);
        data.PrintData();
    }
}
