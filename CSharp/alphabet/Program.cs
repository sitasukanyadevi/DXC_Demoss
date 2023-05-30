// See https://aka.ms/new-console-template for more information
char ch;
 Console.WriteLine("Enter any alphabet: ");
 ch = Convert.ToChar(Console.ReadLine());
  if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
  {
   Console.WriteLine("It is Vowel.");
  }
  else
  {
    Console.WriteLine("It is Consonant.");            
  }
 
