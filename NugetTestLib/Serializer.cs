using Newtonsoft.Json;

namespace NugetTestLib
{
    public class Serializer
    {
        public static string toJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T fromJson<T>(string obj)
        {
            return JsonConvert.DeserializeObject<T>(obj);
        }
    }
}
