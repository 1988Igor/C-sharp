// This code help us to find in which area is the point into the plane or flat
Console.WriteLine("Enter the x: ");
int x = new Random().Next(-5,5);
Console.WriteLine(x);
Console.WriteLine("Enter the y: ");
int y = new Random().Next(-5,5);
Console.WriteLine(y);
if(x>0 && y>0)
{
    Console.WriteLine("The point ist located in first surface");
}

else if (x>0 && y>0)
{
    Console.WriteLine("The point ist located in second surface");
}
else if (x<0 && y<0)
{
    Console.WriteLine("The point ist located in third surface");
}
else if (x>0 && y<0)
{
    Console.WriteLine("The point ist located in thourth surface");
}
else
{
Console.WriteLine("Enter another value: ");

}
