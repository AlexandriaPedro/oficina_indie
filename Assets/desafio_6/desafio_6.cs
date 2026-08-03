using UnityEngine;

public class desafio_6 : MonoBehaviour
{
    public int xis, ypsilon, ze;

    bool MaiorQueMil(int x, int y, int z)
    {
        int total =  (x + y) * z;

        if (total > 1000) {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(MaiorQueMil(xis, ypsilon, ze));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
