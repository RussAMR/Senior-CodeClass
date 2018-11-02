using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    float timeLeft = 30.0f;
    static GameManager instance;
    public Player_Scrpt MyCharacter
    { get; set; }
    public static GameManager Instance
    {
        get { return instance ?? ((instance = new GameManager())); }
    }
    private GameManager()
    {
        Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
    }
    private void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0)
        {
        }
    }
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }

}
