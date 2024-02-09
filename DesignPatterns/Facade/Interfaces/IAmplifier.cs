namespace DesignPatterns.Facade.Interfaces;

public interface IAmplifier
{
    void On();
    void Off();
    void SetCd();
    void SetDvdPlayer(IDvdPlayer Dvd);
    void SetStereoSound();
    void SetSurroundSound();
    void SetTurner();
    void SetVolume(int i);
}