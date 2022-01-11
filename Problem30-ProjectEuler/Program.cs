
List<double> selectedValues = new List<double>();

double topLimit = 200000;

for(double i = 2; i <= topLimit; i++)
{
    if(i == GetSumDigitsPow(i))
        selectedValues.Add(i);
}

double totalSum = 0;
foreach(double value in selectedValues)
{
    totalSum = totalSum + value;
}

Console.WriteLine("The sum of all the numbers that can be written as the sum of fifth powers of their digits is: " + totalSum);

double GetSumDigitsPow(double value)
{
    string strValue = value.ToString();
    double sum = 0;

    foreach(char c in strValue)
    {
        sum = sum + Math.Pow(Convert.ToDouble(c.ToString()), 5);
    }
    return sum;
}