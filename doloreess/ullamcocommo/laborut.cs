using System;
using System.Security.Cryptography;

public class Example
{
    public static void Main()
    {
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            byte[] randomNumber = new byte[5]; // Creates a byte array to hold the random value.
            rng.GetBytes(randomNumber); // Fills the array with a random value.
            Console.WriteLine(BitConverter.ToString(randomNumber)); // Prints the random number.
        }
    }
}
