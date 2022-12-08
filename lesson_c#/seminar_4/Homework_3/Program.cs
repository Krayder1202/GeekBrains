//Домашка 3


int[] array = new int[8];
Random myRandom = new Random();
 
Console.WriteLine("Вывод с помощью for");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);    
    Console.Write("{0} ", array[i]);
}