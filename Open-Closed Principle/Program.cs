namespace Solid;

public partial class Program
{
    public static void MainOCP(string[] args) {
        Animal lion = new Lion();
        Animal cat = new Cat();
        cat.MakeSound();    
        lion.MakeSound();
    }
}
