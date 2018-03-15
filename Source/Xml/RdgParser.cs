using Kraken.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Refuctor.Xml
{
    class RdgParser
    {
        public RdgParser()
        {

        }

        public void Go()
        {
            var rdcMan = ParseXml();
            var servers = new List<Server>();
            foreach(var group in rdcMan.file.group)
            {
                if (group.server != null)
                {
                    foreach (var rdpServer in group.server)
                    {
                        var outputServer = new Server();
                        outputServer.Name = rdpServer.displayName;
                        outputServer.Group = group.properties.name;
                        servers.Add(outputServer);
                    }
                }

                if (group.group != null)
                {
                    foreach (var nestedGroup in group.group)
                    {
                        var outputServer = new Server();
                        foreach (var rdpServerNested in nestedGroup.server)
                        {
                            var outputServerNested = new Server();
                            outputServerNested.Name = rdpServerNested.displayName;
                            outputServerNested.Group = group.properties.name;
                            outputServerNested.Tag = nestedGroup.properties.name;
                            servers.Add(outputServerNested);
                        }
                    }
                }
            }

            Console.WriteLine(servers.Count);

            var sb = new StringBuilder();
            const string AhkRight = "Send {Right}";
            const string AhkDown = "Send {Down}";
            const string AhkLeft = "Send {Left}";
            const string AhkBackspace = "Send {Backspace}";
            const string AhkWait = "Sleep, 600";
            const string NewLine = "\r\n";
            const string AhkConfTask = "Send [\r\nSleep, 250\r\nSend ]" + NewLine + AhkWait + NewLine + AhkBackspace;
            
            foreach (var server in servers)
            {
                
                sb.AppendLine($"Send {server.Name}");
                sb.AppendLine(AhkWait);
                sb.AppendLine(AhkRight);

                for (int i = 0; i < 4; i++)
                {
                    sb.AppendLine(AhkConfTask);
                    sb.AppendLine(AhkWait);
                    if (i < 3)
                    {
                        sb.AppendLine(AhkRight);
                    }
                }

                sb.AppendLine(AhkDown);
                for (int i = 0; i < 4; i++)
                {
                    sb.AppendLine(AhkLeft);
                }
            }

            Console.WriteLine(sb.ToString());
            File.WriteAllText(@"D:\downloads\go.ahk", sb.ToString());

            var serverCsv = servers.ToCsv("\r\n", s => s.Name);
            File.WriteAllText(@"D:\downloads\serverCsv.txt", serverCsv);

        }
        

        public RDCMan ParseXml()
        {
            var serverFile = @"D:\Data\Documents\Desktop\servers.rdg";

            var serializer = new XmlSerializer(typeof(RDCMan));
            RDCMan rdcMan;
            using (var stream = File.Open(serverFile, FileMode.Open))
            {
                rdcMan = (RDCMan)serializer.Deserialize(stream);
            }
            return rdcMan;
        }
    }
}
