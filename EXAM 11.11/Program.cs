using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_11._11
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            MyDict dict = new MyDict("Rus-Eng");
            dict.append("Трава", "Расслабляющая классная тема");
            dict.append("Трава", "Зеленая на земле штука");
            dict.append("Машина", "Крутой транспорт для хачей");
            foreach (string word in dict.search("машина"))
            {
                Console.WriteLine($"{word}");
            }
            foreach (string word in dict.search("ТРАВА"))
            {
                Console.WriteLine(($"{word}"));
            }
                dict.replace("машина", "автобус");
            Console.WriteLine(dict);





                /*

                int choice = 0; 
                Console.WriteLine("Добро пожаловать в программу <Словарь>");
                Console.WriteLine("Какое действие хотите сделать? : Добавить слово - 1; Удалить слово - 2");
                choice = int.Parse(Console.ReadLine());
                DictionaryDemo typesDictionary = new DictionaryDemo();
                var dictionaryList = new List<string>();
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите тип словаря");
                            typesDictionary.typeDictionary = Console.ReadLine();
                            Console.WriteLine("Введите слово");
                            typesDictionary.word = Console.ReadLine();
                            Console.WriteLine("Введите перевод слова");
                            typesDictionary.wordTranslation = Console.ReadLine();
                            dictionaryList.Add("Тип словаря:" + typesDictionary.typeDictionary);
                            dictionaryList.Add("Слово:" + typesDictionary.word);
                            dictionaryList.Add("Перевод:" + typesDictionary.wordTranslation);
                            break;
                        }
                        Console.WriteLine("Какое действие?");
                        choice = int.Parse(Console.ReadLine());
                    case 2:
                        {
                            string enterWord;
                            Console.WriteLine("Введите слово которое бы хотели удалить");
                            enterWord = Console.ReadLine();
                            if (enterWord == typesDictionary.word)
                            {
                                dictionaryList.Remove(typesDictionary.word);
                            }
                            else
                            {
                                Console.WriteLine("Данного слова не существует");
                            }
                            break;
                        }
                }
                foreach (var item in dictionaryList)
                {
                    Console.WriteLine(item);
                }
                */
            }

        }
    }
