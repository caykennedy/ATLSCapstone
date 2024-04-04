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
        // if(message == "No lantern!" && currentScene != "Enchanted Woods")
        // {
        //     SceneManager.LoadScene("Enchanted Woods");
        //     currentScene = "Enchanted Woods";
        // }
        if(message == "No Magnet :(" && currentScene != "Crystal Cave")
        {
            SceneManager.LoadScene("Crystal Cave");
            currentScene = "Crystal Cave";
        }
    }

    void OnTriggerEnter (Collider player)
    {
        Debug.Log("entering");
        changeScene();
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
