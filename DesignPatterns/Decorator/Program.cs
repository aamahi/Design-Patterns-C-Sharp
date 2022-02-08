using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;

Desktop desktop = new Desktop("Core i5", "ASUS B450");
Console.WriteLine(desktop.GetConfiguration());

Console.WriteLine("Adding Ram");
RamDecorator ramDecorator = new RamDecorator(desktop, "8 gb ddr3");
Console.WriteLine(ramDecorator.GetConfiguration());


Console.WriteLine("Adding Gpu");
GpuDecorator gpuDecorator = new GpuDecorator(ramDecorator, "nvidia gtx 1050ti");
Console.WriteLine(gpuDecorator.GetConfiguration());