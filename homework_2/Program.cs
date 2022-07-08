void enterNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index<length)
    {
        sumMassive[index] = new Random().Next(-100,100);
        index++;
    }
}
void printNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index<length)
    {
        if (index == 0)
        {
            Console.Write($"[{sumMassive[index]},");
            index++;
        }
        else if(index > 0 && index < length-1)
        {
            Console.Write($"{sumMassive[index]},");
            index++;
        }
        else
        {
            Console.Write($"{sumMassive[index]}]->");
            index++;   
        }
    }
}
int oddSumNumbers(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    int tamp = 0;
    while(index<length)
    {
        tamp += sumMassive[index];
        index+=2;
    }
    return tamp;
}
int length = new Random().Next(4,10);
int[] numbers = new int[length];
enterNumber(numbers);
printNumber(numbers);
int tamp = oddSumNumbers(numbers);
Console.Write(tamp);
