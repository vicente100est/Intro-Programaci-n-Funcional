
Operacion mySum = Functions.Suma;
Console.WriteLine(mySum(5,10));

mySum = Functions.Mul;
Console.WriteLine(mySum(10, 1));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola Perrin");

Functions.Some("Vicente", "Estrada", cw);

public delegate int Operacion(int a, int b);
public delegate void Show(string message);

public class Functions
{
    public static int Suma(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    //Funcion de horden superior
    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al Final");
    }
}