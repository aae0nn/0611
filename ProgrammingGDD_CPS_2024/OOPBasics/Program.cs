var car = new Car("Opel", "Insignia", 60, 10);

car.Tank(10);
car.Tank(70);

Console.WriteLine($"{car.Brand} {car.Model}, fuel {car.FuelLevel}, total distance {car.Odometer}, and the daily distance is {car.DailyOdometer:F1}");
car.Drive(100);
Console.WriteLine($"{car.Brand} {car.Model}, fuel {car.FuelLevel}, total distance {car.Odometer}, and the daily distance is {car.DailyOdometer:F1}");
car.Drive(200);
Console.WriteLine($"{car.Brand} {car.Model}, fuel {car.FuelLevel}, total distance {car.Odometer}, and the daily distance is {car.DailyOdometer:F1}");
car.Drive(2000);
Console.WriteLine($"{car.Brand} {car.Model}, fuel {car.FuelLevel}, total distance {car.Odometer}, and the daily distance is {car.DailyOdometer:F1} ");

public class Car
{
    private readonly string _brand;
    private readonly string _model;
    private readonly int _tankCapacity;
    private readonly double _fuelConsumption;
    private double _fuelLevel;
    private double _odometer;
    private double _dailyOdometer;

    public Car(string brand, string model, int tankCapacity, double fuelConsumption)
    {
        if (string.IsNullOrWhiteSpace(brand))
            throw new ArgumentNullException(nameof(brand), "Brand can't be empty");

        if (string.IsNullOrWhiteSpace(model))
            throw new ArgumentNullException(nameof(model), "Model can't be empty");

        if (tankCapacity <= 0)
            throw new ArgumentOutOfRangeException(nameof(tankCapacity), "Tank capacity must be positive");

        if (fuelConsumption <= 0)
            throw new ArgumentOutOfRangeException(nameof(fuelConsumption), "Fuel consumption must be positive");

        _brand = brand;
        _model = model;
        _tankCapacity = tankCapacity;
        _fuelConsumption = fuelConsumption;
    }

    public void Tank(double fuel)
    {
        if (fuel < 0)
            throw new ArgumentOutOfRangeException(nameof(fuel), "Added fuel must be positive");

        _fuelLevel += fuel;

        if (_fuelLevel > _tankCapacity)
            _fuelLevel = _tankCapacity;
    }

    public void Drive(double distance)
    {
        if (distance < 0)
            throw new ArgumentOutOfRangeException(nameof(distance), "Distance must be positive");

        var maximumDistance = _fuelLevel / _fuelConsumption * 100;


        double actualDistance;
        if (distance <= maximumDistance)
        {
            actualDistance = distance;
        } else
        {
            actualDistance = maximumDistance;
        }

 
        _odometer = (_odometer + actualDistance) % 1000000;
        _dailyOdometer = (_dailyOdometer + actualDistance) % 1000;

        _dailyOdometer += actualDistance;
        if (_dailyOdometer >= 1000)
        {
            _dailyOdometer -= 1000;
        }


        _fuelLevel -= actualDistance * _fuelConsumption / 100;

        if (distance > maximumDistance)
        {
            _fuelLevel = 0;
        }
    }

    public string Brand => _brand;

    public string Model => _model;

    public double FuelLevel => Math.Round(_fuelLevel, 1);

    public int Odometer => (int)_odometer;

    public double DailyOdometer => Math.Round(_dailyOdometer, 1);
}