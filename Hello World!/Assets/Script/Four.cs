using UnityEngine;

public class Four  //Clase de nombre Four
{
    int l1 = 1; //Inicianizando una variable de tipo int "l1" = 1
    int l2 = 2; //Inicianizando una variable de tipo int "l2" = 2
    int l3 = 3; //Inicianizando una variable de tipo int "l3" = 3
    int l4 = 4; //Inicianizando una variable de tipo int "l4" = 4
    int l5 = 5; //Inicianizando una variable de tipo int "l5" = 5

    public void Prom() //Funcion de nombre Prom
    {
        Debug.Log((l1 + l2 + l3 + l4 + l5) / 5); //Imprimir las cinco variables inicializadas de tipo int, sumarlas entre si, y dividir la suma entre cinco
    }
}
