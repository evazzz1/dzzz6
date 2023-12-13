// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”

string text = "Hello my world";
char [] letters = text.ToCharArray();
string result = GetText(text);
Console.WriteLine(result);

string GetText (string str)
{
    string[] words = str.Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}