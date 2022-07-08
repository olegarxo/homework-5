void enterNumber(int[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index<length)
    {
        sumMassive[index] = new Random().Next(100,1000);
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
int evenNumbers(int[] sumMassive)
{
    int tamp = 0;
    int index = 0;
    int length = sumMassive.Length;
    while(index < length)
    {
        if(sumMassive[index] % 2 == 0)
        {
            tamp++;
            index++;
        }
        else 
        {
            index++;
        }
    }
    return tamp;
}
int length = new Random().Next(4,10);
int[] number = new int[length];
enterNumber(number);
int tamp = evenNumbers(number);
printNumber(number);
Console.Write(tamp);


