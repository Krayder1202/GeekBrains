//             0   1   2   3   4   5   6   7   8   9           
int [] array = {16, 47, 64, 35, 36, 28, 55, 35, 49, 58};

int n = array.Length;
int find = 35;

int index = 0;

while (index<n)
{
    if (array[index]==find)
    {
    Console.WriteLine(index);
    break;
    }
    index++;
}