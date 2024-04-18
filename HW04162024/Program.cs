using FirstTask;

Figure[] arrayFigure = new Figure[5];
arrayFigure[0] = new Triangle(3, 4, 5);
arrayFigure[1] = new Circle(5);
arrayFigure[2] = new Recbangle(3, 5);
arrayFigure[3] = new Triangle(6, 4, 3);
arrayFigure[4] = new Recbangle(10, 5);
double sum = 0;

for (int i = 0; i < arrayFigure.Length; i++)
{
    sum += arrayFigure[i].Perimetr();
}

Console.WriteLine($"Общая сумма периметров всех фигур {sum}");