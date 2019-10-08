using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int acertos = 0;
    private int erros = 0;
    private int numeroFase = 0;
    private int numeroExercicio = 0; 

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        instance.startGame();
    }

    public void startGame()
    {
        //SceneManager.LoadScene("Scenes/Fase1");
        acertos = 0;
        erros = 0;
        
        GameData.IniciaGameData();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getNumeroFase() 
    {
        return numeroFase;
    }

    public int getNumeroExercicio()
    {
        return numeroExercicio;
    }

    public void addNumeroFase()
    {
        this.numeroFase = this.numeroFase + 1;
    }

    public void addNumeroExercicio()
    {
        this.numeroExercicio = this.numeroExercicio + 1;
    }

    public void addAcertos()
    {
        this.acertos = this.acertos + 1;
        addTotalClicadasCorretasPorExercicio();

        if (getExercicioAtual().getTotalClicadasCorretas() == getExercicioAtual().getTotalCorretas())
        {
            addNumeroExercicio();
            //chama scena no próximo exercício
            SceneManager.LoadScene("Scenes/Fase" + GameManager.instance.getNumeroFase() + "Exercicio" + GameManager.instance.getNumeroExercicio());

        }
    }

    public int getAcertos()
    {
        return acertos;
    }

    public void addErros()
    {
        this.erros = this.erros + 1;
        addTotalClicadasErradasPorExercicio();
    }

    public int getErros()
    {
        return erros;
    }

    public bool isSceneFase()
    {
        if (numeroFase > 0 && numeroExercicio == 0)
            return true;
        else return false;
    }

    private void addTotalClicadasCorretasPorExercicio()
    {
        Exercicio exercicio = getExercicioAtual();
        exercicio.addTotalClicadasCorretas();
    }

    private void addTotalClicadasErradasPorExercicio()
    {
        Exercicio exercicio = getExercicioAtual();
        exercicio.addTotalClicadasErradas();
    }

    public Fase getFaseAtual()
    {
        return GameData.fases[numeroFase];
    }

    public Exercicio getExercicioAtual()
    {
        Debug.Log("numeroFase: " + numeroFase);
        Fase fase = GameData.fases[numeroFase];
        return fase.getExercicio(numeroExercicio);
    }
}
