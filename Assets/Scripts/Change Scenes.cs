using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.IO.Ports;

// https://www.youtube.com/watch?v=jrPTpD2eAMw

public class ChangeScenes : MonoBehaviour
{
    // public static SceneManager Instance;
    public string sceneName;
    public AudioSource clip;
    string currentScene;

    public AudioSource mushroom1, mushroom2, sword; 
    public float delayTime = 5f;
    public bool canEnchant = false;
    public bool canFight = false;
    public bool canFairy = true;
    public bool canWisp = true;
    public GameObject player;
    
    // private void Awake()
    // {
    //     // access class and manager from this Instance 
    //     Instance = this; 
    // }

    // //constants that cannot change
    // public enum SceneManagement
    // {
    //     // need to have same order as in Build Setting
    //     WelcomeScene,
    //     StartingScene
    // }

    // public void LoadScene(Scene scene)
    // {
    //     SceneManager.LoadScene(scene.ToString());
    // }

    // public void LoadStartScene()
    // {
    //     SceneManager.LoadScene(Scene.StartingScene.ToString());
    // }

    // public void LoadNextScene()
    // {
    //     // going into build scene and loading the next consecutive scene in list
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    // public void LoadWelcomeScene()
    // {
    //     SceneManager.LoadScene(Scene.WelcomeScene.ToString());
    // }
    void Update()
    {
        // changeScene();
        pathofWisps();
        fairyTown();
        enchantedWoods();
        crystalCave();
        startingScene();
    }
    
    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
        if(Input.GetKey(KeyCode.KeypadEnter) || Input.GetKeyDown("Enter"))
        {
            SceneManager.LoadScene("Starting scene");
            currentScene = "Starting Scene";
            clip.Play();
        }
    }

    void OnConnectionEvent(bool received)
    {
        print(received);
    }
    void OnMessageArrived(string message)
    {
        print(message);

        if(message == "Fairy Town is pressed" && canFairy == true)
        {
            mushroom2.Play();
            SceneManager.LoadScene("Fairy Town");
            canFairy = false;
            canWisp = false;
        }
        if(message == "Path of Wisps is pressed" && canWisp == true)
        {
            mushroom1.Play();
            SceneManager.LoadScene("Path of the Wisps");
            canWisp = false;
            canFairy = false;

            // StartCoroutine(wispCoroutine());
        }
        
        if(message == "No lantern!" && canEnchant == true)
        {
            SceneManager.LoadScene("Enchanted Woods");
            canEnchant = false;
            canWisp = false;
            canFairy = false;
        }

        
        if(message == "No Magnet :(" && canFight == true)
        {
            sword.Play();
            SceneManager.LoadScene("Crystal Cave");
            canEnchant = false;
            canFairy = false;
            canWisp = false;
            canFight = false;
        }
    }

    void OnTriggerEnter (Collider player)
    {
        Debug.Log("entering");
        changeScene();
    }

    public void pathofWisps()
    {
        if(Input.GetKeyDown("1"))
        {
            mushroom1.Play();
            SceneManager.LoadScene("Path of the Wisps");
            currentScene = "Path of the Wisps";
        }
    }
    public void fairyTown()
    {
        if(Input.GetKeyDown("2"))
        {
            mushroom2.Play();
            SceneManager.LoadScene("Fairy Town");
            currentScene = "Fairy Town";
        }
    }
    public void enchantedWoods()
    {
        if(Input.GetKeyDown("3"))
        {
            SceneManager.LoadScene("Enchanted Woods");
            currentScene = "Enchanted Woods";
        }
    }
    public void crystalCave()
    {
        if(Input.GetKeyDown("4"))
        {
            Debug.Log("key 4 is pressed");
            sword.Play();
            SceneManager.LoadScene("Crystal Cave");
            currentScene = "Crystal Cave";
        }
    }

    public void startingScene()
    {
        if(Input.GetKeyDown("5"))
        {
            SceneManager.LoadScene("Starting Scene");
            currentScene = "Starting Scene";
        }
    }
}
