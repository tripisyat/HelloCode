// 4 основных вида функции (методов)

// 1 ВИД - группа методов, которые ничего не принимают в качестве аргументов и ничего не возвращают. void метод

void Method1()
{
    Console.WriteLine("Автор: ........");
}

Method1(); // вызов данного метода



// 2 ВИД - группа методов, которые принимают данные в качестве аргументов, но ничего не возвращают, тоже void метод

// пример 1
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Текст сообщения");


// пример 2

void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
Method2(msg: "Текст", count: 4); //выведет слово ТЕКСТ 4 раза


// 3 ВИД - группа методов, которая ничего не принимают, но что то возвращают (например, генерят какие то рандомные данные)

// пример
int Method3()
{
    return DateTime.Now.Year; // метод вернет сегодняшний год
}
int year = Method3(); //вызываем наш метод и записываем в переменну результат
Console.WriteLine(year);


// 4 ВИД - группа методов, которая и принимает аргументы и что то возвращает

//пример
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; //записываем в переменную пустую строку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);