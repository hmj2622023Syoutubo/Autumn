using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class witch : MonoBehaviour
{
    [SerializeField] private GameObject textMeshPro;
    [SerializeField] private GameObject textclear;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    static bool BANFLAG;
    static bool WOLFLAG;
    public void bandage(bool banflag)
    {
        BANFLAG = banflag;
    }
    public void wolf(bool wolflag)
    {
        WOLFLAG = wolflag;
    }
    void Start()
    {
        if(textMeshPro != null)
        {
            textMeshPro.SetActive(false);
            textclear.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (BANFLAG == true && WOLFLAG == true)
        {
            textclear.SetActive(true);
            SceneManager.LoadScene("ClearScene");
        }
        else
        {
            textMeshPro.SetActive(true);
        } 
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        textclear.SetActive(false);
        textMeshPro.SetActive(false);
    }
}

