namespace NSub101
{
    /// <summary>
    /// Simple interface
    /// </summary>
    class Person : IPerson
    {
        public string GetFullName(string firstName, string lastName)
        {
            return ($"{firstName} {lastName}");
        }
    }
}
