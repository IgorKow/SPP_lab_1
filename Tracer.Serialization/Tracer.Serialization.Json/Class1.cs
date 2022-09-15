using Tracer.Serialization.Abstraction.Classes;
using Tracer.Serialization.Abstractions;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Tracer.Serialization.Json
{
    public class JsonTraceResultsSerializer : ITraceResultsSerializer
    {
        public void Serialize(List<ThreadInfo> threads, Stream to)
        {
            using StreamWriter writer = new(to);
            using JsonTextWriter jsonWriter = new(writer);
            JsonSerializer ser = new();
            ser.Serialize(jsonWriter, threads);
            jsonWriter.Flush();
        }
    }
}