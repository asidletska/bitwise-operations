using System;

internal class Program
{
    static void Main()
    {
        // With constant:

        byte Settings1 = 0b00001011;
        const byte FAN_ON = 0b00000001;
        const byte FAN_ROTATING = 0b00000010;
        const byte LOW_SPEED = 1;
        const byte NORMAL_SPEED = 2;
        const byte HIGH_SPEED = 3;

        // i use bitwise right shift because we need to shift the bits that determine the speed 
        //                 0000 [00]00
        // Low speed    -> 0000 [01]00 >>2 -> 0000 0001 -> 1
        // Normal speed -> 0000 [10]00 >>2 -> 0000 0010 -> 2
        // High speed   -> 0000 [11]00 >>2 -> 0000 0011 -> 3

        if ((Settings1 & FAN_ON) == FAN_ON) // brackets to increase the priority
        {
            Console.WriteLine("the power indicator light came on");

            if ((Settings1 & FAN_ROTATING) == FAN_ROTATING)
            {
                Console.WriteLine("the fan spins");
            }

            if ((Settings1 >> 2) == LOW_SPEED) 
            {
                Console.WriteLine("the fan rotates at low speed");
            }
            else if ((Settings1 >> 2) == NORMAL_SPEED)
            {
                Console.WriteLine("the fan spins at normal speed");
            }
            else if ((Settings1 >> 2) == HIGH_SPEED)
            {
                Console.WriteLine("the fan spins at high speed");
            }
            else
            {
                Console.WriteLine("wrong speed value");
            }
        }
    }
}

