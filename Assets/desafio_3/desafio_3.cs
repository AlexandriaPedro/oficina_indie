using UnityEngine;

public class desafio_3 : MonoBehaviour
{
    public string letra;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
        {
            Debug.Log(letra + " é uma vogal.");
        } else
        {
            Debug.Log(letra + " é uma consoante.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
