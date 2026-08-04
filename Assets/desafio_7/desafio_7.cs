using UnityEngine;
using UnityEngine.Video;

public class desafio_7 : MonoBehaviour
{
    public int quant_rec = 0;
    public int clic_rec = 1;

    public void click_button()
    {
        quant_rec += clic_rec;

        Debug.Log("Você tem " + quant_rec + " de recurso.");
    }

    public void click_upgrade(int custo)
    {
        if (quant_rec < custo)
        {
            Debug.Log("Você não tem a quantidade de recurso para fazer o upgrade.");
        } else
        {
            quant_rec -= custo;

            clic_rec += custo / 10;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
