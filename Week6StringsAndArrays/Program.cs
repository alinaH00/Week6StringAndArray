
Console.WriteLine("Enter your first name:");

string username = Console.ReadLine().Trim();



Console.WriteLine(username.Length);
Console.WriteLine($"The first Letter in your name is {username[0]}");

//replace

string updatedUsername = username.Replace('a', '4').Replace('i','3');
Console.WriteLine(updatedUsername);