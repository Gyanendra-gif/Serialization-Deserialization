using System;

namespace Serialization_Deserialization
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization binary = new BinarySerialization();
            binary.Serialization();
            binary.Deserialization();
            JSONSerialization serialization = new JSONSerialization();
            serialization.JsonSerialize();
            serialization.JsonDeserialize();
        }
    }
}
