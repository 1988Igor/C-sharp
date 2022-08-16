Console.WriteLine("Enter your name: ");
string username  = Console.ReadLine();
// ToLower() ne permite ca toate simbolurile din rind sa le treaca in registrul de mai jos//
if(username.ToLower() == "romica")  // conditia este ca numele trebuie sal indicam cu litere mici
{
    Console.WriteLine ("Hello my Friend, Romica ");
}

else
{
    Console.WriteLine("Hello, " + username);

}