﻿
/*
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
*/
string Method4(int count, string text)
{
    string result = String.Empty; // пустая строка
    for (int i = 0;i<count; i++)
    {
        result=result + text;
    }
    return result;
}
string res = Method4(10, "Text");
Console.WriteLine(res);