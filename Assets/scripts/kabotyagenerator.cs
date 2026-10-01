using UnityEngine;

public class kabotyagenerator : MonoBehaviour
{
    [SerializeField] GameObject kabotya;
    [SerializeField] GameObject kabotyayoko;
    float span = 2;
    float delta = 0;
    int num = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            num++;
            GameObject go = Instantiate(kabotya);
            GameObject item = Instantiate(kabotyayoko);
            int px = Random.Range(-8, 8);
            go.transform.position = new Vector3(px, 6, 0);
            if(num % 5 ==0)
            {
                item.transform.position = new Vector3(-10, 0, 0);
            }
        }
     
    }
}
