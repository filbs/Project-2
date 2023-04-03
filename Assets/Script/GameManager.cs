using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PlayerScoreL = 0;
    public int PlayerScoreR = 0;

    public TMP_Text txtPlayerScoreL;
    public TMP_Text txtPlayerScoreR;

    public GameObject panelWin;
    public TMP_Text playerWin;

    public static GameManager instance;
    public SceneManagement sm;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        panelWin.SetActive(false);
        txtPlayerScoreL.text = PlayerScoreL.ToString();
        txtPlayerScoreR.text = PlayerScoreR.ToString();
    }

    public void Score(string wallID)
    {
        if (wallID == "Line L")
        {
            PlayerScoreR = PlayerScoreR + 10;
            txtPlayerScoreR.text = PlayerScoreR.ToString();
            ScoreCheck();
        }
        else
        {
            PlayerScoreL = PlayerScoreL + 10;
            txtPlayerScoreL.text = PlayerScoreL.ToString();
            ScoreCheck();
        }
    }
    public void ScoreCheck()
    {
        if (PlayerScoreL == 30)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player L Win!";
            Invoke("ChangeTheScene", 2f);
        }
        else if (PlayerScoreR == 30)
        {
            panelWin.SetActive(true);
            playerWin.text = "Player R Win!";
            Invoke("ChangeTheScene", 2f);
        }
    }

    public void ChangeTheScene()
    {
        //this.gameObject.SendMessage("ChangeTheScene", "Menu");
        sm.ChangeScene("Menu");
    }

}
