using System.Collections.Generic;

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

    }

}
