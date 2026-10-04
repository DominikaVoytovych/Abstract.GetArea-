using Abstract;

Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("---Абстрактні класи. Обчислення площі. GetArea()---");

//GetArea() - абстрактний метод для обчислення площі в ООП

Shape[] shape = new Shape[]
{
    new Circle(5), // створюємо кола з радіусом 5
    new Rectangle(4, 6), // створюємо прямокутника з шириною 4 та висотою 6
    new Triangle(3, 4) // створюємо  трикутника з довжиною основи 3 та висотою 4
};

foreach(var s in shape)
{
    Console.WriteLine($"Площа {s.GetType().Name}: {s.GetArea()}");
    //Get Type().Name - отримуємо назву класу об'єкта 
    //і після цього виводимо площу за допомогою GetArea()
}
