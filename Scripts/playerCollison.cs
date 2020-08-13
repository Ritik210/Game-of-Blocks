using UnityEngine;

public class playerCollison : MonoBehaviour
{
    public PlayersMovement movement; 
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        //Debug.Log(collisionInfo.collider.name);
        if(collisionInfo.collider.tag == "Collidor")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
