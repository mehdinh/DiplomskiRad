﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlocks
{
    public interface ITextExtractorFactory
    {
        ITextExtractor Resolve(string name);
    }
}