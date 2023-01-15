using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class NameHandler : MonoBehaviour
{
    public TMP_InputField player1Input;
    public TMP_InputField player2Input;
    public TMP_InputField player3Input;
    public TMP_InputField player4Input;
    public TMP_InputField player5Input;
    public TMP_InputField player6Input;
    public TMP_InputField playerHealth;
    
    public static int playerHP;
    public static int winner;
    public static List<string> playerNames;

    void Awake()
    {
        // Make this GameObject and the player name variables persist between scene changes
        DontDestroyOnLoad(gameObject);
    }
    
    void Start()
    {
        
        playerNames = new List<string>();
       
    }

        public void OnEndEditHp()
    {
        playerHP = int.Parse(playerHealth.text);
        Debug.Log("Player's health input: " + playerHealth.text);
    }

        public void OnEndEditPlayer1(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
        
    }

    public void OnEndEditPlayer2(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
    }

    public void OnEndEditPlayer3(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
    }

     public void OnEndEditPlayer4(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
    }

     public void OnEndEditPlayer5(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
    }

     public void OnEndEditPlayer6(string name)
    {
        playerNames.Add(name);
        Debug.Log("Added name to playerNames list: " + name);
    }

}
