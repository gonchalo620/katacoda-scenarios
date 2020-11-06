namespace library
{
  public class Buzon
  {
    public string Saludar() 
    {
        return "Hola usuarios de EPM";
    }

    public string Saludar(string usuario)
    {
      return "Hola " + usuario + ", le saluda EPM";
    }
  }
}