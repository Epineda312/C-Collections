namespace Treehouse
{
  class Student : System.IComparable<Student>
  {
    public string Name { get; set; }
    public int GradeLevel { get; set; }  
    
    public int CompareTo(Student that)
    {
      int result = this.Name.CompareTo(that.Name);
      
      if(result == 0)
      {      
        result = this.GradeLevel.CompareTo(that.GradeLevel);
      }
      return result;
    }
  } 
}