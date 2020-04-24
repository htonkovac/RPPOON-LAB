using Zad2;

class MainClass {
    static void Main() {
            MatrixGenerator mg = MatrixGenerator.GetInstance();
            double[][] matrix = mg.GenerateMatrix(5,6);
            foreach (double[] row in matrix) {
                foreach (double elem in row) {
                    System.Console.Write(elem + " ");
                }
                System.Console.WriteLine();
            }

    }
}
