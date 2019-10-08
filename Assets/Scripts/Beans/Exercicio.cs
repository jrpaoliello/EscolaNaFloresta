using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercicio
{   
    private int totalCorretas;
    private int totalClicadasCorretas;
    private int totalClicadasErradas;

    public Exercicio(int totalCorretas)
    {
        this.totalCorretas = totalCorretas;
    }

    public int getTotalCorretas()
    {
        return totalCorretas;
    }

    public int getTotalClicadasCorretas()
    {
        return totalClicadasCorretas;
    }

    public int getTotalClicadasErradas()
    {
        return totalClicadasErradas;
    }

    public void addTotalClicadasCorretas()
    {
        this.totalClicadasCorretas++;
    }

    public void addTotalClicadasErradas()
    {
        this.totalClicadasErradas++;
    }
}