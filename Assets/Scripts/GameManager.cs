using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class KeyValuePair
{
    public string key; public GameObject value;
}

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    Player player;
    bool isGameOver, isWin, isWinUnderCriticalConditions;
    int totalSuccessCount, partialSuccessCount, failureCount;
    BattleOutcomesController battleOutcomesController;
    int exploredNodesCount;

    [SerializeField] List<KeyValuePair> eventCardKeyValuePairs = new List<KeyValuePair>();
    Dictionary<string, GameObject> eventCardDictionary = new Dictionary<string, GameObject>();
     
    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    public bool IsGameOver { get => isGameOver; set => isGameOver = value; }
    public bool IsWin { get => isWin; set => isWin = value; }
    public bool IsWinUnderCriticalConditions { get => isWinUnderCriticalConditions; set => isWinUnderCriticalConditions = value; }
    public int TotalSuccessCount { get => totalSuccessCount; set => totalSuccessCount = value; }
    public int PartialSuccessCount { get => partialSuccessCount; set => partialSuccessCount = value; }
    public int FailureCount { get => failureCount; set => failureCount = value; }
    public Player Player { get => player; set => player = value; }
    public int ExploredNodesCount { get => exploredNodesCount; set => exploredNodesCount = value; }

    private void Awake()
    {
        if (instance != null) Destroy(this);
        else instance = this;
    }

    private void OnValidate()
    {
        foreach (var kvp in eventCardKeyValuePairs)
        {
            eventCardDictionary[kvp.key] = kvp.value;
        }
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
        Debug.Log("Outcomes count: " + battleOutcomesController.BattleOutcomesList.Count);
        HandleOutcomesCardsSorting();
    }

    void CheckWin()
    {
        if (isWin) SceneManager.LoadScene(TagManager.WIN_SCENE);
    }

    void CheckDefeat()
    {
        if (player.Oxygen <= 0 || player.Health <= 0) CheckForCollisionWithFinalNode();
    }

    void HandleOutcomesCardsSorting()
    {
        if (battleOutcomesController && battleOutcomesController.BattleOutcomesList.Count <= 0) battleOutcomesController.SortBattleCards();
    }

    void CheckForCollisionWithFinalNode()
    {
        if(!isWinUnderCriticalConditions)
            SceneManager.LoadScene(TagManager.GAME_OVER_SCENE);
    }

}
