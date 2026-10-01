using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.02f, 0, 0);
        if(transform.position.x < -21.1f)
        {
            transform.position = new Vector3(21.1f, 1, 0);
        }
    }
}
