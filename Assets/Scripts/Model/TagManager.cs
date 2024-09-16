using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagManager : MonoBehaviour
{
    #region Outcome Types
    public const string TOTAL_SUCCESS_TYPE = "Total_Success";
    public const string PARTIAL_SUCCESS_TYPE = "Partial_Success";
    public const string FAILURE_TYPE = "Failure";
    #endregion

    #region Layers
    public const string GAME_NODE_LAYER = "Game_Node";
    public const string FINAL_NODE_LAYER = "Final_Game_Node";
    #endregion

    #region Tags
    
    public const string PLAYER_TAG = "Player";
    public const string OXYGEN_LEVEL_UI_TAG = "Oxygen_Level_UI";
    public const string HEALTH_LEVEL_UI_TAG = "Health_Level_UI";
    public const string PARTIAL_SUCCESS_CARDS_COUNT_TAG = "Partial_Success_Cards_Count";
    public const string FAILURE_CARDS_COUNT_TAG = "Failure_Cards_Count";
    public const string BATTLE_OUTCOMES_CONTROLLER_TAG = "Battle_Outcomes_Controller";
    

    #endregion

    #region Scenes
    public const string MAIN_MENU_SCENE = "Main_Menu_Scene";
    public const string WIN_SCENE = "Win_Scene";
    public const string CREDITS_SCENE = "Credits_Scene";
    public const string GAME_OVER_SCENE = "Game_Over_Scene";
    #endregion
}
