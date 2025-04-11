using Xunit;
using server;
using server.Classes;
using System.Threading.Tasks;
using System;

namespace unittest;



public class EmailRequestRecordTest
{
    [Fact]
    public void TestSendEmail()
    {
        string testingTo = "test@testsson.com";
        string testingSubject = "testSubject";
        string testingBody = "testBody";
        
        var emailRequest = new EmailRequest(testingTo, testingSubject, testingBody);

        Assert.Equal(testingTo, emailRequest.To);
        Assert.Equal(testingSubject, emailRequest.Subject);
        Assert.Equal(testingBody, emailRequest.Body);
    }
}
