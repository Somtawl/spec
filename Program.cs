Console.WriteLine("Введите элементы массива используя знак , в качестве разделителя");
string[] getElements = Console.ReadLine().Split(",");
string[] resultArray =  new string[getElements.Length];
for (int i = 0; i < resultArray.Length; i++)
{
    int numberOfSimbols = getElements[i].Length;
    numberOfSimbols = numberOfSimbols - 3;
    resultArray[i] = getElements[i].Substring(0, getElements[i].Length - numberOfSimbols);
}
for (int j = 0; j < resultArray.Length; j++)
{
    Console.Write(resultArray[j] + " ");
}