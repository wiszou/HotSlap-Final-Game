using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class BGMusic : MonoBehaviour
{
    public static BGMusic bgMusic;
    public AudioSource audioSource;
 
    void Awake()
    {
        
        if (bgMusic == null)
        {
            bgMusic = this;
            DontDestroyOnLoad(bgMusic);
            SceneManager.sceneLoaded += OnSceneLoaded;
        }
        else
        {
            audioSource.Stop();
            Destroy(gameObject);
        }
    }
    
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        switch (scene.name)
        {
            case "2Player":
            case "3Player":
            case "4Player":
            case "5Player":
            case "6Player":
                audioSource.Stop();
                Destroy(gameObject);
                break;
        }
    }
}