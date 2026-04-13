using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    
    private enemySpawnerCContorler spawner;
    private static bool loadedOnce=false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        if(loadedOnce==false)
        {
        SceneManager.LoadScene("select level", LoadSceneMode.Single);
        Debug.Log("set default level");
        loadedOnce=true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        
        // if(spawner.selectedLevel==7)
        if (Keyboard.current.digit1Key.wasPressedThisFrame)
        {
        Debug.Log("loadedscene");
            SceneManager.LoadScene("level1", LoadSceneMode.Single);
        }
        else if (Keyboard.current.digit2Key.wasPressedThisFrame)
        {
        Debug.Log("loadedscene");
            SceneManager.LoadScene("level2", LoadSceneMode.Single);
        }
        else if (Keyboard.current.digit3Key.wasPressedThisFrame)
        {
        Debug.Log("loadedscene");
            SceneManager.LoadScene("level3", LoadSceneMode.Single);
        }
        else if (Keyboard.current.digit4Key.wasPressedThisFrame){
        Debug.Log("loadedscene");
            SceneManager.LoadScene("level4", LoadSceneMode.Single);
        }
        else if (Keyboard.current.digit5Key.wasPressedThisFrame){
            
        Debug.Log("loadedscene");
            SceneManager.LoadScene("level5", LoadSceneMode.Single);
        }
        else if (Keyboard.current.digit6Key.wasPressedThisFrame)
        {
            Debug.Log("tried to load 6");
        
            SceneManager.LoadScene("level6", LoadSceneMode.Single);
        }
        
    }
}
