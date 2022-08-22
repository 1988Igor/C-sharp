Console.WriteLine("Enter a natural three-digit number:");
int number  = int.Parse(Console.ReadLine());

if (number <100 || number > 999)
{
    
    Console.WriteLine("The entered value does not match the condition! Repeat the entry:");
   number  = int.Parse(Console.ReadLine());
} 
int digit1  = number%10;  // we find out the number 3
int digit2 = number/10%10; // we find out the number 2
int digit3  = number/100; // we find out the number 1
int result = digit1*100+digit2*10 +digit3;
Console.WriteLine($"The inversed number ist {result}");