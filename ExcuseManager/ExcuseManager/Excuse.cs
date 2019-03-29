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
        private string  description;
        public string Description { get { return description; } }
        private string results;
        public string Results { get { return results; } }
        private DateTime lastUsed;
        public DateTime LastUsed { get { return lastUsed; } }
        private string excusePath;
        public string ExcusePath { get { return excusePath; } }


        public Excuse(string _excusePath){
            OpenFile(_excusePath);
                }






        public void OpenFile(string _path)
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

        }

    }
}
