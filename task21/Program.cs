/*Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,5, 0); B (1,-1,9) -> 11.53*/

int GetNumber(string message)
{
    bool isCorrect=false;
    int result=0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(),out result))
        {
            isCorrect=true;
        }
        else
        {
            Console.WriteLine("Ввели не число.Введите число");
        }


    }
    return result;
}
double GetDistans(int x1,int x2,int y1, int y2,int z1,int z2)
{
    return Math.Sqrt (Math.Pow (x1-x2,2)+ Math.Pow (y1-y2,2)+Math.Pow(z1-z2,2));

}
int x1=GetNumber("Введите координату x для первой точки");
int y1=GetNumber("Введите координату x для первой точки");
int z1=GetNumber("Введите координату x для первой точки");
int x2=GetNumber("Введите координату x для второй точки");
int y2=GetNumber("Введите координату x для второй точки");
int z2=GetNumber("Введите координату x для второй точки");

double distans=GetDistans(x1,x2,y1,y2,z1,z2);

Console.WriteLine($"Расстояние между точками составляет{distans}");