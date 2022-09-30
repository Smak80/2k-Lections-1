using System.Reflection.Metadata;
using System.Xml;
using L2k_2022_09_12;

Complex z1 = new Complex();
Complex z2 = new Complex(3, -5);
Complex z3 = new Complex(z2);
Complex z4 = z2;
z2.Im = -1;
Console.WriteLine(z1.Abs);
Console.WriteLine(z2.Abs);
Console.WriteLine(z3.Abs);
Console.WriteLine(z4.Abs);
Console.WriteLine(z1);
Console.WriteLine(z2);
Console.WriteLine(z3);
Console.WriteLine(z4);
Complex z5 = z2.Plus(z3);
Console.WriteLine(z5); 
Complex z6 = z4 + z2;
Console.WriteLine(z6);
Console.WriteLine(Complex.Count);
Console.WriteLine(-z6);
z6 += z4;
Console.WriteLine(z6);

int? i1 = null;
if (i1 != null)
{
    int i11 = (int)i1;
    int i2 = i11 + 1;
}

if (i1 is { } i12)
{
    int i2 = i12 + 1;
}

var i3 = 1 + i1 ?? 0;
Complex? zz = new Complex(3, 5);
Console.WriteLine(zz?.Re.ToString() ?? "NULL");
int xx = default;
Console.WriteLine(xx);

/*int[] mas = {3, 5, 7};
int[][] m2 = new int[10][];
for (int i = 0; i < 10; i++)
{
    m2[i] = new int[i + 1];
}

m2[0][1] = 333;

int[,] m3 = new int[10, 20];
m3[0, 1] = 333;
*/
Days dd = Days.Monday;
Console.WriteLine(dd);
Days dd2 = Days.Sunday | Days.Saturday;
Console.WriteLine(dd2);

Days dd3 = Days.Sunday | Days.Monday;
Console.WriteLine(dd3);
[Flags]
enum Days
{
    Monday    = 0b_00000001,
    Tuesday   = 0b_00000010,
    Wednesday = 0b_00000100,
    Thursday  = 0b_00001000,
    Friday    = 0b_00010000,
    Saturday  = 0b_00100000,
    Sunday    = 0b_01000000,
    WeekEnd   = Saturday | Sunday
}