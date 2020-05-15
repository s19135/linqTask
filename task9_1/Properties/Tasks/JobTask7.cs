namespace task9_1.Properties
{
    public class JobTask7
    {
        public string EmployeeJob { get; set; }
        public int EmployeeNumber { get; set; }
        
        public override string ToString()
        {
            return EmployeeJob + " (Count: " +  EmployeeNumber + ")";
        }
    }
}