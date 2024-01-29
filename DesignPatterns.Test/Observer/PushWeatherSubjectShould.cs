using DesignPatterns.Observer.Push;
using DesignPatterns.Observer.Push.Interfaces;
using DesignPatterns.Observer.Push.Models;

namespace DesignPatterns.Test.Observer;

public class PushWeatherSubjectShould
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

        PushWeatherSubject subject = new PushWeatherSubject(data);

        var observer = new Mock<IPushObserver<WeatherData>>();
            observer.Setup(o => o.Update(It.IsAny<WeatherData>()));
        
        // Act
        subject.Subscribe(observer.Object);
        subject.NotifyObservers();

        // Assert
        observer.Verify(o => o.Update(It.IsAny<WeatherData>()), Times.Once);
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

        PushWeatherSubject subject = new PushWeatherSubject(data);

        var observer = new Mock<IPushObserver<WeatherData>>();
        observer.Setup(o => o.Update(It.IsAny<WeatherData>()));
        
        var observer2 = new Mock<IPushObserver<WeatherData>>();
        observer2.Setup(o => o.Update(It.IsAny<WeatherData>()));
        
        // Act
        subject.Subscribe(observer.Object);
        subject.Subscribe(observer2.Object);
        subject.NotifyObservers();

        // Assert
        observer.Verify(o => o.Update(It.IsAny<WeatherData>()), Times.Once);
        observer2.Verify(o => o.Update(It.IsAny<WeatherData>()), Times.Once);
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

        PushWeatherSubject subject = new PushWeatherSubject(data);

        var observer = new Mock<IPushObserver<WeatherData>>();
        observer.Setup(o => o.Update(It.IsAny<WeatherData>()));
        
        // Act
        subject.Subscribe(observer.Object);
        subject.Subscribe(observer.Object);
        subject.NotifyObservers();

        // Assert
        observer.Verify(o => o.Update(It.IsAny<WeatherData>()), Times.Once);
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

        PushWeatherSubject subject = new PushWeatherSubject(data);

        var observer = new Mock<IPushObserver<WeatherData>>();
        observer.Setup(o => o.Update(It.IsAny<WeatherData>()));
        
        // Act
        subject.Subscribe(observer.Object);
        subject.UnSubscribe(observer.Object);
        subject.NotifyObservers();

        // Assert
        observer.Verify(o => o.Update(It.IsAny<WeatherData>()), Times.Never);
    }
}