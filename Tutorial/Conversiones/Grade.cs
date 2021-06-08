using System;

namespace Conversiones
{
public class Grade
{
    public int GradeID { get; set; }
    public string GradeName { get; set; }
    
    public ICollection<Student> Students { get; set; }
}
}