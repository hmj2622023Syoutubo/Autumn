using UnityEngine;
using UnityEngine.UI;


public class Gamemanager : MonoBehaviour
{
    GameObject hpgauge;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.hpgauge = GameObject.Find("hpgauge");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecreaseHp()
    {
        this.hpgauge.GetComponent<Image>().fillAmount -= 0.2f;
    }
}
