namespace atividade;
//A classe Map deverá armazenar as informações do mapa 2D
// implementar métodos para adição e remoção de joias e obstáculos. Além de um método para imprimir o mapa na tela. 
// A impressão do mapa deverá seguir a seguinte regra: Robo será impresso como ME; Joias Red, como JR; Joias Green, como JG; Joias Blue, como JB;
// Obstáculos do tipo Tree, como $$; Obstáculos do tipo Water, como ##; Espaços vazios, como --.
//

public class Map
{
    public void draw()
    {

        string[,] array2D  = new string[10,10]  { { "ME", "--", "--", "--", "--", "--", "--", "--", "--", "--"}, { "--", "--", "--", "--", "$$", "--", "--", "--", "--", "JR"},
                                                { "--", "JB", "--", "--", "--", "$$", "--", "--", "--", "--"}, { "--", "--", "--", "--", "--", "--", "--", "--", "--", "$$"},
                                                { "--", "--", "--", "--", "--", "--", "--", "--", "--", "--"},{ "##", "##", "##", "##", "##", "##", "##", "--", "--", "$$"},
                                                { "--", "--", "--", "--", "--", "--", "--", "--", "--", "--"}, { "--", "--", "--", "--", "--", "--", "JG", "--", "--", "--"},
                                                { "--", "--", "--", "$$", "--", "--", "--", "--", "JR", "--"}, { "--", "JG", "--", "--", "JB", "--", "--", "--", "--", "--"} };

        //System.Console.WriteLine(array2D[0, 1]);
        //System.Console.WriteLine(array2D[0, 1]);
        //System.Console.WriteLine(array2D[1, 0]);
        //System.Console.WriteLine(array2D[1, 1]);

        for (int i = 0; i < array2D.GetLength(0); i++){                       //GetLength especificar a dimensão da matriz
          for (int j = 0; j < array2D.GetLength(1); j++)
                Console.Write(array2D[i, j] + " ");
            Console.Write("\n");
        }
        Robot b = new Robot();
        b.Bob();
    }   
}
