using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace XPNet.CLR.CodeGen
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.Delete("../XPNet.CLR/Data/GeneratedDataRefs", true);
            Console.WriteLine($"Reading Datarefs from: {args[0]}");
            IEnumerable<string> dataRefs = Enumerable.Empty<string>();

            if (args.Length > 0 && File.Exists(args[0]))
            {
                dataRefs = File.ReadLines(args[0]);
                Console.WriteLine("Successfully read DataRefs");
            }
            var dataRefClasses = dataRefs
                .Where(d => d.StartsWith("sim") && !d.Contains("???"))
                .Select(d => d.PathNamesToUpper())
                .Select(d => d.Split('\t'))
                .Select(d => new DataRef
                {
                    ParentPath = d[0],
                    Name = d[0].LastElementOfPath(),
                    Type = d[1],
                    IsWriteable = d[2] == "y",
                    Units = d.Skip(3).FirstOrDefault(),
                    Description = d.FirstOrDefault(f => f.Contains(' '))
                })
                .GroupBy(d =>
                    String.Join("/", d.ParentPath.Split('/').SkipLast(1))
                    ,d => d,
                    (path, members) => new DictionaryTree<DataRef>(path, members));

            var classTree = new DictionaryTree<DataRef>("Sim");
            foreach (var d in dataRefClasses)
            {
                var path = d.Name.Split('/');
                var curNode = classTree;
                for (int i = 1; i < path.Length; i++)
                {
                    if (!curNode.Children.ContainsKey(path[i]))
                    {
                        curNode.Children[path[i]] = new DictionaryTree<DataRef>(
                            String.Join('/', path.Take(i + 1)),
                            i == path.Length - 1 ? d.Members : null);
                    }
                    curNode = curNode.Children[path[i]];
                }
            }

            BuildClassDefs(classTree);
            Console.WriteLine("Successfully generated DataRefs");

            var code = "";
            File.WriteAllText("../XPNet.CLR/Data/FluentDataRefs2.cs", code);
        }

        
        public static void BuildClassDefs(DictionaryTree<DataRef> node)
        {
            foreach (var child in node.Children.Values)
            {
                BuildClassDefs(child);
            }
            //if (node.Name == "sim") return;

            node.ClassDef = template
                .Replace("{item}", node.Name.Replace('/', '_'))
                .Replace("{childInits}", string.Join("", node.Children.Values.Select(c => $"\n{initsIndent}{c.Name.LastElementOfPath()} = new {c.Name.Replace('/', '_')}Datarefs(data);")))
                .Replace("{childProps}", string.Join("", node.Children.Values.Select(c => $"\n{propsIndent}public {c.Name.Replace('/', '_')}Datarefs {c.Name.LastElementOfPath()} {{ get; }}")))
                .Replace("{members}", string.Join("", node.Members.Select(m => 
                    {
                        string result = string.Empty;
                        if(m.Units == null) return result;
                        if(m.Units.Equals("string", StringComparison.OrdinalIgnoreCase))
                            result = $"{m.Description.CreateSummaryComment(propsIndent)}\n{propsIndent}public IXPDataRef<string> {m.Name} => m_data.GetString(\"{m.ParentPath.ToLower()}\");";
                        
                        if((m.Units.Equals("bool") || m.Units.Equals("bool")) && m.Type.Contains("int["))
                            result = $"{m.Description.CreateSummaryComment(propsIndent)}\n{propsIndent}public IXPDataRef<bool[]> {m.Name} => m_data.GetBoolArray(\"{m.ParentPath.ToLower()}\");";

                        if((m.Units.Equals("bool") || m.Units.Equals("bool")) && m.Type.Equals("int"))
                            result = $"{m.Description.CreateSummaryComment(propsIndent)}\n{propsIndent}public IXPDataRef<bool> {m.Name} => m_data.GetBool(\"{m.ParentPath.ToLower()}\");";
                        
                        return result;
                    })
                ));
            if(node.Name == "View"){
                Console.WriteLine(node.Members.Count());
            }

            var filePath = $"../XPNet.CLR/Data/GeneratedDataRefs/{node.Name}DataRefs.cs";
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, node.ClassDef);
        }

        const string initsIndent = "            ";
        const string propsIndent = "        ";
        const string template = @"using System;
using System.Collections.Generic;
using System.Text;

namespace XPNet.Data
{
    public class {item}Datarefs
    {
        private readonly IXPlaneData m_data;

        internal {item}Datarefs(IXPlaneData data)
        {
            m_data = data;{childInits}
        }{childProps}{members}
    }
}";
    }

    public class DictionaryTree<T>
    {
        public DictionaryTree(string name, IEnumerable<T> dataMembers = null)
        {
            Name = name;
            Members = dataMembers ?? Enumerable.Empty<T>();
            Children = new Dictionary<string, DictionaryTree<T>>();
        }
        public string Name;
        public IEnumerable<T> Members;
        public Dictionary<string, DictionaryTree<T>> Children;
        public string ClassDef { get; set; }
    }
    public class DataRef
    {
        public string ParentPath { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsWriteable { get; set; }
        public string Units { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Parent: {this.ParentPath}\nName: {this.Name}\nType: {this.Type}\nWriteable: {this.IsWriteable}\nDescription: {this.Description}";
        }
    }

    public static class Extensions
        {
            public static string PathNamesToUpper(this string path)
            {
                var chars = path.ToCharArray();
                chars[0] = char.ToUpper(chars[0]);
                for (int i = 1; i < path.Length; i++)
                {
                    if (chars[i] == '/' && chars.Length >= i)
                        chars[i + 1] = char.ToUpper(chars[i + 1]);
                }
                return new String(chars);
                ;
            }

            public static string LastElementOfPath(this string path){
                return path.Substring(path.LastIndexOf('/') + 1);
            }

            public static string CreateSummaryComment(this string description, string indent)
            {
                return $"\n\n{indent}/// <summary>\n{indent}///  {description}\n{indent}/// </summary>";
            }
        }
}
