// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter 5 digit number:");
int n = Convert.ToInt16(Console.ReadLine());
int rem,sum = 0;
int temp = n;
while(temp!=0) 
{
    rem = temp%10;
    sum=sum+ rem;
    temp=temp/10;

}
Console.WriteLine("Sum of given digits : "+ sum );
