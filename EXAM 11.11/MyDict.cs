﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}