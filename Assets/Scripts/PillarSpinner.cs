using UnityEngine;

public class PillarSpinner : MonoBehaviour
{
    public  Vector3 rotateAngles;
    private void Update()
    {
        transform.Rotate(rotateAngles);
    }
}
