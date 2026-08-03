using UnityEngine;

public class desafio_5 : MonoBehaviour
{
    public string jogador_1;
    public string jogador_2;

    public int mao_jogador_1;
    public int mao_jogador_2;

    public bool jogador_1_par;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int soma = mao_jogador_1 + mao_jogador_2;

        if (soma % 2 == 0)
        {
            if (jogador_1_par)
            {
                Debug.Log(soma + " é um número par, portanto " + jogador_1 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um número par, portanto " + jogador_2 + " venceu!");
            }
        }
        else
        {
            if (jogador_1_par)
            {
                Debug.Log(soma + " é um número ímpar, portanto " + jogador_2 + " venceu!");
            }
            else
            {
                Debug.Log(soma + " é um número ímpar, portanto " + jogador_1 + " venceu!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
