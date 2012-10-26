using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Refuctor
{
    public class Term
    {
        public string Target { get; set; }

        public string ReplaceWith { get; set; }


        public List<Term> GetPermutations()
        {
            var permutated = new List<Term>();
            permutated.Add(Clone());

            var miniCase = Clone();
            miniCase.Target = ToFirstLower(miniCase.Target);
            miniCase.ReplaceWith = ToFirstLower(miniCase.ReplaceWith);

            permutated.Add(miniCase);

            return permutated;
        }

        private string ToFirstLower(string value)
        {
            return Char.ToLowerInvariant(value[0]) + value.Substring(1);
        }

        public Term Clone()
        {
            var newTerm = new Term();
            newTerm.Target = Target;
            newTerm.ReplaceWith = ReplaceWith;
            return newTerm;
        }

        public override string ToString()
        {
            return string.Format("{0}=>{1}", Target, ReplaceWith);
        }
    }
}
