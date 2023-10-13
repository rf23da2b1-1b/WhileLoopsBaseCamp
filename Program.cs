
// Case 1
Console.WriteLine("Start of Case 1");
int c1 = 1;
while (c1 < 20)
{
    Console.WriteLine(c1); // Uncomment to see result
    c1 = c1 + 2;
}
Console.WriteLine("End of Case 1");


// Case 2
Console.WriteLine("Start of Case 2");
int c2 = 1;
while (c2 < 20)
{
    Console.WriteLine(c2); // Uncomment to see result
    c2 = c2 * 2;
}
Console.WriteLine("End of Case 2");


// Case 3
Console.WriteLine("Start of Case 3");
int c3 = 15;
while ((c3 < 20) && (c3 > 10))
{
    Console.WriteLine(c3);  // Uncomment to see result
    c3++;
}
Console.WriteLine("End of Case 3");


// Case 4
Console.WriteLine("Start of Case 4");
int c4 = 10;
while (c4 >= 0)
{
    Console.WriteLine(c4);  // Uncomment to see result
    c4--;
}
Console.WriteLine("End of Case 4");


// Insert code for the below four cases

// Case 5
// Print out the numbers 3,5,7,9
Console.WriteLine("Start of Case 5");
int c5 = 3;
while (c5 < 10)
{
    Console.WriteLine(c5);  // Uncomment to see result
    c5 = c5 + 2;
}
Console.WriteLine("End of Case 5");


// Case 6
// Print out the numbers 0,1,3,7,15,31
Console.WriteLine("Start of Case 6");
int c6 = 0;
while (c6 < 32)
{
    Console.WriteLine(c6);  // Uncomment to see result
    c6 = c6*2 + 1;
}
Console.WriteLine("End of Case 6");


// Case 7
// Print out the numbers 100,50,25,12,6,3,1
Console.WriteLine("Start of Case 7");
int c7 = 100;
while (c7 > 0)
{
    Console.WriteLine(c7);  // Uncomment to see result
    c7 = c7 / 2;
}
Console.WriteLine("End of Case 7");


// Case 8 (DIFFICULT)
// Print out the numbers 10,9,12,7,14,5,16,3,18,1
Console.WriteLine("Start of Case 8");
int c8 = 10;
while (c8 > 0 && c8 < 20)
{
    Console.WriteLine(c8);
    c8 = 19 + ((c8 % 2) * 2) - c8;
}
Console.WriteLine("End of Case 8");


Console.WriteLine("Start of Case 8B");
int c8a = 10;
int c8b = 9;
int i = 0;
while (i < 10)
{
    Console.WriteLine(c8a + i );
    Console.WriteLine(c8b - i );
    i = i + 2;
}
Console.WriteLine("End of Case 8B");

Console.WriteLine("Start of Case 8søren");
int c8i = 10;
int c8j = 9;
while (c8j > 0 && c8i < 20)
{
    Console.WriteLine(c8i);
    Console.WriteLine(c8j);
    c8i = c8i + 2;
    c8j = c8j - 2;
}
Console.WriteLine("End of Case 8søren");