using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Pull;
using DesignPatterns.Observer.Pull.DisplayElements;
using DesignPatterns.Observer.Pull.Interfaces;

namespace DesignPatterns.Test.Observer;

public class PullWeatherSubjectShould
{
    [Fact]
    public void Call_Update_On_Observers()
    {
        // Arrange
        WeatherData data = new()
        {
            Temperature = 1,
            Humidity = 2,
            Pressure = 3
        };

        PullWeatherSubject subject = new PullWeatherSubject(data);

        var observer = new CurrentConditionsDisplay(subject);
        
        // Act
        subject.Register(observer);
        subject.NotifyObservers();
        
        // Assert
        
        data.Should().BeEquivalentTo(subject);
        data.Should().BeEquivalentTo(observer);
    }
    
    [Fact]
    public void Allow_Multiple_Observers()
    {
        // Arrange
        WeatherData data = new()
        {
            Temperature = 1,
            Humidity = 2,
            Pressure = 3
        };

        PullWeatherSubject subject = new PullWeatherSubject(data);

        var observer = new CurrentConditionsDisplay(subject);
        var observer2 = new CurrentConditionsDisplay(subject);
        
        // Act
        subject.Register(observer);
        subject.Register(observer2);
        subject.NotifyObservers();
        
        // Assert
        
        data.Should().BeEquivalentTo(subject);
        data.Should().BeEquivalentTo(observer);
        data.Should().BeEquivalentTo(observer2);
    }
    
    [Fact]
    public void Only_Register_Observers_Once()
    {
        // Arrange
        WeatherData data = new()
        {
            Temperature = 1,
            Humidity = 2,
            Pressure = 3
        };

        PullWeatherSubject subject = new PullWeatherSubject(data);
        
        var observer = new Mock<IObserver>();
            observer.Setup(o => o.Update());
        // Act
        subject.Register(observer.Object);
        subject.Register(observer.Object);
        subject.NotifyObservers();
        
        // Assert
        observer.Verify(o =>o.Update(), Times.Once);
    }
    
    [Fact]
    public void Allow_UnSubscribing()
    {
        // Arrange
        WeatherData data = new()
        {
            Temperature = 1,
            Humidity = 2,
            Pressure = 3
        };

        PullWeatherSubject subject = new PullWeatherSubject(data);
        
        var observer = new Mock<IObserver>();
        observer.Setup(o => o.Update());
        // Act
        subject.Register(observer.Object);
        subject.Remove(observer.Object);
        subject.NotifyObservers();
        
        // Assert
        observer.Verify(o =>o.Update(), Times.Never);
    }
}