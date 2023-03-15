
//1. CALCULAR ÁREA DEL CIRCULO.
static double areacirculo(double radio)
{
    double area = Math.PI * radio * radio;
    return area;
}

Console.WriteLine("1. CALCULAR ÁREA DEL CIRCULO.");
double radio;
Console.WriteLine("Ingrese el radio del circulo: ");
radio = double.Parse(Console.ReadLine());
double area = areacirculo(radio);
Console.WriteLine($"El área del circulo es de " + area);

//2. CALCULAR EL PERIMETRO DE UN RECTÁNGULO.
static double perimetrorectangulo(double ancho, double altura)
{
    double perimetro = 2 * (ancho + altura);
    return perimetro;
}

Console.WriteLine("");
Console.WriteLine("2. CALCULAR EL PERIMETRO DE UN RECTÁNGULO.");
double ancho;
double altura;
Console.WriteLine("Ingrese el ancho del rectángulo: ");
ancho = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del rectángulo: ");
altura = double.Parse(Console.ReadLine());
double perimetro = perimetrorectangulo(ancho, altura);
Console.WriteLine("El perimetro del rectángulo es de: " + perimetro);


//3. PROMEDIO DE NÚMEROS
static double promedionumeros(int num1, int num2, int num3, int num4, int num5)
{
   double promedio = (num1 + num2 + num3 + num4 + num5) / 5;
    return promedio;
}

int num1, num2, num3, num4, num5;
Console.WriteLine("");
Console.WriteLine("3. PROMEDIO DE NÚMEROS.");
Console.WriteLine("ingrese 5 números: ");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());
num5 = int.Parse(Console.ReadLine());
double promedio = promedionumeros(num1, num2, num3, num4, num5);
Console.WriteLine("El promedio de los 5 números es de " + promedio);

//4. DETERMINAR SI EL NÚMERO ES PAR O IMPAR.
static string paroimpar(int numero)
{

    if (numero % 2 == 0)
    {
        return "El número ingresado es par";
    }
    else
    {
        return "El número ingresado es impar";
    }
}
int numero;
Console.WriteLine("");
Console.WriteLine("4. DETERMINAR SI EL NÚMERO ES PAR O IMPAR.");
Console.WriteLine("Ingrese un número: ");
numero = int.Parse(Console.ReadLine());
string resultado = paroimpar(numero);
Console.WriteLine("" + resultado);

//5. CADENA DE MINÚSCULAS A MAYÚSCULAS.
static string conmayusculas(string cadena)
{
    string mayusculas = cadena.ToUpper();
    return mayusculas;
}
string cadena = "universidad mariano gálvez";
Console.WriteLine("");
Console.WriteLine("5. CADENA DE MINÚSCULAS A MAYÚSCULAS.");
Console.WriteLine("La cadena principal es: " + cadena);
string mayusculas = conmayusculas(cadena);
Console.WriteLine("A continuación la cadena ya convertida: " + mayusculas);

//6. CALCULAR LA DISTANCIA DE DOS PUNTOS.
static double calcdistancia(double x1, double y1, double x2, double y2)
{
    double dx = x2 - x1;
    double dy = y2 - y1;
    double distancia = Math.Sqrt(dx * dx + dy * dy);
    return distancia;
}
double x1, y1, x2, y2;
Console.WriteLine("");
Console.WriteLine("6. CALCULAR LA DISTANCIA DE DOS PUNTOS.");
Console.WriteLine("Ingrese los datos del primer punto (primer dato sera x, segundo sera y): ");
x1 = double.Parse(Console.ReadLine());
y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese los datos del segundo punto (primer dato sera x, segundo sera y): ");
x2 = double.Parse(Console.ReadLine());
y2 = double.Parse(Console.ReadLine());
double distancia = calcdistancia(x1, y1, x2, y2);
Console.WriteLine("La distancia entre los dos puntos ingresados es de: " +distancia);

//7. SUMA DE LOS NÚMEROS NATURALES.
static int sumadenaturales(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++)
    {
        suma += i;
    }
    return suma;
}
int n;
Console.WriteLine("");
Console.WriteLine("7. SUMA DE LOS NÚMEROS NATURALES.");
Console.WriteLine("Ingrese cuantos de los primeros números naturales quiere que se sumen: ");
n = int.Parse(Console.ReadLine());
int suma = sumadenaturales(n);
Console.WriteLine("La suma de los números naturales ingresados es de: "+suma);

//8. FACTORIAL DE UN NÚMERO.
static int calcfactorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}
int num;
Console.WriteLine("");
Console.WriteLine("8. FACTORIAL DE UN NÚMERO.");
Console.WriteLine("Ingrese el número para calcular su factorial: ");
num = int.Parse(Console.ReadLine());
int factorial = calcfactorial(num);
Console.WriteLine("El factorial del número ingresado es de: " + factorial);
