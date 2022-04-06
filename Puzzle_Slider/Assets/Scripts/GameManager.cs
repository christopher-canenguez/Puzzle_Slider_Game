using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text movesMade;
    public GameObject winBanner;
    public GameObject loadNextLevel;
    public GameObject restartLevel;

    public int currentMoves = 0;
    public int threeStarMoves = 0;
    public int twoStarMoves = 0;

    public static GameManager Instance;

    public GameState gameState;

    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    }

    private void FixedUpdate()
    {
        movesMade.SetText("Moves:" + " \n" 
                         + currentMoves + "\n" 
                         + "Record:" + "\n"
                         + "--");
    }

    public enum GameState
    {
        Idle,
        Playing,
        WinLevel
    }

}
