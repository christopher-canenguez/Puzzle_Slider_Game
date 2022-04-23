using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text movesMade;
    public TMP_Text endMovesText;

    public GameObject player;

    public GameObject winPanel;
    public GameObject empty_star1;
    public GameObject empty_star2;

    public int currentMoves = 0;
    public int threeStarMoves = 0;
    public int twoStarMoves = 0;

    public static GameManager Instance;

    public GameState gameState;

    public static event Action<GameState> OnGameStateChanged;

    private void Awake()
    {
        Instance = this;
    } // End method.

    void Start()
    {
        UpdateGameState(GameState.Playing);
    } // End method.

    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.Playing:
                gameState = newState;
                HandlePlayingGame();
                break;
            case GameState.WinLevel:
                gameState = newState;
                HandlePlayingGame();
                break;
        } // End switch.

        OnGameStateChanged?.Invoke(newState);

    } // End method.

    private void HandlePlayingGame()
    {
        if (player.activeSelf == false)
        {
            UpdateGameState(GameState.WinLevel);
        } // End if.
    } // End method.

    private void HandleWinLevel()
    {
        winPanel.SetActive(true);

        if (currentMoves <= threeStarMoves)
        {

        } // End if.

        if (currentMoves > threeStarMoves && currentMoves <= twoStarMoves)
        {

        } // End if.

        if (currentMoves > twoStarMoves)
        {

        } // End if.
    } // End method.

    void Update()
    {
        if (player.activeSelf == false)
        {
            winPanel.SetActive(true);

            if (currentMoves > threeStarMoves && currentMoves <= twoStarMoves)
            {
                empty_star2.SetActive(true);
            } // End if.

            if (currentMoves > twoStarMoves)
            {
                empty_star1.SetActive(true);
                empty_star2.SetActive(true);
            } // End if.
        }
    }

    private void FixedUpdate()
    {
        movesMade.SetText("Current" + "\n" +
                          "Moves:" + "\n" +
                          currentMoves);

        endMovesText.SetText("Moves: " + currentMoves);

    } // End method.

    public enum GameState
    {
        Playing,
        WinLevel
    } // End enum.

}