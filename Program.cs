Console.Clear();
decimal gasolina, etanol, dif;
string recomend;

Console.WriteLine("--- Etanol ou Gasolina? ---\n");

Console.Write("Digite o preço do etanol (R$).....: ");
etanol = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o preço da gasolina (R$)...: ");
gasolina = Convert.ToDecimal(Console.ReadLine());

dif = (etanol * 100) / gasolina;

Console.WriteLine($"O preço do etanol corresponde a {dif:N1}% do preço da gasolina.");

if (dif > 73)
{
    recomend = "Gasolina";
}
else
{
    recomend = "Etanol";
}

Console.WriteLine($"Recomendação: Abasteça com {recomend.ToUpper()}");