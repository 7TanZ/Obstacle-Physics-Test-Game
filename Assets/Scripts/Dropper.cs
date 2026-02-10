using UnityEngine;

public class Dropper : MonoBehaviour
{
    public int Timer = 3;
    private Rigidbody Rb;


    private void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Debug.Log(Time.time);
        //define var that can -> time value
        //if(Time.time > Timer) -> use Gravity
        if(Time.time > Timer)
        {
            Rb.useGravity=true;
        }
    }
}
