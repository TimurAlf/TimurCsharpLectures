// Виды функции (методов)
// Вид 1 - метод, который ничего не принимает и не возвращает (void)

void Method1()
{
    Console.WriteLine("Text");
}
//Method1(); 

// Вид 2 - метод, который принимает аргументы, но ничего не возвращает (void)

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method2(msg:"Text",count: 4);
//Method2(count: 4, msg:"Text");
//Method2("Text", 4);

// Вид 3 - метод, который ничего не принимает, но что-то возвращает 

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//Console.WriteLine(year);

// Вид 4 - метод, который принимает аргументы и возвращает 

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка
    while (i<count)
    {
        result=result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "Text");
Console.WriteLine(res);