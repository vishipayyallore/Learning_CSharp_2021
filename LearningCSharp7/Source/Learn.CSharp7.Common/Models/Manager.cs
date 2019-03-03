using System;
using System.Collections.Generic;
using System.Text;

namespace Learn.CSharp7.Common.Models
{
    public class Manager
    {

        public Manager()
        {
            Repotees = new List<string>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<string> Repotees { get; set; }

        public void Deconstruct(out string id, out string name)
        {
            id = Id;
            name = Name;
        }

    }

}
