using System;

public class Hotel : IReservable
{
    internal string Name;
    internal bool Status;

    public void MakeReservation()
    {
        Console.WriteLine($"Вы успешно забронировали отель '{Name}' | Status - {Status}");
    }

    public void DeleteReservation()
    {
        Console.WriteLine($"Вы успешно удалили бронь отеля '{Name}' | Status - {Status}");
    }
}
