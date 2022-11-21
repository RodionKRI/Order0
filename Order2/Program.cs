int Max(int arg1, int arg2, int agr3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(agr3 > result) result = agr3;
    return result;
}
//
int[] array = {11,211,31,41,15,61,17,18,19};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max);