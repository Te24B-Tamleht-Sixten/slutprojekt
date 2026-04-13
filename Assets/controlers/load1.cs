using UnityEngine;
using UnityEngine.SceneManagement;

public class load1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Debug.Log("CKICJA");
        SceneManager.LoadScene("level1", LoadSceneMode.Single);
    }
}
