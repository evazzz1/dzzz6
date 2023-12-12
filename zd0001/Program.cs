// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// a b c => “abcdef”
// d e f 

Random rand = new Random();
char [,] characters = new char [rand.Next(1,5),rand.Next(1,5)];
string text = string.Empty;
Console.WriteLine(GetArray(characters,text));


string GetArray (char [,] chars, string str)
{
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            chars[i,j] = Convert.ToChar(rand.Next(97,123)); //решила использовать таблицу ASCII, в дальнейших задачах тоже буду применять ее
            Console.Write(characters[i,j] + " ");
            str += chars[i,j];
        }
        Console.WriteLine();
    }
    return str;
}
