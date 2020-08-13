using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float playerPosition = 0f;

    // Update is called once per frame
    private void Update() => scoreText.text = playerPosition + player.position.z.ToString();// Debug.Log(player.position.z);
}
