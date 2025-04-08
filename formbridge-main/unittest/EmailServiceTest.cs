namespace unittest;
using Xunit;
using server;


public class EmailServiceTest
{
    [Fact]
    public void TestSendEmail()
    {
        var customer = new Customer("test@testsson", "test", "testsson", 1);
        var message = await Program.SendEmail(customer);
        
        Assert.Equal("Email Sent Successfully!", message.message);
        
    }
}
