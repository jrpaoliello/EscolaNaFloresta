using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fase
{    
    private Dictionary<int,Exercicio> exercicios = new Dictionary<int, Exercicio>();

    public Dictionary<int,Exercicio> getExercicios()
    {
        return exercicios;
    } 

    public void addExercicio(int posicao, Exercicio exercicio)
    {
        exercicios.Add(posicao, exercicio);
    }

    public Exercicio getExercicio(int posicao)
    {
        return exercicios[posicao];
    }

}
