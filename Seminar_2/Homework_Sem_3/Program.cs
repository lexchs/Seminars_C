void SearchWeekend(int num)
{
    switch(num)
    {
        case 1:
            Console.WriteLine("It's not a holiday my dude");
            break;
        case 2:
            Console.WriteLine("It's not a holiday my dude");
            break;
        case 3:
            Console.WriteLine("It's not a holiday my dude");
            break;
        case 4:
            Console.WriteLine("It's not a holiday my dude");
            break;
        case 5:
            Console.WriteLine("It's not a holiday my dude");
            break;
        case 6:
            Console.WriteLine("It's a day off my dude!");
            break;
        case 7:
            Console.WriteLine("It's a day off my dude!");
            break;
        default:
            Console.WriteLine("There is no such day of the week my dude");
            break;
    }
}

Console.Write("Write the day of the week my dude: ");
int day = int.Parse(Console.ReadLine());
SearchWeekend(day);