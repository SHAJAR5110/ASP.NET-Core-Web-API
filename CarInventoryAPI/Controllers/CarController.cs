using Microsoft.AspNetCore.Mvc;
using CarInventoryAPI.Models; 
[ApiController]  
[Route("api/[controller]")] 
public class CarController : ControllerBase
{
    private readonly CarRepository _repository = new CarRepository();

    [HttpGet]
    public ActionResult<List<Car>> GetAll() => _repository.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Car> GetById(int id) => _repository.GetById(id);

    [HttpPost]
    public IActionResult Add(Car car)
    {
        _repository.Add(car);
        return CreatedAtAction(nameof(GetById), new { id = car.Id }, car);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Car car)
    {
        _repository.Update(car);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _repository.Delete(id);
        return NoContent();
    }
}
