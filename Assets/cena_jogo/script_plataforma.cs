using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_plataforma : MonoBehaviour
{

    private float count = 0;
    public float velocidade = 3;
    private Vector2 posInicial;
    public float altura = 1;
    public float largura = 1;

    void Start()
    {
        posInicial = transform.position;
    }
    
    void Update()
    {
        count += velocidade * Time.deltaTime;

        float posX = Mathf.Cos(count) * largura;
        float posY = Mathf.Sin(count) * altura;
        Vector2 posAtual = new Vector2(posX,posY);

        transform.position = posInicial + posAtual;

        if (count >= 2 * Mathf.PI){
            count = 0;
        }
    }
}
