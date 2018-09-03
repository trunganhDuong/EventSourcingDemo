using System;
using System.Collections.Generic;
using System.Text;

namespace EventSourcing.Models.Data
{
    public class SqlParameters
    {
        public Dictionary<string,dynamic> Parameters { get; private set; }

        public void AddParameter(string name, dynamic value)
        {
            this.Parameters.Add(name,value);
        }
    }
}
