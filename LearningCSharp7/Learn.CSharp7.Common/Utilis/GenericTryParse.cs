using System.Reflection;

namespace Learn.CSharp7.Common.Utilis
{

    public class GenericTryParse
    {
        public void TryParse<T>(string value, ref T destinationType)
        {
            var dataType = destinationType.GetType();
            var tryParseMethod = dataType.GetMember("TryParse");

            object[] parameters = new object[] { value, null };

            var output = ((MethodInfo)tryParseMethod[0]).Invoke(dataType, parameters);
            destinationType = ((bool)output ? (T)parameters[1] : destinationType);
        }
    }

}
