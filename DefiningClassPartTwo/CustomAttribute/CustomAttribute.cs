using System;

namespace CustomAttribute
{
    [AttributeUsage(AttributeTargets.Struct |  AttributeTargets.Class | AttributeTargets.Interface 
        | AttributeTargets.Enum | AttributeTargets.Method, 
          AllowMultiple = true)]
    public class VersionAttribute : System.Attribute
    {
        private string version;
        private int major;
        private int minor;

        public string Version { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Version = major.ToString() + '.' + minor.ToString();
        }
     }

    [Version(9,12)]
    class TestVersionAttribute
    {
        static void Main()
        {
            Type type = typeof(TestVersionAttribute);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("This class is {0} version. ",
                    versionAttribute.Version);
            }
        
        }

    }

}
