int a1= 56;
int b1= 75;
int c1= 37;
int a2= 87;
int b2= 54;
int c2= 65;
int a3= 23;
int b3= 57;
int c3= 82;

int max1= Max (a1,b1,c1);
int max2= Max (a2,b2,c2);
int max3= Max (a3,b3,c3);
int max= Max (max1,max2,max3);


int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}
Console.WriteLine(max1);
Console.WriteLine(max2);
Console.WriteLine(max3);
Console.WriteLine(max);
