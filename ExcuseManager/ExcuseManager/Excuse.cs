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
        private string description;
        public string Description { get { return description; } }
        private string results;
        public string Results { get { return results; } }
        private DateTime lastUsed;
        public DateTime LastUsed { get { return lastUsed; } }
        private string excusePath;
        public string ExcusePath { get { return excusePath; } }


        public Excuse(string _description, string _results, DateTime _lastUsed) {
            this.description = _description;
            this.results = _results;
            this.lastUsed = _lastUsed;
        }

        public Excuse(string _path) {
            this.openFile(_path);
        }
                              
        private void openFile(string _path)
        {
            if (File.Exists(_path))
            {
                this.excusePath = _path;
                using (StreamReader _reader = new StreamReader(this.excusePath))
                {
                    this.description = _reader.ReadLine();
                    this.results = _reader.ReadLine();
                    this.lastUsed = Convert.ToDateTime(_reader.ReadLine());
                }
            }
        }

        public void Save(string _path) {
            if (Directory.Exists(_path)) {
                Random _random = new Random();
                string _fileName = "excuse" + _random.Next(1000, 9999).ToString();
                string _fullName = _path + "\\" + _fileName;
                using (StreamWriter _writer = new StreamWriter(_fullName)) {
                    _writer.WriteLine(this.description);
                    _writer.WriteLine(this.results);
                    _writer.WriteLine(Convert.ToString(this.lastUsed));
                }
            }

        }

    }
}

