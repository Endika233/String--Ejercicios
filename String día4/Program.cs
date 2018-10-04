using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_día4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Escribe un programa que te calcule la largura de un string.
            //string word;
            //Console.WriteLine("Escribe una palabra");
            //word = Console.ReadLine();
            //Console.WriteLine("Esta palabra tiene "+word.Length+" letras");
            //Console.ReadLine();


            ////Escribe un programa que copia un string a otro string.
            //string word1, word2;
            //Console.WriteLine("Escribe una palabra");
            //word1=Console.ReadLine();
            //word2 = word1;
            //Console.WriteLine(word2);


            ////Escribe un programa que nos cuente el número de vocales en un string.
            //Console.WriteLine("Escriba una palabra");
            //String respuesta;
            //respuesta = Console.ReadLine();
            //int vocales = 0;
            //for (int i = 0; i < respuesta.Length; i++)
            //{
            //    if
            //     (respuesta[i] == 'a' || respuesta[i] == 'e' || respuesta[i] == 'i' || respuesta[i] == 'o' || respuesta[i] == 'u')
            //    {//Se usa comilla simple porque si no no lee las letras, y los corchetes es oara que vaya buscando carácter a carácter
            //        vocales++;//eso es igual a vocales=vocales+1
            //    }
            //}
            //Console.WriteLine("Esa palabra tiene " + vocales + " letras");



            ////Escribe un programa que devuelva un string en minúsculas en mayúsculas y al revés.
            //string word;
            //Console.WriteLine("Escribe una palabra");
            //word = Console.ReadLine();
            //Console.WriteLine(word.ToUpper());//este para mayusculas
            //Console.WriteLine(word.ToLower());//este para min.



            ////Escribe un programa que evalúe si un string contiene la letra ‘r’.
            //string word;
            //int leng,i,r=0;
            //Console.WriteLine("Escribe una palabra");
            //word = Console.ReadLine();
            //leng = word.Length;
            //for (i = 0; i < leng; i++)
            //{
            //    if (word[i] == 'r' || word[i] == 'R') { r++; }//Los corchetes marcan la posicion del caracter en el que buscan
            //    //POR EJEMPLO: si i fuera 3, iria al carácter 3 de word y comprobaría si tuviera r.

            //}
            //if (r > 0)
            //{
            //    Console.WriteLine("Esa palabra contiene R");
            //}
            //else { Console.WriteLine("Esa palabra no contiene R"); }
            ////ATENCION:este ejercicio tambien se puede hacer con el uso de la orden CONTAIN





            ////Escribe un programa que te calcule el total de palabras que hay en un string.
            //string phra;
            //int i, palabras=1;//Hay que empezar con 1 porque al contar los espacios para calcular palabras la primera no la lee
            //Console.WriteLine("Escribe una frase");
            //phra = Console.ReadLine();
            //for (i = 0; i < phra.Length; i++)
            //{
            //    if(phra[i]==' ')//[] esto busca en un caracter en concreto
            //    {
            //        palabras++;
            //    }
            //}

            //Console.WriteLine("Esa frase tiene " +palabras + " palabras");




            ////Escribe un programa el que dada una frase sacará su carácter central. Nota:
            ////Si la largura de la frase es par deberá sacar los dos caracteres centrales correspondientes.
            ////Si es impar deberá sacar su único carácter central.
            //string frase;
            //bool par;////no hace falta usar bool pero asi aprendes a usarlo
            //Console.WriteLine("Escribe una frase");
            //frase=Console.ReadLine();
            //if (frase.Length % 2 == 0)
            //{
            //    par = true;
            //}
            //else
            //{
            //    par = false;
            //}
            //if (par == true)
            //{
            //    Console.WriteLine("" + frase[frase.Length/2] + frase[frase.Length/2+1]);
            //    //Si te salen numeros cuando deberian ser letras puede ser que haya pasado las letras a ASCII
            //    //poniedno un "" hace que lo demas salga escrito en letra no en ASCII

            //}
            //else
            //{
            //    Console.WriteLine(frase[frase.Length/2]);
            //}



            //Escribe un programa el cual analizará si la contraseña introducida es correcta o no.
            //Para que la contraseña sea correcta deberá cumplir estas directivas:
            //Debe tener 8 caracteres como mínimo.
            //La contraseña deberá contener números.
			//Deberá contener al menos dos dígitos. 
			int i,dig;
			string pass;         
            do
            {
                dig = 0;
                Console.WriteLine("Escriba su contraseña:");
                pass = Console.ReadLine();

                for (i = 0; i < pass.Length; i++)
                {
                    if (char.IsNumber(pass[i]))
                    {
                        dig++;
                    }
                }

                if (pass.Length < 8)
                {
                    Console.Write("Introduzca al menos 8 carácteres. ");
                }
                else if(dig<2)
                {
                    Console.Write("Introduzca al menos 2 dígitos.");
                }
            } while (pass.Length < 8 || dig < 2);
            Console.WriteLine("Contraseña aceptada");
			

            




                Console.ReadLine();






        }
    }
}
        

