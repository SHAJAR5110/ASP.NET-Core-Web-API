using CarInventoryAPI.Models;  // 👈 Add this line

public class CarRepository
{
    private static List<Car> _cars = new List<Car>();

    public List<Car> GetAll() => _cars;
    public Car GetById(int id) => _cars.FirstOrDefault(c => c.Id == id);
    public void Add(Car car) => _cars.Add(car);
    public void Update(Car updatedCar)
    {
        var index = _cars.FindIndex(c => c.Id == updatedCar.Id);
        if (index >= 0) _cars[index] = updatedCar;
    }
    public void Delete(int id) => _cars.RemoveAll(c => c.Id == id);
}
