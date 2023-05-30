int[] arr=new int[]{7,4,5,6,8,2,3,1};
int Max=arr[0];
for(int i=0;i<arr.Length;i++){
    if(arr[i]>Max){
        Max=arr[i];
    }
}
Console.WriteLine($"Largest number of given array is {Max}");