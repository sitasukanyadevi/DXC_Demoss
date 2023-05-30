// See https://aka.ms/new-console-template for more informatio
int n1,n2;
Console.WriteLine("Enter n1:");
n1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter n2:");
n2=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter your Choice");
char c=Convert.ToChar(Console.ReadLine());
switch (c) {

    case '+' :
{

       Console.WriteLine("n1+n2:" + ( n1+n2));
       break;
}
    case '-' :
{

       Console.WriteLine("n1-n2:" + (n1-n2));
       break;
}
    case '*' :
{

       Console.WriteLine("n1*n2:" + (n1*n2));
       break;
}
case '/' :
{

       Console.WriteLine("n1/n2 :" + (n1/n2));
       break;
}
case '%' :
{

       Console.WriteLine("n1%n2 :" + (n1%n2));
       break;
}
default:
{
    Console.WriteLine("Wrong Choice, Enter Again");
    break;
}
}