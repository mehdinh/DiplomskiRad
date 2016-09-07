using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public interface ITextExtractor
    {
        string Extract(string filename);
    }
}
