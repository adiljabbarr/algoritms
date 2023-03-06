int[] numbers = { 100, 47, 45, 15, 12, 2, 8, 15, 23, 32, 99 };
for(int i=0;i<numbers.Length;i++)
{
    int min =i;
    for(int j =i+1; j < numbers.Length; j++) 
    {
        if (numbers[min] > numbers[j])
        {
            min = j;
        } 
    }
    int temp = numbers[min];
    numbers[min] = numbers[i];
    numbers[i] = temp;

}
Console.WriteLine(numbers);