
Operacion mySum = Functions.Suma;
Console.WriteLine(mySum(5,10));

mySum = Functions.Mul;
Console.WriteLine(mySum(10, 1));

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow;
//cw("Hola Perrin");

//Functions.Some("Vicente", "Estrada", cw);

#region Action
/*
string hi = "Hola";
Action<string> showMesagge = Console.WriteLine;
Action<string, string> showMessage2 = (a, b) =>
{
    Console.WriteLine($"{hi} {a} {b}");
};
Action<string, string, string> showMessage3 = (a, b, c) =>
{
    Console.WriteLine($"{hi} {a} {b} {c}");
};

showMessage2("Mariana", "Morales");
showMessage3("María de Lourdes", "Domínguez", "Domínguez");
Functions.Some("Vicente", "De Leon", (a) =>
{
    Console.WriteLine("Soy una Lambda");
});
//Functions.Some("Lourdes", "Dominguez", showMesagge);
*/
#endregion

#region Func
Func<int> numberRandom = () => new Random().Next(0, 100);
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit);

///Console.WriteLine(numberRandom());
//Console.WriteLine(numberRandomLimit(10000));
#endregion


#region Predicate

Predicate<string> hasSpace = (word) => word.Contains(" ");
Console.WriteLine(hasSpace("Beer"));
Console.WriteLine(hasSpace("Be er"));
#endregion

#region Delegados
public delegate int Operacion(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2, string message3);

#endregion

public class Functions
{
    public static int Suma(int x, int y) => x + y;
    public static int Mul(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    //Funcion de horden superior
    public static void Some(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al Final");
    }
}