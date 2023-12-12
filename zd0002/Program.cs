// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// “aBcD1ef!-” => “abcd1ef!-” 

Console.WriteLine("Введите любое предлоежние латиницей. Для выхода нажмите q");
string text = IsEmptyText(Console.ReadLine());
ToLowerString(text);


void ToLowerString (string str)
{
    if(str != "q")
        {
        char [] chars = str.ToCharArray();
        for (int i = 0; i < str.Length; i++)
            {
                if(chars[i] >= 'A' && chars[i] <= 'Z')
                {
                    chars[i] = Convert.ToChar((int)chars[i] + 32); //из вверхнего регистра в нижний
                }
                Console.Write(chars[i]);
            }
          Console.WriteLine();
          str = IsEmptyText(Console.ReadLine());
          ToLowerString (str);
        }
    else 
        {
          Console.WriteLine("Вы вышли");
        }
   
}

string IsEmptyText(string str) //проверка на пустой ввод
{
    if(str == string.Empty)
    {
        Console.WriteLine("Вы не ввели предлоежние, попробуйте снова");
        return IsEmptyText(Console.ReadLine());
    }
    else return str;
}
