//code palindrome for numbers - first variant

//Console.WriteLine("Enter a number with five elements : ");
//int x = int.Parse(Console.ReadLine());
//int a1 = (x / 10000);
//int a2 = (x / 1000) - a1*10 ;
//int a5 = (x % 10);
//int a4 = (( x %100)-a5)/10;

//if (a1 == a5 && a2 == a4)
//{
  //  Console.WriteLine($"The number {x} ist palindrome");
//}
//else
//{

//Console.WriteLine($"The number {x} ist not palindrome");
//}

//code palindrome for numbers - second  variant

//Console.WriteLine("Enter a number with four elements : ");
           // string num = Console.ReadLine();
            //string rev = string.Concat(num.Reverse());
           // Console.WriteLine(num == rev ? "Palindrome" : "not Palindrome");


//Code palindrome for words

string s = "Аnns";
            Console.Write("{0}", (s.ToLower() == (new string(s.ToLower().Reverse().ToArray()))) ? "Palindrome" : "Not Palindrome");
            Console.ReadKey();


