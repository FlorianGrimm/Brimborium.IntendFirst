using Brimborium.IntendFirst.FileSystem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brimborium.IntendFirst.Md;
internal class Class1 {
    public void Parse(FileContent fileContent) {
        var markdownDocument = Markdig.Parsers.MarkdownParser.Parse(fileContent.Content, pipeline: null, context: null);
        
        foreach (var block in markdownDocument) { 
            if (block is null) { continue; }
        }
    }
}
