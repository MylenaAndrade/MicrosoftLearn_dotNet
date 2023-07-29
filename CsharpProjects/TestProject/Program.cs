//No prompt de comando Terminal, para criar o novo aplicativo de console na pasta especificada, digite dotnet new console -o ./CsharpProjects/TestProject e pressione Enter

//para executar um programa tem que clicar com o botão direito do mouse no Program.cs e em open Integraded Terminal e por fim escrever dotnet run no terminal
Console.WriteLine("Hello word!");
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
