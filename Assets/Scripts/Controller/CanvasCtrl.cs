using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CanvasCtrl : MonoBehaviour
{

    public Text inputTextPontos;
    public Text lablePontos;
    public GameObject btJogar;
    public GameObject btRepetirAula;
    public GameObject btFazerExercicios;

    // Start is called before the first frame update
    void Start()
    {
        inputTextPontos.enabled = false;
        lablePontos.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        inputTextPontos.text = GameManager.instance.getAcertos().ToString();
    }

    public void pressPlayOpenScreen()
    {
        GameManager.instance.addNumeroFase();
        disableItensHUD();
        SceneManager.LoadScene("Scenes/Fase" + GameManager.instance.getNumeroFase());
    }

    public void pressPlayFazerExercicio()
    {
        GameManager.instance.addNumeroExercicio();
        disableItensHUD();
        SceneManager.LoadScene("Scenes/Fase" + GameManager.instance.getNumeroFase() + "Exercicio" + GameManager.instance.getNumeroExercicio());
    }

    private void disableItensHUD()
    {

        if (GameManager.instance.isSceneFase()) //se for cena inicial da aula
        {
            btJogar.SetActive(false);
            btRepetirAula.SetActive(true);
            btFazerExercicios.SetActive(true);
            lablePontos.enabled = true;
            inputTextPontos.enabled = true;
        }
        else //se for sena de exercício
        {
            btRepetirAula.SetActive(false);
            btFazerExercicios.SetActive(false);
            lablePontos.enabled = true;
            inputTextPontos.enabled = true;
        }
    }
}
