/* Задача 43: Напишите программу, которая найдёт точку пересечения двух 
прямых, заданных уравнениями y1 = k1 * x1 + b1, y2 = k2 * x2 + b2; значения 
b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Решение.
Точка пересечения 2-х прямых тогда, когда x1=x2, y1=y2 => Решаем уравнение:
преобразуем к виду y1=y2 => k1 * x1 + b1 = k2 * x2 + b2; 
k1 * x1 - k2 * x2 = b2 - b1. При х1=х2 уравнение принимает вид => 
x1*(k1-k2)=b2-b1; x1=(b2-b1)/(k1-k2). 
1. Инициализация переменных;
2. Ввод значений с проверкой данных;
3. Находим х1 из уравнения. x1=x2 в точке пересечения;
4. Находим y1 из уравнения, подставляем x1, находим у1;
5. Выводим координаты пересечения x1,y1;
*/ 

//Проверка на валидность ввода
int CheckData(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result)) return result;
        else Console.Write("Введите правильное значение - число: ");
    }
}

//Проверка на пересечение-непересечение линий (равенство k1, k2 когда линии 
//не пересекаются, k1-k2=0, деление на 0) 
bool CheckIntersection(int k1, int k2)
{
    bool  isTrue=true;
    if (k1==k2) 
    {
    isTrue=false;
    return isTrue;
    }
    return isTrue;
}

//Определение координат пересечения отрезков
(double,double) ResultCoord(int b1, int b2, int k1, int k2)
{
    double resultx=(double)(b2-b1)/(k1-k2);
    double resulty=(double)(k1*resultx+b1);
    //Console.WriteLine(Convert.ToString(Math.Round(resultx,4)), Convert.ToString(Math.Round(resulty,4)));
    return (resultx,resulty);
}

int b1 = CheckData("Введите число b1: ");
int b2 = CheckData("Введите число b2: ");
int k1 = CheckData("Введите число k1: ");
int k2 = CheckData("Введите число k2: ");
if(CheckIntersection(k1,k2))
{
(double resx,double resy) = ResultCoord (b1,b2,k1,k2);
Console.WriteLine($"Координаты точки пересечения ({Convert.ToString(Math.Round(resx,4))},{resy})");
}
else Console.Write("Линии не пересекаются в плоскости");