using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SceneManager.LoadScene("select level", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
