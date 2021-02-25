using System;
using System.Reflection;
using static System.Console;
using System.Linq; // to use OrderByDescending
using System.Runtime.CompilerServices; // to use CompilerGenerateAttribute
using Packt.Shared; // CoderAttribute

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();

            // WriteLine($" Full name: {assembly.FullName}");
            // WriteLine($" Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();

            // WriteLine($" Attributes:");
            foreach(Attribute a in attributes)
            {
                // WriteLine($" {a.GetType()}");
            }

            var version = assembly.GetCustomAttribute
                            <AssemblyInformationalVersionAttribute>();

            // WriteLine($" Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute
                            <AssemblyCompanyAttribute>();

            // WriteLine($" Company: {company.Company}");

            /*
                Legacy .NET Framework way of setting attributes of projects
                [assembly: AssemblyCompany("Packt Publishing")]
                [assembly: AssemblyInformationalVersion("1.3.0")]
            */

            WriteLine();
            WriteLine($"* Types:");
            Type[] types = assembly.GetTypes();
            

            foreach(Type type in types) 
            {
                var existsCompilerGeneratedAttribute = type.GetCustomAttribute<CompilerGeneratedAttribute>();
                // WriteLine(existsCompilerGeneratedAttribute == null);

                if(existsCompilerGeneratedAttribute == null)
                {
                    WriteLine("***TYPE***: " + type.GetType());
                    WriteLine($"Type: {type.FullName}");
                    MemberInfo[] members = type.GetMembers();

                    foreach(MemberInfo member in members)
                    {
                        WriteLine("{0}: {1} ({2})",
                            arg0: member.MemberType,
                            arg1: member.Name,
                            arg2: member.DeclaringType.Name);
                        
                        var coders = member.GetCustomAttributes<CoderAttribute>()
                                        .OrderByDescending(c => c.LastModified);

                        foreach(CoderAttribute coder in coders)
                        {
                            WriteLine("-> Modified by {0} on {1}",
                                coder.Coder, coder.LastModified.ToShortDateString());
                        }
                    }
                }
                
            }
        }

        [Coder("Mark Price", "22 August 2019")]
        [Coder("Johnni Rasmussen", "13 September 2019")]
        public static void DoStuff()
        {
            // CODE
        }
    }
}
