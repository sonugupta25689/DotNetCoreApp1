using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;
using Xunit;

namespace CoreWebAPIAzure.Test
{
// Unit Test

public class UnitTest1
{
 ValuesController valuesController=new ValuesController(); // Arrange
 
    [Fact]  // Arrange Act Assert
    public void Test1()
    {
       var test = valuesController.Get(1);  // Act
     Assert.Equal("Yukti",test);// Agar hm yahan p "Amita" Pass karenge to Hamara Test case fail ho jayega 
    }
}
}