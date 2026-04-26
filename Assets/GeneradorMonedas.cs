using UnityEngine;

public class GeneradorMonedas : MonoBehaviour
{
    public GameObject monedaPrefab;
    public float tiempoEntreMonedas = 1.5f;
    public float limiteIzquierdo = -7f;
    public float limiteDerecho = 7f;
    public float alturaAparicion = 6f;

    void Start()
    {
        InvokeRepeating("CrearMoneda", 1f, tiempoEntreMonedas);
    }

    void CrearMoneda()
    {
        float posicionX = Random.Range(limiteIzquierdo, limiteDerecho);
        Vector3 posicionAparicion = new Vector3(posicionX, alturaAparicion, 0);

        GameObject monedaClonada = Instantiate(monedaPrefab, posicionAparicion, Quaternion.identity);

        Destroy(monedaClonada, 5f);
    }
}