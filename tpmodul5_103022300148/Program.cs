public class DataGeneric<T>(T data) {
    private T data = data;

    public void PrintData() {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
public class Program() { 
    public static void Main()
    {
        DataGeneric<long> data = new DataGeneric<long>(103022300148);
        data.PrintData();
    }   
}