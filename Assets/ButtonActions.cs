using UnityEngine;

public class ButtonActions : MonoBehaviour
{
    public void OnButtonClicked(string buttonID)
    {
        Debug.Log("Clicked: " + buttonID);
    }
}