void enterNumber(double[] sumMassive)
{
    int index = 0;
    int length = sumMassive.Length;
    while(index<length)
    {
        sumMassive[index] = new Random().Next(-100,100);
        index++;
    }
}
void printNumber(double[] sumMassive)
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
void sortMassive(double[] number)
{
    int length = number.Length;
    double tamp = 0;
    for(int i = length - 1;i > 0; i--)
    {
        for(int j =0; j < length - 1;j++)
        {
            if(number[j] > number[j+1])
            {
                tamp = number[j+1];
                number[j+1] = number[j];
                number[j] = tamp;

            }
        }
    }
}
int length = new Random().Next(4,10);
double[] number = new double[length];
enterNumber(number);
printNumber(number);
sortMassive(number);
Console.Write(number[length-1] - number[0]);
