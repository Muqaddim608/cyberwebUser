using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blazored.TextEditor;
using Microsoft.AspNetCore.Components;

namespace ClassLibraryModel
{
    public class display
    {
        public MarkupString html { get; set; }
        public string? audio { get; set; }
    }
}
