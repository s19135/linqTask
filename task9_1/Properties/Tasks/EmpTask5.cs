namespace task9_1.Properties
{
    public class EmpTask5
    {
        public string FirstName { get; set; }
        public string EmployeeJob { get; set; }
        
        public override string ToString()
        {
            return FirstName + " (Job: " +  EmployeeJob + ")";
        }
    }
}