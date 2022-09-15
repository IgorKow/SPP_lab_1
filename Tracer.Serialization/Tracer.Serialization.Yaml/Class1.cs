using Tracer.Serialization.Abstraction.Classes;
using Tracer.Serialization.Abstractions;
using System.Text;
using YamlDotNet.Serialization;

namespace Tracer.Serializaton.Yaml
{
    public class YamlTraceResultsSerializer : ITraceResultsSerializer
    {
        public void Serialize(List<ThreadInfo> threads, Stream to)
        {
            using StreamWriter writer = new(to);
            TextWriter yamlWriter = writer;
            Serializer ser = new();
            ser.Serialize(yamlWriter, threads);
            yamlWriter.Flush();
        }
    }
}

