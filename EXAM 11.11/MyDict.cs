using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EXAM_11._11
{
    class MyDict
    {
        public string type { get; set; }
        private Dictionary<string, List<string>> data;

        public MyDict()
        {
            this.type = "Unknown";
            this.data = new Dictionary<string, List<string>>();
        }
        public MyDict(string type)
        {
            this.type = type;
            this.data = new Dictionary<string, List<string>>();
        }
        /// <summary>
        /// Добавить новое слово в словарь
        /// </summary>
        /// <param name="key">Слово</param>
        /// <param name="word">Значение слова</param>
        public void append(string key, string word)
        {
            key = key.ToLower(); // SfdSfsD --> sfdsfsd
            if (data.ContainsKey(key)){
                List<string> values = data[key];
                values.Add(word);
                data[key] = values;
            } else
            {
                List<string> values = new List<string> { word };
                data.Add(key, values);
            }
            
        }

        /// <summary>
        /// Поиск значений слова
        /// </summary>
        /// <param name="key">Ключ</param>
        /// <returns></returns>
        public List<string> search(string key)
        {
            key = key.ToLower();
            List<string> res = new List<string>();
            if (data.ContainsKey(key))
            {
                res = new List<string>(data[key]);
            }
            return res;
        }

        public void replace_key(string oldKey, string newKey)
        {
            newKey = newKey.ToLower();
            oldKey = oldKey.ToLower();
            if (data.ContainsKey(oldKey))
            {
                List<string> newValues = new List<string>(data[oldKey]);
                data.Add(newKey, newValues);
                data.Remove(oldKey);

            }
           
        }

        public void replace_value(string key, string value, int index)
        {
            key = key.ToLower();
            if (data.ContainsKey(key))
            {
                if (data[key].Count() > index && index >= 0)
                {
                    data[key][index] = value;
                }
            }
        }

        public override string ToString()
        {
            string text = $"Тип словаря:{this.type}";
            foreach (string key in data.Keys)
            {
                string newKey = key;
                newKey = newKey.Remove(0, 1);
                newKey = key.ToUpper()[0] + newKey;
                text += $"\n{newKey}:";
                int index = 1;
                foreach(string value in data[key])
                {
                    text += $" {index++}.{value};";
                }
            }
            return text;
        }
        public void savetype()
        {
            string text = $"Тип словаря:{this.type}";
            string save = @"E:\text.txt";
            using (FileStream fstream = new FileStream($"{save}", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Тип словаря записан в файл");
            }
        }
        public void savekey(string values)
        {
            foreach (string key in data.Keys)
            {
                values += String.Join(", ", key) + Environment.NewLine;
            }
          
            string save = @"E:\text.txt";
            MyDict dictsave = new MyDict(save);
            using (FileStream fstream = new FileStream($"{save}", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(values);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Слово записано в файл");
            }
        }
        public void savevalues(string input)
        {
            foreach (var row in data.Values)
            {
                input += String.Join(", ", row) + Environment.NewLine;
            }
            string save = @"E:\text.txt";
            MyDict dictsave = new MyDict(save);
            using (FileStream fstream = new FileStream($"{save}", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(input);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Значение записано в файл");
            }
        }
        public void readingfile()
        {
            string save = @"E:\rus-eng.txt";
            using (FileStream fstream = File.OpenRead($"{save}"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Тип вашего словаря: {textFromFile}");
            }
        }
    }
}
