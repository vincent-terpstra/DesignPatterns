using DesignPatterns.Facade.Interfaces;

namespace DesignPatterns.Facade;

public class HomeTheaterFacade
{
    public HomeTheaterFacade(IAmplifier amplifier, ICdPlayer cdPlayer, IDvdPlayer dvdPlayer, IPopcornPopper popcornPopper, IProjector projector, IScreen screen, ITheaterLights theaterLights)
    {
        Amplifier = amplifier;
        CdPlayer = cdPlayer;
        DvdPlayer = dvdPlayer;
        PopcornPopper = popcornPopper;
        Projector = projector;
        Screen = screen;
        TheaterLights = theaterLights;
    }

    public IAmplifier Amplifier { get; set; }
    public ICdPlayer CdPlayer { get; set; }
    public IDvdPlayer DvdPlayer { get; set; }
    public IPopcornPopper PopcornPopper { get; set; }
    public IProjector Projector { get; set; }
    public IScreen Screen { get; set; }
    public ITheaterLights TheaterLights { get; set; }
    
    public void WatchMovie(string movie)
    {
        Console.WriteLine("Getting ready to watch a movie");
        PopcornPopper.On();
        PopcornPopper.Pop();
        
        TheaterLights.Dim(10);
        Screen.Down();

        Projector.On();
        Projector.WideScreenMode();
        
        Amplifier.On();
        Amplifier.SetDvdPlayer(DvdPlayer);
        Amplifier.SetSurroundSound();
        Amplifier.SetVolume(5);
        
        DvdPlayer.On();
        DvdPlayer.Play(movie);
    }

    public void EndMovie()
    {
        Console.WriteLine("Ending the movie");
        
        PopcornPopper.Off();

        TheaterLights.Off();
        Screen.Up();
        
        Projector.Off();
        
        Amplifier.Off();
        DvdPlayer.Stop();
        DvdPlayer.Eject();
        DvdPlayer.Off();
    }

    public void ListenToCd()
    {
        
    }

    public void EndCd()
    {
        
    }

    public void ListenToRadio()
    {
        
    }

    public void EndRadio()
    {
        
    }
}