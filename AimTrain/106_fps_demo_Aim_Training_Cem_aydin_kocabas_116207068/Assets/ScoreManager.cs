using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text IHits;
    public Text IMisses;

    int Hits = 0;
    int Misses = 0;

    public void Awake()
    {
        instance = this;
    }   
    void Start()
    {
        IHits.text = "Hits: " + Hits.ToString();
        IMisses.text = "Misses: " + Misses.ToString();
    }
    public void AddPointToHits()
    {
        Hits += 1;
        IHits.text = "Hits: " + Hits.ToString();
    }
    public void AddPointToMisses()
    {
        Misses += 1;
        IMisses.text = "Misses: " + Misses.ToString();
        Debug.Log(Misses);
        if ( Misses == 5 )
        {
            QuitScript.instance.QuitGame();
        }
    }
    
}
