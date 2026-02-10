using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] float PlayerSpeed = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   

    void Start()
    {
        Welcome();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void Welcome()
    {
        Debug.Log("Welcome to the game Project Q");
        Debug.Log("Use WASD or Arrow keys to move the player");
    }
    void MovePlayer()
    {
        float ValueX = Input.GetAxis("Horizontal") * PlayerSpeed * Time.deltaTime;
        float ValueY = 0;
        float ValueZ = Input.GetAxis("Vertical") * PlayerSpeed * Time.deltaTime;
        transform.Translate(ValueX, ValueY, ValueZ);
    }
}

