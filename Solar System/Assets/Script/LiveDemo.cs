using UnityEngine;

public class LiveDemo : MonoBehaviour
{

    public float yawDegreesPerSecond = 45f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Debug.Log("Hello Unity World!");
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate a little bit
        Transform myTransform = GetComponent<Transform>();
        myTransform.Rotate(0f, yawDegreesPerSecond * Time.deltaTime, 0f);



        //Debug.Log("Hello Unity World!");
    }
}
