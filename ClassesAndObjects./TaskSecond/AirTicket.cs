using System;

public class AirTicket : IReservable
{
    internal string Name;
    internal bool Status;

    public void MakeReservation()
    {
        Console.WriteLine($"Вы успешно забронировали рейс '{Name}' | Статус - {Status}");
    }

    public void DeleteReservation()
    {
        Console.WriteLine($"Вы успешно удалили бронь рейса '{Name}' | Статус - {Status}");
    }
}
