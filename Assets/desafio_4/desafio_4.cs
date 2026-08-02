using UnityEngine;

public class desafio_4 : MonoBehaviour
{
    public int lado_a, lado_b, lado_c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (lado_a == lado_b && lado_b == lado_c)
        {
            Debug.Log("Seu triângulo é Equilátero");
        }
        else if (lado_a != lado_b && lado_a != lado_c && lado_b != lado_c)
        {
            Debug.Log("Seu triângulo é Escaleno");
        }
        else
        {
            Debug.Log("Seu triângulo é Isósceles");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
