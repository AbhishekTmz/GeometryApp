using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.FeatureManagement;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };
        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        
        var services = new ServiceCollection();
        services.AddFeatureManagement(configuration);
        var serviceProvider = services.BuildServiceProvider();

     
        var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("Input number to calculate Square");
            Console.WriteLine("Enter side length for Square:");
            double sideLength = Convert.ToDouble(Console.ReadLine());
            double AreaOfSquare = sideLength * sideLength;
            double PerimeterOfSquare = 4 * sideLength;
            Console.WriteLine($"Area of Square: {AreaOfSquare}");
            Console.WriteLine($"Perimeter of Square: {PerimeterOfSquare}");
        }
        else
        {
            Console.WriteLine("Number is incorrect for Square");
        }

        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("Input Number for rectangle");
            Console.WriteLine("Enter length for Rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth for Rectangle:");
            double breadth = Convert.ToDouble(Console.ReadLine());
            double AreaofRect = length * breadth;
            double PerimeterofRect = 2 * (length + breadth);
            Console.WriteLine($"Area of Rectangle: {AreaofRect}");
            Console.WriteLine($"Perimeter of Rectangle: {PerimeterofRect}");
        }
        else
        {
            Console.WriteLine("Number is incorect for Rectangle.");
        }

        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("Input number for triangle");
            Console.WriteLine("Enter base length for Triangle:");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height for Triangle:");
            double height = Convert.ToDouble(Console.ReadLine());
            double Areaoftriangle = 0.5 * baseLength * height;
            double PerimeterOfTri = 3 * baseLength; 
            Console.WriteLine($"Area of Triangle: {Areaoftriangle}");
            Console.WriteLine($"Perimeter of Triangle: {PerimeterOfTri}");
        }
        else
        {
            Console.WriteLine("Number is incorrect for Triangle");
        }
    }
}

