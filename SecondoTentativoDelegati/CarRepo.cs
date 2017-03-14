using System.Collections.Generic;
using System.Linq;

namespace SecondoTentativoDelegati
{
    class CarRepo
    {

        public static List<Car> Cars { get; set; }
        public CarRepo ()
        {
            Cars = new List<Car>()
            {
                new Car() {Name = "Ciccio", Model = "A72"},
                new Car() {Name = "Schifo", Model = "AA01"},
                new Car() {Name = "Mobile", Model = "A72"},
                new Car() {Name = "Ciccio", Model = "AA03"},
                new Car() {Name = "Rocco", Model = "A01"}
            };
        }

        public IEnumerable<Car> FilterCarByName ( string name )
        {
            var cars = Cars.Where( car => car.Name == name );

            return cars;
        }

        public IEnumerable<Car> FilterCarByModel ( string model )
        {
            var cars = Cars.Where( car => car.Model == model );
            return cars;
        }

        public IEnumerable<Car> GetCarsDB ()
        {
            return Cars;
        }
    }
}
