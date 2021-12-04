using System;
public class arreglos

{public static void Main()
    {
        int[] principal = new int[100];
        int serie= 1;
        int flagnumero_incrementos=1;
        for (int i = 0; i < 100; i++){
            principal[i] = i + 1;
            if(principal[i] == serie)
            {
                Console.WriteLine(principal[i]);
                //Actualizar siguinte numero de serie
                if (flagnumero_incrementos <= 3)
                {
                    serie+=3;
                }
                else if (flagnumero_incrementos>=4 && flagnumero_incrementos<=7)
                {
                    serie+=6;
                }
                else
                {
                    serie+=12;
                }
                flagnumero_incrementos++;
            }
        }
            

    }

}