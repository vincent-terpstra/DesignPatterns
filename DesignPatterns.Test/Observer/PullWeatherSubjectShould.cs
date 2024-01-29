using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Pull;


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

        // Act


        // Assert


    }

    [Fact]
    public void Allow_Multiple_Observers()
    {
        
    }
    
    [Fact]
    public void Only_Register_Observers_Once()
    {
        
    }
    
    [Fact]
    public void Allow_UnSubscribing()
    {
        
    }
}