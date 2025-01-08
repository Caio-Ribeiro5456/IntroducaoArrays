// See https://aka.ms/new-console-template for more information

//arrays é definido como uma lista exemplo abaixo:
//Dias da semana: segunda,terça,quarta,quinta,sexta,sábado,domingo
// indice interno  |  valor
//      0             segunda
//      1             terça
//      2             quarta
//      3             quinta
//      4             sexta
//      5             sábado
//      6             domingo

using System.Security.Cryptography;

string[] semana = new string[7] { "segunda", "terça", "quarta", "quinta",
                                  "sexta", "sábado", "domingo" };


//ITERAÇÃO: SIGINIFICA PERCORRER UM ARRAY COM ESTRUTURA DE REPETIÇÃO
//I ++ == I = I+1;

for (int i = 0; i < semana.Length; i++)
{    
    //SEM ITERAÇÃO
    Console.WriteLine("O Dia da semana é: " + semana[2]);



    // COM ITERAÇÃO
    Console.WriteLine("O Dia da semana é: " + semana[i]);

  

    //ITERAÇÃO COM FOR EACH
    foreach (string dia in semana)
        Console.WriteLine("O Dia da semana é: " + dia);


    //através do array index off é possível manipular 
    //um array dentro do próprio array identificando sua posiçao

    Console.WriteLine("A posição de quarta é: " + Array.IndexOf(semana, "quarta"));

}

