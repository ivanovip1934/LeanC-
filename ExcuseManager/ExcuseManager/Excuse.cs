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

        public void OpenFile(string _path) {
            excusePath = _path;
            if (StreamReader _reader = new StreamReader(excusePath)){

            }
        }

        public void Save(string _path) {

        }

    }
}
