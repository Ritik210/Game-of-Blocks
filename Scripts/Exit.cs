using UnityEngine;

public class Exit : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
