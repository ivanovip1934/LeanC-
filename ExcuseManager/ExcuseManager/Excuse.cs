using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExcuseManager
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }


        public Excuse() {
            ExcusePath = "";
        }
        public Excuse(string _path){
            this.openFile(_path);
        }

       public Excuse(Random _random, string _pathDirectory) {
            string[] _fileName = Directory.GetFiles(_pathDirectory, "*.txt");
            openFile(_fileName[_random.Next(_fileName.Length)]);

        }

                              
        private void openFile(string _path)
        {
            this.ExcusePath = _path;
            using (StreamReader _reader = new StreamReader(ExcusePath)) {
                this.Description = _reader.ReadLine();
                this.Results = _reader.ReadLine();
                this.LastUsed = Convert.ToDateTime(_reader.ReadLine());
            }
        }

        public void Save(string _path) {
            using (StreamWriter _writer = new StreamWriter(_path)) {
                _writer.WriteLine(Description);
                _writer.WriteLine(Results);
                _writer.WriteLine(LastUsed); // метод WriteLine() вызывает метод ToString() автоматически!!!
            }

        }

    }
}

