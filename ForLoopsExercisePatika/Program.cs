

//10 kez yazdırması için 0dan başlayıp 9 a kadar saydırdım ve birer birer arttırdım.
for (int i = 0; i < 10; i++)
{
    Console.Write("Kendime inanıyorum, ben bu yazılım işini hallederim!\n");
}
Console.WriteLine("\n");



Console.WriteLine("1'den 20'ye kadar olan sayılar:");
//1 ile başlaması gerekdiği için i = 1 ve 20 ye gelmesi için 21 den küçük  <= 20 de olabilirdi.
for (int i1 = 1; i1 < 21;i1++)
{
    Console.Write(i1 + ", ");
}
Console.WriteLine("\n\n");//1 20 arası saydıktan sonra alt satıra geçsin diye."



Console.WriteLine("1'den 20'ye kadar olan çift sayılar:");
// 1 den 20 ye kadar saydırdım. Eğer 2 ye bölünüyorsa yazdırdım.
for (int i2 = 1;(i2 < 20);i2++)
{
    if (i2 % 2 == 0)
    {
        Console.Write(i2 + ", ");
    }
}
Console.WriteLine("\n\n");


//cw yi loop un dışına yazdım çünkü her adımı yazdırmamıza gerek yok.
int sum = 0;
for (int i3 = 50;( i3 <= 150);i3++)
{
    sum += i3;
}
Console.WriteLine("1den 150 ye kadar olan sayıların toplamı: " + sum);
Console.WriteLine("\n");

// Her sayı için te veya çiftliğini kontrol edip farklı değişkenlerde sakladım. Loop un dışında yazdırdım.
int sumEven = 0;
int sumOdd = 0;
for (int  i4 = 1;  i4 <=120;  i4++)
{
    if (i4 % 2 == 0)
    {
        sumEven += i4;
    }
    else
    {
        sumOdd += i4;
    }

}
Console.WriteLine("1 den 120 ye kadar olan çift sayıların toplamı: " + sumEven);
Console.WriteLine("1 den 120 ye kadar olan tek sayıların toplamı: " + sumOdd);