using Unity.VisualScripting;
using UnityEngine;

public class kabotyayoko : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( 0.01f, 0,0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("boss"))
        { 
        GameObject Manager = GameObject.Find("Gamemanager");
        Manager.GetComponent<Gamemanager>().DecreaseHp();
        }
        Destroy(gameObject);
    }
}
