using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemExercicioCtrl : MonoBehaviour
{
    public bool respostaCorreta;

    void OnMouseDown()
    {
        if (respostaCorreta)
        {
            GameManager.instance.addAcertos();
        }
        else GameManager.instance.addErros();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
