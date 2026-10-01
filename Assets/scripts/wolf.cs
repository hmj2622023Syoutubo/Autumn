using UnityEngine;

public class wolf : MonoBehaviour
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
        Debug.Log("totta");
        Witch.GetComponent<witch>().wolf(true);
        textMeshPro.SetActive(true);
    }
}
