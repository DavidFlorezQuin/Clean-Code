namespace Entities
{
    public class Beer
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Style { get; set; }
        public decimal Alcohol { get; set; }

        //Propiedades que sea muy raro que cambien
        public bool IsStrongBeer() => Alcohol > 7.5m;
    }
}
