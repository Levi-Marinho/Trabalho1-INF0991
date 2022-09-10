// See https://aka.ms/new-console-template for more information
//Console.WriteLine(" Tá funfa!");
// A classe JewelCollector deverá ser responsável por implementar o método Main(), criar o mapa, inserir as joias, obstáculos, instanciar o robô e ler os comandos do teclado.
// Para que o usuário possa controlar o robô, os seguintes comandos deverão ser passados através das teclas w, s, a, d, g. 
//Sendo que a tecla w desloca o robô para o norte, a tecla s desloca para o sul, a tecla a desloca para oeste e a tecla d para leste. Para coletar uma joia, use a tecla g.

namespace atividade;




public class JewelCollector {

  public void Jewel() {



  
      bool running = true;

  
      do {
    
  
          Console.WriteLine("Enter the command: ");
          string command = Console.ReadLine();
  
          if (command.Equals("quit")) { // Sair

              running = false;
          }
           else if (command.Equals("w")) { // Norte
          Console.WriteLine(" Norte");
              
          } 
          
        else if (command.Equals("a")) { // Left, Esquerda
          Console.WriteLine(" Esquerda");
              
          } 
          
          else if (command.Equals("s")) { // South , Sul
            Console.WriteLine("Sul");
          }
           else if (command.Equals("d")) { // East, direita
          Console.WriteLine(" direita" );
          } 
          
          else if (command.Equals("g")) {// Get, pegar
              Console.WriteLine(" pegar");
          }
          
      }while (running);

}
 }
  
  

