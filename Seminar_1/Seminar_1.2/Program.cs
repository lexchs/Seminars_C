Console.Write("День недели ");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    case 3:
        Console.Write("Среда");
        break;
    case 4:
        Console.Write("Четверг");
        break;
    case 5:
        Console.Write("Пятница");
        break;
    case 6:
        Console.Write("Субботу");
        break;
    case 7:
        Console.Write("Воскресенье");
        break;
    default:
        Console.Write("Нет такого дня недели, давай по новой");
        break;
}
