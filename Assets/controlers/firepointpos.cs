using UnityEngine;

public class firepointpos : MonoBehaviour
{
    public PlayerMovement playerControlerRef;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControlerRef.lookRight==true)
            transform.localPosition = new Vector3(2.5f, 2f, 0f);
        else 
            transform.localPosition = new Vector3(-2.5f, 2f, 0f);
    }
}
