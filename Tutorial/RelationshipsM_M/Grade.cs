using System;

namespace RelationshipsM_M
{
public class Grade
{
    public int GradeID { get; set; }
    public string GradeName { get; set; }
    
    public ICollection<Student> Students { get; set; }
}
}