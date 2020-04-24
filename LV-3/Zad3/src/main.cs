using Zad3;

class MainClass {
    static void Main() {
        Logger logger = Logger.GetInstance();
        logger.Log("test123");
        logger.Log("test456");
        logger.FilePath = System.AppDomain.CurrentDomain.BaseDirectory + "log2.txt";
        logger.Log("test123");
        logger.Log("test456");

    }

}
