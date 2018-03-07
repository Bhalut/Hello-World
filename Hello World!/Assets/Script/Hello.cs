using UnityEngine;

public class Hello : MonoBehaviour 
{
    readonly One one = new One();       //Instanciando la clase One con el nombre "one" de variable
    readonly Two two = new Two();       //Instanciando la clase Two con el nombre "two" de variable
    readonly Three three = new Three(); //Instanciando la clase Three con el nombre "three" de variable
    readonly Four four = new Four();    //Instanciando la clase Four con el nombre "four" de variable
    readonly Five five = new Five();    //Instanciando la clase Five con el nombre "five" de variable

    void Start() //Iniciar al reproducir
    {
        one.Hi();               //Instanciando la funcion "Hi" de la clase One

        two.Literals(1, 3);     //Instanciando la funcion "Literals" que recibe dos argumentos de tipo int (1, 2) de la clase Two

        three.SumVariables();   //Instanciando la funcion "SumVariables" de la clase Three

        four.Prom();            //Instanciando la funcion "Prom" de la clase Four

        five.PromDecimals();    //Instanciando la funcion "PromDecimals" de la clase Five

    }
}