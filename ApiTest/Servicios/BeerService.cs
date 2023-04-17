using ApiTest.Models;

namespace ApiTest.Servicios
{
    public class BeerService : IBeerService
    {
        private List<Beer> beers = new List<Beer>()
        {
            new Beer() {Id= 1, Name = "Estrella Damm", Marca= "Damm"},
            new Beer() {Id= 2, Name = "Mahou tostada", Marca= "Mahou"}
        };

        public IEnumerable<Beer> Get() => beers;

        public Beer? Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
