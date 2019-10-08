using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData 
{
    public static Dictionary<int, Fase> fases;

    public static void IniciaGameData()
    {
        fases = new Dictionary<int, Fase>();

        //montando fase1
        Fase fase1 = new Fase();
        Exercicio exercicio1 = new Exercicio(2);
        Exercicio exercicio2 = new Exercicio(2);
        Exercicio exercicio3 = new Exercicio(2);
        Exercicio exercicio4 = new Exercicio(5);
        Exercicio exercicio5 = new Exercicio(2);

        fase1.addExercicio(1,exercicio1);
        fase1.addExercicio(2, exercicio2);
        fase1.addExercicio(3, exercicio3);
        fase1.addExercicio(4, exercicio4);
        fase1.addExercicio(5, exercicio5);

        fases.Add(1,fase1);
    }
}
