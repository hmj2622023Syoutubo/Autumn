using UnityEngine;
using UnityEngine.InputSystem;

public class cameracontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // ã–îˆó‚ª‰Ÿ‚³‚ê‚½Žž
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

        // ‰º–îˆó‚ª‰Ÿ‚³‚ê‚½Žž
        if (Keyboard.current.downArrowKey.isPressed)
        {
            if (transform.position.y > -5)
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
    }
}
