using SecondTask;

Product[] product = new Product[6];
product[0] = new Commodity("Йогурт", 59, Convert.ToDateTime("02.04.2024"), 30);
product[1] = new Commodity("Молоко", 109, Convert.ToDateTime("12.03.2024"), 10);
product[2] = new Batch("Сырки", 39, 10, Convert.ToDateTime("08.04.2024"), 20);
product[3] = new Batch("Батончики", 99, 50, Convert.ToDateTime("01.01.2024"), 100);
product[4] = new Complect("Ложки", 39, "Столовые");
product[5] = new Complect("Ложки", 15, "Десертные");

DateTime now = DateTime.Now;

foreach (var prod in product)
{
    Console.WriteLine(prod.Info());
    Console.WriteLine(prod.IsCorrespondsToExpire(now) ? "Не просрочен" : "Просрочен");
    Console.WriteLine();
}
