//Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
//but allows subclasses to alter the type of objects that will be created.

using Factory;

var type = Console.ReadLine();
var message = Console.ReadLine();


try
{
    var messageSenderFactory = new ConcreteMessageSenderFactory();
    var messageSender = messageSenderFactory.CreateMessageSender(type);
    messageSender.SendMessage(message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




