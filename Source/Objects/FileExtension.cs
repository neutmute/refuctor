using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refuctor.Objects
{
    public class FileExtension
    {
        public string Value { get; set; }


        public FileExtension()
        {
            
        }

        public FileExtension(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            var asExtension = obj as FileExtension;
            return asExtension != null && string.Compare(Value, asExtension.Value, true) == 0;
        }

        public override int GetHashCode()
        {
            return Value.ToLower().GetHashCode();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
