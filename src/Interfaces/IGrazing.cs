namespace Trestlebridge.Interfaces
{
    public interface IGrazing
    {
        double GrassPerDay { get; set; }
public string Type {get; set;}

        void Graze();
    }
}