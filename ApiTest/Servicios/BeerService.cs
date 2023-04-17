using ApiTest.Models;

namespace ApiTest.Servicios
{
    public class BeerService : IBeerService
    {
        private List<Beer> _beers = new List<Beer>()
        {
            new Beer() {Id= 1, Name = "Estrella Damm", Marca= "Damm"},
            new Beer() {Id= 2, Name = "Mahou tostada", Marca= "Mahou"}
        };

        public IEnumerable<Beer> Get() => _beers;

        public Beer? Get(int id)=> _beers.FirstOrDefault(x => x.Id == id);
        
    }
}
