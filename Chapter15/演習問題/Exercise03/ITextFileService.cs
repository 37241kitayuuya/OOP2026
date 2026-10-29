using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    public interface ITextFileService {
        void Intialize(string fname);
        void Execute(string line);
        void Terminate();
    }
}
