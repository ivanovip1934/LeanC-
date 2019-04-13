using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace ExcuseManager
{
    [Serializable]
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

        public Excuse(string _pathDirectory, bool _boolRandom) {
            if (_boolRandom) {
                Random _random = new Random();
                if (Directory.Exists(_pathDirectory)) {
                    string[] _files = Directory.GetFiles(_pathDirectory, "*.dat");
                    string _fullName = _files[_random.Next(0, _files.Length)];
                    this.openFile(_fullName);
                }
            }
        }

                              
        private void openFile(string _path)
        {
            if (File.Exists(_path))
            {
                this.excusePath = _path;
                Excuse _tmpexcuse;

                using (FileStream _reader = File.OpenRead(_path))
                {
                    BinaryFormatter _bf = new BinaryFormatter();
                    _tmpexcuse = (Excuse)_bf.Deserialize(_reader);
                }
                this.description = _tmpexcuse.Description;
                this.results = _tmpexcuse.Results;
                this.lastUsed = _tmpexcuse.lastUsed;
                this.excusePath = _tmpexcuse.ExcusePath;

            }
        }

        public void Save(string _path) {
            if (Directory.Exists(_path)) {
                Random _random = new Random();
                string _fileName = "excuse" + _random.Next(1000, 9999).ToString();
                string _fullName = _path + "\\" + _fileName +".dat";

                using (FileStream _output = File.Create(_fullName)) {
                    BinaryFormatter _bf = new BinaryFormatter();
                    _bf.Serialize(_output, this);
                }
            }

        }

    }
}

