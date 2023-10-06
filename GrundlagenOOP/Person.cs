namespace GrundlagenOOP;

internal class Person
{
  private string firstname;

  private string Firstname
  {
    get => firstname;
    set => firstname = value;
  }
  private string lastname;
  public string Lastname { get => lastname; set => lastname = value; }

  public Person(string firstname, string lastname) 
  {
    this.Firstname = firstname;
    this.Lastname = lastname;
  }

  // public string Fullname()
  // {
  //    return Firstname + " " + Lastname;
  // }
  public string Fullname() => Firstname + " " + Lastname;

  public void Platzhalter() 
  {
    var Bark = () => Console.WriteLine("Woooof");
    if (firstname == "tobi") Console.WriteLine(firstname);
    else Console.WriteLine("Error");
  
  }
 }
