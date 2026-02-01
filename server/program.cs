Console.WriteLine("Здравствуйте!");
string? myName = "Заставная Наталия Владимировна";
string? group = "ИСП-231";
DateTime curDate = DateTime.Now;

while (true)
{
    Console.WriteLine("1 - Показать ФИО");
    Console.WriteLine("2 - Показать группу");
    Console.WriteLine("3 - Показать дату");
    Console.WriteLine("4 - Выход");
    Console.Write("Ваш выбор (введите цифру от 1 до 4): ");
    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine($"ФИО - {myName}");
            break;

        case "2":
            Console.WriteLine($"Группа - {group}");
            break;
        case "3":
            Console.WriteLine($"Текущая дата: {curDate}");
            break;
        case "4":
            Console.WriteLine("Вы вышли из программы!");
            return;
        default:
            Console.WriteLine("Ошибка, такого варианта нет");
            break;
    }
}
