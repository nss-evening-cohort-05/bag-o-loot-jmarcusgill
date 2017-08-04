using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
  public class ToyRegister
  {
    private List<Toy> _toys = new List<Toy>();

    public Toy Add(string toy, Child child)
    {
      // Create new toy instance
      Toy newToy = new Toy()
      {
        name = toy,
        child = child
      };

      // Add to private collection
      _toys.Add(newToy);

      return newToy;
    }

    public void RevokeToy(Toy toy)
    {
      // Toy newToy = new Toy()
      // {
      // name = toy,
      // child = kid
      // };

      // _toys.Remove(newToy);

      // return newToy;
      _toys.Remove(toy);


    }

    public List<Toy> GetToysForChild(Child kid)
    {
      
      //return _toys.Where(toy => toy.child == kid).ToList();

      var kidsToys = from toy in _toys
                    where toy.child == kid
                    select toy;

        return kidsToys.ToList();
    }
  }
}
