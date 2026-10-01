using UnityEngine;

public class bandage : MonoBehaviour
{
    [SerializeField] private GameObject textMeshPro;
    [SerializeField] GameObject Witch;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (textMeshPro != null)
        {
            textMeshPro.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Witch.GetComponent<witch>().bandage(true);
        textMeshPro.SetActive(true);
        Destroy(gameObject);
    }
}
