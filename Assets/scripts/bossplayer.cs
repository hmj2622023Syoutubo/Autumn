using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class bossplayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(-0.02f, 0, 0);
            }
            else
            {
                transform.Translate(-0.01f, 0, 0);
            }
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0.02f, 0, 0);
            }
            else
            {
                transform.Translate(0.01f, 0, 0);
            }
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0, 0.02f, 0);
            }
            else
            {
                transform.Translate(0, 0.01f, 0);
            }
        }
        if (Keyboard.current.downArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0, -0.02f, 0);
            }
            else
            {
                transform.Translate(0, -0.01f, 0);
            }
        }
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("kabotya"))
        {


            SceneManager.LoadScene("GameOver");
        }
    }
}
