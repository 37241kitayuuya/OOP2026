using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public class Take20Service : ITextFileService {
        private int _count = 0;
        public void Intialize(string fname) {
            _count++;
        }

        public int Execute(string line) {
          
                Console.WriteLine(line);
            
            _count++;
            return _count;
        }

        public void Terminate() {
            Console.WriteLine("{0} 行", _count);
        }

        void ITextFileService.Execute(string line) {
            
        }
    }
}
