﻿int senha = int.Parse(Console.ReadLine());

while (senha != 2002)
{
    Console.WriteLine("Senha Incorreta");
    senha = int.Parse(Console.ReadLine());
}
Console.WriteLine("Acesso Permitido");