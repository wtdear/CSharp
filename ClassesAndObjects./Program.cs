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
Second Program is under development <3,
choose task:
0) Exit program

1) Smart Devices
2) 
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
				Main();
				break;
			default:
				Console.Clear();
				Main();
				break;
		}
    } // Main

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
