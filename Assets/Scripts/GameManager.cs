using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    Player player;
    bool isGameOver, isWin;
    int totalSuccessCount, partialSuccessCount, failureCount;
    BattleOutcomesController battleOutcomesController;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public bool IsGameOver { get => isGameOver; set => isGameOver = value; }
    public bool IsWin { get => isWin; set => isWin = value; }
    public int TotalSuccessCount { get => totalSuccessCount; set => totalSuccessCount = value; }
    public int PartialSuccessCount { get => partialSuccessCount; set => partialSuccessCount = value; }
    public int FailureCount { get => failureCount; set => failureCount = value; }
    public Player Player { get => player; set => player = value; }

    private void Awake()
    {
        if (instance != null) Destroy(this);
        else instance = this;
    }

    private void Start()
    {
        player = GameObject.FindWithTag("Player").GetComponent<Player>();
        battleOutcomesController = GameObject.FindWithTag("Battle_Outcomes_Controller").GetComponent<BattleOutcomesController>();
    }

    private void Update()
    {
        CheckWin();
        CheckDefeat();
        HandleOutcomesCardsSorting();
    }

    void CheckWin()
    {
        if (isWin) SceneManager.LoadScene(TagManager.WIN_SCENE);
    }

    void CheckDefeat()
    {
        if (player.Oxygen <= 0 || player.Health <= 0) SceneManager.LoadScene(TagManager.GAME_OVER_SCENE);
    }

    void HandleOutcomesCardsSorting()
    {
        if (battleOutcomesController != null && battleOutcomesController.BattleOutcomesList.Count == 0) battleOutcomesController.SortBattleCards();
    }
}
