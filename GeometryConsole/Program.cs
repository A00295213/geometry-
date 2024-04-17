using System;
using Microsoft.Extensions.Configuration;

using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;

var featureManagement = new Dictionary<string, string> {
    { "FeatureManagement:square", "true" },
    { "FeatureManagement:rectangle", "false" },
    { "FeatureManagement:triangle", "true" }
};

IConfigurationRoot configuration = new ConfigurationBuilder()
    .AddInMemoryCollection(featureManagement)
.Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManager>();

    if (await featureManager.IsEnabledAsync("square"))
            {
                Console.WriteLine("Access to Square is enabled.");
             
                Console.ReadLine();

                Console.WriteLine("Enter the side length of the Square:");


        double a = Convert.ToDouble(Console.ReadLine());

        square square = new square(a);

        Console.WriteLine($"Area of the Square: {square.CalculateArea()}");
        Console.WriteLine($"Perimeter of the Square: {square.CalculatePerimeter()}");
}

if (await featureManager.IsEnabledAsync("rectangle"))
{
    Console.WriteLine("Access to Rectangle is enabled.");
    
    Console.WriteLine("Enter the length of the Rectangle:");

    double l = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the width of the Rectangle:");

    double w = Convert.ToDouble(Console.ReadLine());

    rectangle rectangle = new rectangle(l, w);
    Console.WriteLine($"Area of the Rectangle: {rectangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of the Rectangle: {rectangle.CalculatePerimeter()}");
}

if (await featureManager.IsEnabledAsync("triangle"))
{
    Console.WriteLine("Access to Triangle is enabled.");
    
    Console.WriteLine("Enter the base length of the Triangle:");

    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the height of the Triangle:");

    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the height of the Triangle:");

    double c = Convert.ToDouble(Console.ReadLine());

    triangle triangle = new triangle(x,b,c);
    Console.WriteLine($"Area of the Triangle: {triangle.CalculateArea()}");
    Console.WriteLine($"Perimeter of the Triangle: {triangle.CalculatePerimeter()}");
}

