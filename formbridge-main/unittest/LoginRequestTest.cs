using Xunit;
using server;
using server.Classes;
using System.Threading.Tasks;
using System;

namespace unittest;

public class LoginRequestTest
{
  [Fact]
  public void LoginRequestEmailTest()
  {
    var loginRequest = new LoginRequest();
    string email = "test@test.com";
    string password = "password";
    
    loginRequest.Email = email;
    loginRequest.Password = password;
    
    Assert.Equal(email, loginRequest.Email);
    Assert.Equal(password, loginRequest.Password);
  }
}