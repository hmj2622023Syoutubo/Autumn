using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Sprite[] walkSprites;
    float time = 0;
    int left = 0;
    int right = 2;
    int up = 4;
    int down = 6;
    SpriteRenderer spriteRenderer;
    
    static float positionX = 0;
    static float positionY = -4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.spriteRenderer = GetComponent<SpriteRenderer>();

        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "HomeScene")
        {
            transform.position = new Vector3(positionX, positionY, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ¶–îˆó‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
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
            this.time += Time.deltaTime;
            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[left];
                this.left = 1 - left;
            }
        }

        // ‰E–îˆó‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0.02f, 0, 0);
            }
            else
            {
                transform.Translate(0.01f, 0, 0);
            }
            this.time += Time.deltaTime;
            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[right];
                this.right = 5 - right;
            }
        }

        // ã–îˆó‚ª‰Ÿ‚³‚ê‚½Žž
        else if (Keyboard.current.upArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0, 0.02f, 0);
            }
            else
            {
                transform.Translate(0, 0.01f, 0);
            }
            this.time += Time.deltaTime;
            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[up];
                this.up = 9 - up;
            }
        }

        // ‰º–îˆó‚ª‰Ÿ‚³‚ê‚½Žž
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                transform.Translate(0, -0.02f, 0);
            }
            else
            {
                transform.Translate(0, -0.01f, 0);
            }
            this.time += Time.deltaTime;
            if (this.time > 0.1f)
            {
                this.time = 0;
                this.spriteRenderer.sprite = this.walkSprites[down];
                this.down = 13 - down;
            }
        }

        string currentSceneName = SceneManager.GetActiveScene().name;
        if (currentSceneName == "WolfScene")
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                if (Keyboard.current.leftArrowKey.isPressed && Keyboard.current.rightArrowKey.isPressed && Keyboard.current.upArrowKey.isPressed && Keyboard.current.downArrowKey.isPressed)
                {
                    SceneManager.LoadScene("WolfOverScene");
                }
            }

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ie"))
        {
            SceneManager.LoadScene("HomeScene");
        }
        if(collision.gameObject.CompareTag("wolf"))
        {
            positionX = transform.position.x - 0.1f;
            positionY = transform.position.y;
            SceneManager.LoadScene("WolfScene");
        }
        if(collision.gameObject.CompareTag("mamy"))
        {
            positionX = transform.position.x + 0.1f;
            positionY = transform.position.y;
            SceneManager.LoadScene("MummyScene");
        }
        if(collision.gameObject.CompareTag("banana"))
        {
            SceneManager.LoadScene("WolfOverScene");
        }
        if(collision.gameObject.CompareTag("witchroom"))
        {
            SceneManager.LoadScene("HomeScene");
        }
        if(collision.gameObject.CompareTag("houki"))
        {
            
            SceneManager.LoadScene("ClearScene");
        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("mummy"))
        {
            SceneManager.LoadScene("MummyOverScene");
        }
    }
}
