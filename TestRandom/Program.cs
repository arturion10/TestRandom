using TestRandom;


// Определяем диапозон Чисел для рандома, и разряд на который нужно будет поделить
Number number= new Number();
Console.WriteLine("Выберите диапозон чисел:");
var minNumber = number.IsValidNumber("От Включительно: ");
var maxNumber = number.IsValidNumber("До Включительно: ");
while(maxNumber<minNumber)
{
    Console.WriteLine("Второе число должно быть больше или равно первому, введите второе число еще раз");
    maxNumber = number.IsValidNumber("До: ");
}
Console.WriteLine();
int discharge = number.IsValidDischarge();
Console.WriteLine();


//выбираем 3 рандоиных числа
Random rnd = new Random();
int[] values = new int[3];
for(int i = 0; i < values.Length; i++)
{
    values[i] = rnd.Next(minNumber, maxNumber + 1);
}
Console.WriteLine($"Ваши рандомные числа:");
foreach(int value in values)
{
    Console.WriteLine(value);
}
Console.WriteLine();

// Определяем среднее арифметическое
int SumValues = 0;
foreach(int value in values)
{
    SumValues += value;
}
Console.WriteLine($"Среднее арифметическое:\n{(decimal)SumValues/values.Length}");
Console.WriteLine();

// Определяем среднее геометрическое
long MultiplValues = 1;
foreach (int value in values)
{
    MultiplValues *= value;
}
Console.WriteLine($"Среднее геометрическое:\n{Math.Pow(MultiplValues, 1 / (double)values.Length)}");
Console.WriteLine();

// Деление на указанный разряд
int[] DischargeValues = new int[values.Length];
Console.WriteLine($"Результат чисел деленных на {discharge} разряд: ");
for (int i = 0; i < values.Length;i++)
{
    DischargeValues[i] = values[i] / (int)(Math.Pow(10, (double)discharge));
    Console.WriteLine(DischargeValues[i]);
}





