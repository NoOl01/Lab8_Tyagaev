//Lab 8 вариант 23 Средний уровень 
try
{
    Console.WriteLine("Введите кол-во звонков");
    int n = int.Parse(Console.ReadLine());
    Support[] calls = new Support[n];
    DateTime today = DateTime.Today;
    for (int i = 0; i < n; i++)
    {
        calls[i] = new Support();
        Console.WriteLine("Введите год звонка: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите месяц звонка: ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите день звонка: ");
        int day = int.Parse(Console.ReadLine());
        calls[i].DateCall = new DateTime(year, month, day);

        Console.WriteLine("Введите адрес абонента: ");
        calls[i].Address = Console.ReadLine();
        Console.WriteLine("Введите характер неисправности: ");
        calls[i].Fault = Console.ReadLine();
        Console.WriteLine("Введите состояние заявки: ");
        calls[i].Condition = Console.ReadLine();
    }

    bool hasUnresolvedCalls = false;
    for (int i = 0; i < n; i++)
    {
        TimeSpan difference = today - calls[i].DateCall;
        if (difference.TotalDays >= 0 && difference.TotalDays < 3 && calls[i].Condition != "выполнено")
        {
            if (!hasUnresolvedCalls)
            {
                Console.WriteLine("Невыполненные завявки за последние три дня:");
                hasUnresolvedCalls = true;
            }
            Console.WriteLine("Дата звонка : " + calls[i].DateCall);
            Console.WriteLine("Время звонка : " + calls[i].TimeCall);
            Console.WriteLine("Адрес абонента : " + calls[i].Address);
            Console.WriteLine("Характер неисправности : " + calls[i].Fault);
            Console.WriteLine("Состояние заявки : " + calls[i].Condition);
            Console.WriteLine("________________________");
        }
    }
    if (!hasUnresolvedCalls)
    {
        Console.WriteLine("Невыполненных заявок за последние три дня нет.");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
struct Support
{
    public DateTime DateCall;
    public TimeOnly TimeCall;
    public string Address;
    public string Fault;
    public string Condition;
}
