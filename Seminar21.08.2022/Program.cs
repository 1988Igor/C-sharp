
//The code verify if numbers 7 and 23 are divisible wiht another number from Random

bool Divisible7(int x)
{ 
bool result = true;
if ((x%7) == 0)
{
    result = true;
}
else
{
result=false;
}
return result;
 }
 bool Divisible23(int x)
 {
bool result = true;
if ((x%23) == 0)
{
    result  = true;
}
else
{
result = false;
}
return result;

 }
 Console.WriteLine("Enter a integer number: ");
 int x = new Random().Next(-100,101);
 Console.WriteLine(x);
 if (Divisible7(x))
 {
    if (Divisible23(x)) Console.WriteLine($"The number {x} is divisible with 7 and 23");
    else Console.WriteLine("The number is not divisible");
 }
 else Console.WriteLine("The number is not divisible");
 