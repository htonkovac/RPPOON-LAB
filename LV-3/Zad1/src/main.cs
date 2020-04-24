using Zad1;

class MainClass {
    static void Main() {
            Dataset ds = new Dataset(System.AppDomain.CurrentDomain.BaseDirectory + "dataset.csv");
            System.Console.WriteLine(ds);
    }

}
