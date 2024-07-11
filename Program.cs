//Написать программу для поиска слов в файле. Слово вводит пользователь



Console.WriteLine("Введите искомое слово:");
string FindName = Console.ReadLine();

FindInTextFile(FindName);

void FindInTextFile(string FindName)
{
    FindName = FindName.ToLower();
    string filePath = @"text.txt";
    int count = 0;
    bool flag = false;
    if (File.Exists(filePath))
    {
        string[] text = File.ReadAllLines(filePath);
        char[] symb = { ' ', ',', '.', ';', ':', '-', '!', '?' };
        foreach (string line in text)
        {
            string[] words = line.Split(symb);


            foreach (string s in words)
            {
                if (s.ToLower().Equals(FindName))
                {
                    flag = true;
                    count++;
                }
            }
        }
        if (!flag)
        {
            Console.WriteLine($"слова {FindName} нет в файле");
            return;
        }
        Console.WriteLine($"слова {FindName} в файле {count}") ;
    }
    else
    {
        Console.WriteLine($"файл {filePath} не найден");
    }


}