using UnityEngine;

public class mummycontroller : MonoBehaviour
{
    float Speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Speed, 0);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Speed *= -1;
    }
}
