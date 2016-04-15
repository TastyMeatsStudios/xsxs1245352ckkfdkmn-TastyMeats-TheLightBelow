/*
using UnityEngine;
using System.Collections;

using System.Collections.Generic; // Allows us to use lists

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null; // Static instance of GameManager that allows it to be accessed by other scripts
    private LevelManager levelScript; // Stores a referance to our levelmnager which sets the level up
    
    // Awake is called before any start functions
    void Awake()
    {
        // check if instance already exists
        if (instance == null)
        {
            instance = this;
        }
        // if instance already exists but isnt 'this'
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        // Get a component referance to the attacked levelmanager script
        levelScript = GetComponent<LevelManager>();

        // Call the initgame function to initialize the first level
        InitializeGame();
    }

    // Initializes the game for each level
    void InitializeGame()
    {
        // Call the SetupScene function of the Levelmanager script
        levelScript.SetupScene(level);
    }
}
*/