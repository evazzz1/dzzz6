//Задача 3: Задайте произвольную строку. Выясните,
//является ли она палиндромом.

//“aBcD1ef!-” => Нет
//“шалаш” => Да
//“55655” => Да

Console.WriteLine("Введите любое слово");
string text = IsEmptyText(Console.ReadLine());
char [] characters = text.ToCharArray();
Console.WriteLine("is polindrome? " + IsPollindrome(characters));

bool IsPollindrome (char [] chars)
{
    int count = 0;
    for (int i = 0; i < chars.Length/2; i++)
    {
        if(chars[i] == chars[chars.Length - 1 - i])
        {
            count++;
        }
    }
    if (count == chars.Length/2) return true;
    else return false;
}

string IsEmptyText(string str) //проверка на пустой ввод
{
    if(str == string.Empty)
    {
        Console.WriteLine("Вы не ввели слово, попробуйте снова");
        return IsEmptyText(Console.ReadLine());
    }
    else return str;
}
