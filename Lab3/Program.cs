Console.WriteLine("    A    ");
Console.WriteLine("   BCD   ");
Console.WriteLine("  EFGHI  ");
Console.WriteLine(" JKLMNOP ");
Console.WriteLine("QRSTUVWXYZ");

Console.Write("    A    \n   BCD   \n  EFGHI  \n JKLMNOP \nQRSTUVWXYZ");

Console.Write("\nPlease Enter first Integer ");
string StringInt1 = Console.ReadLine();
Console.Write("Please Enter Second Integer ");
string StringInt2 = Console.ReadLine();

int FirstInt = int.Parse(StringInt1);
int SecondInt = int.Parse(StringInt2);

Console.Write($"\nSum is............{FirstInt + SecondInt}\n");
Console.Write($"Difference is.....{FirstInt - SecondInt}\n");
Console.Write($"Product is........{FirstInt * SecondInt}\n");
Console.Write($"Quotient is.......{FirstInt / SecondInt}\n");
