using Shapes.Shapes;

namespace Shapes
{
    public class GetSquare
    {
        public void Initialize()
        {
            Console.WriteLine("Сколько параметров вам доступно? Варианты: 1 или 3");
            string? paramQuantityString = Console.ReadLine();
            int paramQuantityInt;
            int.TryParse(paramQuantityString, out paramQuantityInt);

            if (paramQuantityInt == 1)
            {
                GetSquareCircle();
            }
            else if (paramQuantityInt == 3)
            {
                GetSquareTriangle();
            }
            else
            {
                Console.WriteLine("Для такого количества параметров, опция - \"узнать площадь\", недоступна.");
            }
        }
        private void GetSquareCircle()
        {
            Console.Write("Введите параметр: ");
            string? parameter1 = Console.ReadLine();
            double.TryParse(parameter1, out double paramInt1);
            if (paramInt1 <= 0)
            {
                Console.WriteLine("Ошибка, значение должно быть больше 0.");
                GetSquareCircle();
                return;
            }
            Shape circle = new Circle(paramInt1);
            Console.WriteLine($"Фигура: {circle.Name}, Площадь: {circle.GetSquare()}");
        }
        private void GetSquareTriangle()
        {
            Console.Write("Введите первый параметр: ");
            string? parameter1 = Console.ReadLine();
            double.TryParse(parameter1, out double paramInt1);

            Console.Write("Введите первый параметр: ");
            string? parameter2 = Console.ReadLine();
            double.TryParse(parameter2, out double paramInt2);

            Console.Write("Введите первый параметр: ");
            string? parameter3 = Console.ReadLine();
            double.TryParse(parameter3, out double paramInt3);

            if (paramInt1 <= 0 || paramInt2 <= 0 || paramInt3 <= 0)
            {
                Console.WriteLine("Ошибка, значение должно быть больше 0.");
                GetSquareTriangle();
                return;
            }

            if (paramInt1 + paramInt2 <= paramInt3 || paramInt2 + paramInt3 <= paramInt1 || paramInt3 + paramInt1 <= paramInt2)
            {
                Console.WriteLine("Ошибка, Вы ввели некорректные данные.");
                GetSquareTriangle();
                return;
            }

            Shape triangle = new Triangle(paramInt1, paramInt2, paramInt3);
            Console.WriteLine($"Фигура: {triangle.Name}, Площадь: {triangle.GetSquare()}");
        }
    }
}
