 int numero_digitado;

// Pede para o Usúario Digitar um número 
Console.Write("Digite um Número: ");

//Armazena o Número Digitado em uma Variavel  
numero_digitado = Convert.ToInt32 (Console.ReadLine());

bool paridade = (numero_digitado % 2) == 0;

if (paridade)
{
    Console.WriteLine("Par"); 
}         
else
{
    Console.WriteLine("Impar");  
}

