using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileProcessorDI {
    internal class TextFileprocessor {
        private ITextFileService _service;

        public TextFileprocessor(ITextFileService service) {
            _service = service; 
        }
        public void Run(String fileName) {
            _service.Intialize(fileName);
            var lines = File.ReadLines(fileName);
            foreach(var line in lines) {
                _service.Execute(line);
            }
            _service.Terminate();
        }
    }
   
}

