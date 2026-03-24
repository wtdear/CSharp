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
					hotel.Status = Status;

					hotel.MakeReservation();
                }
                else
                {
					Console.Clear();

                    Console.WriteLine("Reservation already taken!");
                    hotelReservation();
                }
                return;
			default:
				Console.Clear();
				hotelReservation();
                break;
		}
	} // HotelReservation

    static void airReservation()
    {
        Console.Clear();

        Console.Write(@"What you want?:

1) Delete Reservation
2) Get Reservation");

        string airChoose = Console.ReadLine();
        bool Status = false;
        string Name;

        switch (airChoose)
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
                    Console.Write("Enter air ticket name: ");
                    Name = Console.ReadLine();

                    Console.WriteLine("Reservation was deleted");
                    Status = false;

                    AirTicket air = new AirTicket();
                    air.Name = Name;
                    air.Status = Status;

                    air.DeleteReservation();
                }
                return;
            case "2":
                if (Status == false)
                {
                    Console.Write("Enter air ticket name: ");
                    Name = Console.ReadLine();
                    Status = true;

					AirTicket air = new AirTicket();
					air.Name = Name;
					air.Status = Status;

					air.MakeReservation();
                }
                else
                {
                    Console.Clear();

                    Console.WriteLine("Reservation already taken!");
                    hotelReservation();
                }
                return;
            default:
                Console.Clear();
                hotelReservation();
                break;
        }
    } // AirReservation
	
    static void Devices()
	{
		Console.Clear();

		Console.Write("Enter device name: ");
		string deviceName = Console.ReadLine();

		Console.Write(@"
Enter device type:
1) TV
2) Fridge
Type: ");
		string deviceChoice = Console.ReadLine();

		switch (deviceChoice)
		{
			case "1":
				FunctionsTV(deviceName);
				break;
			case "2":
				FunctionsFridge(deviceName);
				break;
			default:
				Console.Clear();
				Devices();
				break;
		}
    } // Devices

	static void FunctionsTV(string deviceName)
	{
        TV tv = new TV();
        tv.modelName = deviceName;

		Console.Write(@"
Do you want On or Off TV?:
1) On
2) Off
Choice - ");

        string TVFuncChoice = Console.ReadLine();

        switch (TVFuncChoice)
        {
            case "1":
                tv.On();
                break;
            case "2":
                tv.Off();
                break;
            default:
                Console.Clear();
                Devices();
                break;
        }
    } // FunctionsTV

    static void FunctionsFridge(string deviceName)
	{
        Fridge fridge = new Fridge();
        fridge.modelName = deviceName;

        Console.Write(@"
Do you want On or Off Fridge?:
1) On
2) Off
Choice - ");

		string fridgeFuncChoice = Console.ReadLine();

		switch (fridgeFuncChoice)
		{
			case "1":
				fridge.On();
				break;
			case "2":
				fridge.Off();
				break;
			default:
				Console.Clear();
				Devices();
				break;
		}
	} // FunctionsFridge
}
