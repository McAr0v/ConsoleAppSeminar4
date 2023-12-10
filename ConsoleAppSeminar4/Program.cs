/* 
 * 
 * Дан массив и число. Найдите три числа в массиве сумма которых равна искомому числу. 
 * Подсказка: если взять первое число в массиве, 
 * можно ли найти в оставшейся его части два числа равных по сумме первому.
 * 
 */

int[] arr = new int[] { -2, 10, 2, 31, 4, 5, 16, 7, 8, 9};
int target = 15;

for (int i = 0; i < arr.Length; i++)
{

    int otherNumber = target - arr[i];

    for (int j = 0; j < arr.Length; j++)
    {

        for (int k = 0; k<arr.Length; k++)
        {
            if (j==k ) continue;
            if (arr[j] + arr[k] == otherNumber)
            {
                Console.WriteLine($"Числоа = {arr[i]}, {arr[j]}, {arr[k]}");
                return;
            }
        }
    }
}

Console.WriteLine("Числа не найдены");


