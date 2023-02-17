using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lamps.Data;
using System;
using System.Linq;

namespace Lamps.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LampsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LampsContext>>()))
            {
                // Look for any Lamps.
                if (context.Lamp.Any())
                {
                    return;   // DB has been seeded
                }

                context.Lamp.AddRange(
                    new Lamp
                    {
                        Name = "Incandescent Lamps",
                        Brightness = "Luminous Flux",
                        Efficiency = "Low Efficiency",
                        Shapes = "Bulb Shape",
                        ColorTemperature = "Bulb Shape",
                        Rating = 1
                    },

                    new Lamp
                    {
                        Name = "Fluorescent Lamps",
                        Brightness = "Bright Light",
                        Efficiency = "High Efficiency",
                        Shapes = "Tubular",
                        ColorTemperature = "Kelvin Scale",
                        Rating = 4
                    },

                    new Lamp
                    {
                        Name = "LED Lamps",
                        Brightness = "High",
                        Efficiency = "Energy Efficient",
                        Shapes = "Bulb, Tube etc",
                        ColorTemperature = "Variable",
                        Rating = 1
                    },

                    new Lamp
                    {
                        Name = "Oil Lamps",
                        Brightness = "Warm Glow",
                        Efficiency = "Low Efficiency",
                        Shapes = "Cylindrical or Conical",
                        ColorTemperature = "Warm Yellow",
                        Rating = 1
                    },
                    new Lamp
                    {
                        Name = "Salt Lamps",
                        Brightness = "Soft Light",
                        Efficiency = "Low Efficiency",
                        Shapes = "Spherical",
                        ColorTemperature = "Warm",
                        Rating = 1
                    },
                    new Lamp
                    {
                        Name = "Neon Lamps",
                        Brightness = "Bright Glow",
                        Efficiency = "Low Efficiency",
                        Shapes = "Tubular",
                        ColorTemperature = "No specific Temperature",
                        Rating = 1
                    },
                    new Lamp
                    {
                        Name = "Halogen Lamps",
                        Brightness = "High",
                        Efficiency = "Low Efficiency",
                        Shapes = "Bulb, Tube etc",
                        ColorTemperature = "warme",
                        Rating = 1
                    },
                    new Lamp
                    {
                        Name = "Floor Lamps",
                        Brightness = "High",
                        Efficiency = "Energy Efficient",
                        Shapes = "Tall",
                        ColorTemperature = "Neutral",
                        Rating = 5
                    },
                    new Lamp
                    {
                        Name = "Buffet Lamps",
                        Brightness = "Dim",
                        Efficiency = "Energy Efficient",
                        Shapes = "Bulb, Tube etc",
                        ColorTemperature = "Warm/Dim",
                        Rating = 4
                    },
                    new Lamp
                    {
                        Name = "Desk Lamps",
                        Brightness = "High",
                        Efficiency = "Energy Efficient",
                        Shapes = "Adjustable",
                        ColorTemperature = "Cool",
                        Rating = 5
                    }
                );
                context.SaveChanges();
            }
        }
    }
}