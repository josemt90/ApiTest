using ApiTest.Models;

namespace ApiTest.Servicios
{
    public interface IBeerService
    {
        public IEnumerable<Beer> Get();
        public Beer? Get(int id);
    }
}
