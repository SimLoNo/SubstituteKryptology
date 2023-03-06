Console.WriteLine("Indsæt text.");
string text = Console.ReadLine();
SubstituteKryptology.Enrypter encrypter = new SubstituteKryptology.Enrypter();
string encryptedText = encrypter.Encrypt(text);
Console.WriteLine(encryptedText);
string decryptedText = encrypter.Decrypt(encryptedText);
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
