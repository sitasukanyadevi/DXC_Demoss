// See https://aka.ms/new-console-template for more informatio
Console.WriteLine("Enter Student ID:");
int sid=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Student name:");
string sn=Console.ReadLine();
Console.WriteLine("Enter Student age:");
int sage=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks 1:");
int marks1=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks 2:");
int marks2=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter marks 3:");
int marks3=Convert.ToInt16(Console.ReadLine());
double sum;
double average, per;
sum=marks1 + marks2 + marks3;
average= sum/3;
per=(sum/300)*100 ;
Console.WriteLine("Your Total score is :"+ sum);
Console.WriteLine("Your Total Average is :"+ average);
Console.WriteLine("Your Total per is :"+ per +"%");
if(per>50)
{
  Console.WriteLine("Your Result for exam is Pass");  
  if(per>=90 && per<=100)
  {
    Console.WriteLine("Your Grade is A");
  }
  else if(per>=80 && per<=89)
  {
    Console.WriteLine("Your Grade is B");
  }
  else if(per>=60 && per<=79)
  {
    Console.WriteLine("Your Grade is C");
  }
  else if(per>=50 && per<59)
  {
    Console.WriteLine("Your Grade is D");
  }

}
else{
   Console.WriteLine("Your Grade is E");
   Console.WriteLine("Your Result for exam is Fail");

}