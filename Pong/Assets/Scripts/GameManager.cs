using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ScorePlayer1;

    public int ScorePlayer2;

    public Text ScorePointLabel;

    public AudioSource GolSound;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Saiu do jogo");
           
        }
    }

    //Aumentando a pontuação e modificando o label
    public void increaseScorePlayer1()
    {
        ScorePlayer1 += 1;
        ModifyScorePointLabel();
    }

    //Aumentando a pontuação e modificando o label
    public void increaseScorePlayer2()
    {
        ScorePlayer2 += 1;
        ModifyScorePointLabel();
    }

    // Modificando o placar
    public void ModifyScorePointLabel()
    {
        ScorePointLabel.text = ScorePlayer1 + " X " + ScorePlayer2;

        GolSound.Play();
    }
}
