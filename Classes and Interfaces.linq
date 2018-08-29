<Query Kind="Program" />

void Main()
{
	var myCar = new Mazda("626");
	
	myCar.Something.Dump();
	myCar.Something.Dump();
	
	var kevin = new Child();
	kevin.PlayWithToyCar(myCar);
	
	var jeep = new JeepTruck();
	kevin.PlayWithToyCar(jeep);
	
	
	
	var carInventory = new List<ToyCar>();
	carInventory.Add(myCar);
	carInventory.Add(jeep);
	
	carInventory.Dump();
	
	
//	Enumerable.Range(1,20).Dump()
}

// Define other methods and classes here

class Child
{
	
	public void PlayWithToyCar(ToyCar car) {
		car.Move(5);
		car.Move(-2);
		
		car.ReadOdometer();
	}
	
}

class JeepTruck : ToyCar
{
	public string Make { get; set; }
	public int DistanceTraveled { get; set; }

	public JeepTruck()
	{
		Make = "Cherokee";
	}

	public void Move(int amount)
	{
		DistanceTraveled += amount + 1;
	}

	public void ReadOdometer()
	{
		$"The {Make} has gone {DistanceTraveled} kilometers".Dump();
	}
}


class Mazda : ToyCar
{
	// Fields
	private int _something;

	// Properties
	public int Something { get {
		_something += 5;
		return _something; 
		} 
	}
	
	public int DistanceTraveled { get; set; }
	public string Make { get; set; }

	// Constructor
	public Mazda(string model)
	{
		Make = $"Mazda {model}";
	}

	// Function
	public void Move(int amount)
	{
		DistanceTraveled += amount;
	}

	public void ReadOdometer()
	{
		$"The {Make} has gone {DistanceTraveled} kilometers".Dump();
	}
	
	public void OpenSunroof() {
		
	}
}

interface ToyCar {

	string Make { get; set; }
	int DistanceTraveled { get; set; }
	
	void Move(int amount);
	void ReadOdometer();
}