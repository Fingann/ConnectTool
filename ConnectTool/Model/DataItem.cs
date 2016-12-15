using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectTool.Model
{
    public class DataItem
    {
        public string Title { get; set; }
        public DataItem(string text)
        {
            Title = text;
        }
    }
}
