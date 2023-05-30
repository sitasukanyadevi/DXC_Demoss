// See https://aka.ms/new-console-template for more information
int[] arr=new int[10];
Console.WriteLine("Enter 10 elements in an array");
for(int i=0;i<arr.Length;i++){
    arr[i]=Convert.ToInt16(Console.ReadLine());
}
double sum=0;
double average;
for(int j=0;j<arr.Length;j++){
    sum+=arr[j];
}
average=sum/arr.Length;
Console.WriteLine("Average of given elements:" + average);
