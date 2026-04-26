using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 7f;

    void Update()
    {
        float movimientoX = Input.GetAxis("Horizontal");

        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);

            if (toque.position.x < Screen.width / 2)
            {
                movimientoX = -1f;
            }
            else if (toque.position.x > Screen.width / 2)
            {
                movimientoX = 1f;
            }
        }

        transform.Translate(new Vector3(movimientoX, 0, 0) * velocidad * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        Debug.Log("moneda");
    }
}