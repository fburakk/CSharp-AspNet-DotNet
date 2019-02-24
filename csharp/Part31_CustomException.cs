using System;
using System.IO;
using System.Runtime.Serialization;

//Custom Exception

public class CustomException
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is already logged in!");
        }
        catch(UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException() : base() { }
    public UserAlreadyLoggedInException(string message) : base(message) { }
    public UserAlreadyLoggedInException(string message, Exception InnerException) : base(message, InnerException) { }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}