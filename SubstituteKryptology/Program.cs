Console.WriteLine("Indsæt text.");
string text = Console.ReadLine();
Console.WriteLine("Indtast antal tegn der skal forflyttes:");
string recievedAmount = Console.ReadLine();
int displaceAmount = Convert.ToInt32(recievedAmount);
SubstituteKryptology.Enrypter encrypter = new SubstituteKryptology.Enrypter();
string encryptedText = encrypter.Encrypt(text, displaceAmount);
Console.WriteLine(encryptedText);
string decryptedText = encrypter.Decrypt(encryptedText, displaceAmount);
Console.WriteLine("Original text:");
Console.WriteLine(text);

Console.WriteLine("Decrypted text:");
Console.WriteLine(decryptedText);

if (decryptedText == text)
{
    Console.WriteLine("Success!");
}
else
{
    Console.WriteLine("Error!");
}
Console.WriteLine("Press enter to close.");
Console.ReadLine();
