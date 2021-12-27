// цикл for

string Method4(int count, string text)
{
    string result = string.Empty; //записываем в переменную пустую строку
    for(int i = 0; i < count; i++) // в скобках сначала инициализация инкремента, потом инициализация счетчика, потом увеличение инкремента
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);