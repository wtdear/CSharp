using System;
using Task1;
using Task2;

public class MainLogic
{
	public static void Main()
	{
		Console.Write(@"
Hello, Dev. - Johhny Kolbaya, 
First Program can turn on or off your device!,
Second Program can get reservation air ticket or hotel,
choose task:
0) Exit program

1) Smart Devices
2) Reservation system

Coice - ");
		string choice = Console.ReadLine();

		switch (choice)
		{
			case "0":
				Environment.Exit(0);
				break;
			case "1":
				Devices();
				break;
			case "2":
				getReservation();
				break;
			default:
				Console.Clear();
				Main();
				break;
		}
    } // Main

	static void getReservation()
	{
		Console.Clear();

		Console.Write(@"What you want reservation?:

1) Hotel
2) Air ticket

Choice - ");

		string choice = Console.ReadLine();

		switch (choice)
		{
			case "1":
				hotelReservation();
				break;
			case "2":
				airReservation();
				break;
			default:
				Console.Clear();
				getReservation();
				break;
		}
	} // GetReservation

	static void hotelReservation()
	{
		Console.Clear();

		Console.Write(@"What you want?:

1) Delete Reservation
2) Get Reservation");

		string hotelChoose = Console.ReadLine();
		bool Status = false;
		string Name;

		switch(hotelChoose)
		{
			case "1":
				if (Status)
				{
					Console.Clear();

					Console.WriteLine("You already have reservation!\n");
					hotelReservation();
				}
				else
				{
                    Console.Write("Enter hotel name: ");
                    Name = Console.ReadLine();

                    Console.WriteLine("Reservation was deleted");
					Status = false;

                    Hotel hotel = new Hotel();
                    hotel.Name = Name;
                    hotel.Status = Status;

					hotel.DeleteReservation();
                }
				return;
			case "2":
                if (Status == false)
                {
                    Console.Write("Enter hotel name: ");
					Name = Console.ReadLine();
					Status = true;

					Hotel hotel = new Hotel();
					hotel.Name = Name;
					hotel.Status = S
