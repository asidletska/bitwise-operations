using System;

internal class Program
{
    static void Main()
    {
        // We have a fan with 1 byte of RAM
        // Let's imagine that we need to fit this code into 1 byte
        // 0000 0000
        // ХХХХ ХХХ0 -> The fan is off
        // ХХХХ ХХХ1 -> The fan is on
        // ХХХХ ХХ0Х -> The fan is not spinning
        // ХХХХ ХХ1Х -> The fan is spinning
        // ХХХХ 01ХХ -> Low speed
        // ХХХХ 10ХХ -> Normal speed
        // ХХХХ 11ХХ -> High speed


        // With switch:

        byte Settings = 0b00000000;
        bool isFanOn = true;
        bool isFanRotating = true;
        int fanSpeed = 3; // 1 - low, 2 - normal, 3 - high

        if (isFanOn)
        {
            Console.WriteLine("the power indicator light came on");
            if (isFanRotating)
            {
                Console.WriteLine("the fan spins");
            }
            switch (fanSpeed)
            {
                case 1:
                    Console.WriteLine("the fan rotates at low speed");
                    break;
                case 2:
                    Console.WriteLine("the fan spins at normal speed");
                    break;
                case 3:
                    Console.WriteLine("the fan spins at high speed");
                    break;
                default:
                    Console.WriteLine("wrong speed value");
                    break;
            }
        }
    }
}

