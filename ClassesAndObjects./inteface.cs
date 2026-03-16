using System;

public interface OnOff
{
    void On();
    void Off();
}
public interface IReservable
{
    void MakeReservation();
    void DeleteReservation();
}
