using System;
using UnityEngine;
using UnityEngine.UI;

public class desafio_8 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public InputField nome_jogador_1;
    public InputField numero_jogador_1;
    public InputField par_ou_impar_jogador_1;

    public Text nome_jogador_2;
    public Text numero_jogador_2;

    public Text texto_vencedor;

    public void jogar()
    {
        string nome_j1 = nome_jogador_1.text;
        int numero_j1 = int.Parse(numero_jogador_1.text);
        string par_ou_impar_j_1 = par_ou_impar_jogador_1.text;

        String nome_j2 = nome_jogador_2.text;
        int numero_j_2 = UnityEngine.Random.Range(0,6);
        numero_jogador_2.text = numero_j_2.ToString();

        int soma = numero_j1 + numero_j_2;

        if (soma % 2 == 0 && par_ou_impar_j_1 == "par")
        {
            texto_vencedor.text = soma + " é um número par, portanto " + nome_j1 + " venceu!";
        } 
        else if (soma % 2 != 0 && par_ou_impar_j_1 == "ímpar")
        {
            texto_vencedor.text = soma + " é um número ímpar, portanto " + nome_j1 + " venceu!";
        }
        else if (soma % 2 == 0 && par_ou_impar_j_1 == "ímpar")
        {
            texto_vencedor.text = soma + " é um número par, portanto " + nome_j2 + " venceu!";
        }
        else if (soma % 2 != 0 && par_ou_impar_j_1 == "par")
        {
            texto_vencedor.text = soma + " é um número ímpar, portanto " + nome_j2 + " venceu!";
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
