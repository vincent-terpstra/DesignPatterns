namespace DesignPatterns.Facade.Interfaces;

public interface IDvdPlayer
{
    void On();
    void Off();
    void Eject();
    void Pause();
    void Play(string movie);
    void SetSurroundAudio();
    void Stop();
}