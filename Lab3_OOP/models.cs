public class University
{
    public List<Department> Department { get; set; }
}

public class Department
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Id { get; set; }
    public List<Course> Course { get; set; }
}

public class Course
{
    public string Name { get; set; }
    public List<Class> Class { get; set; }
}

public class Class
{
    public string Type { get; set; }
    public string Time { get; set; }
    public Leader Leader { get; set; }
    public Instructor Instructor { get; set; }
}

public class Leader
{
    public string Name { get; set; }
    public string Phone { get; set; }
}

public class Instructor
{
    public string Name { get; set; }
}