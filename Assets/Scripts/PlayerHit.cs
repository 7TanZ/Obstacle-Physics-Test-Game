using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private int HitCount = 1;
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("PlayerHit OnCollisionEnter with " + collision.gameObject.name);
        Debug.Log("Player has collieded " + HitCount + " times");
        HitCount += 1;

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            ChangeColor(collision.gameObject, Color.black);
        }
        //Transform transform = collision.transform;
        //transform.localScale = Vector3.one;

    }
    private void ChangeColor(GameObject gameObject, Color color)
        {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        Material material = meshRenderer.material;
        material.color = color;
    }
}
