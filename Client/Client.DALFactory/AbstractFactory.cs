using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Client.DALFactory
{
    public partial class AbstractFactory
    {
        private static readonly string AssemblyPath = "Client.DAL";
        private static readonly string NameSpace = "Client.DAL";

        private static object CreateInstance(string className)
        {
            var assembly = Assembly.Load(AssemblyPath);
            return assembly.CreateInstance(className);
        }
    }
}
