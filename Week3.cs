using System;

public class Week3
{
	TourPackage tourPackage = new TourPackage();
	TourPackage.SetUpPackage("Pokhara",3,9000);
}

public class TourPackage
{
	//fields
	private int _id;
	private List<string> _destination;
	private int _days;
	private int _price;
	private string _name;
	private bool _booked;

	//class bhaneko structure
	public void SetUpPackage(string destination, int days, int price)
	{
		_destination = new List<string>();
		_destination.Add(destination);
		_days = days;
		_price = price;
	}

	private void BookPackage(string name, bool book)
	{
		_name = name;
		_booked = book;
	}
}
