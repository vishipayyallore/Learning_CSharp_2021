using Learn.CSharp7.Common.Models;

namespace Learn.CSharp7.Common.Utilis
{
    public static class ExtensionMethods
    {

        public static (int value, bool parsed) ParseToInteger(this string input)
        {
            var returnValue = (value: 0, parsed: false);

            returnValue.parsed = int.TryParse(input, out returnValue.value);

            return returnValue;
        }

        public static void Deconstruct(this Manager manager, out string id, out string name)
        {
            id = manager.Id;
            name = manager.Name;
        }

        public static void Deconstruct(this Employee employee, out string id, out string name)
        {
            id = employee.Id;
            name = employee.Name;
        }

        public static void Deconstruct(this Student student, out string fullName, out int age, out float salary)
        {
            fullName = $"{student.First} {student.Last}";
            age = student.Age;
            salary = student.Salary;
        }

        public static void Deconstruct(this Subject subject, out string name, out float marks)
        {
            name = subject.Name;
            marks = subject.Marks;
        }

    }

}
