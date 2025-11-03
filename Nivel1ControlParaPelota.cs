using System.ComponentModel;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Nivel1ControlParaPelota : MonoBehaviour
{

    private Rigidbody rb;
    private int Velocidad = 2;
    public Text TextoPuntos;
    public Text TextoVictoria;
    private int contador = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        contador = 0;
        TextoVictoria.text = "";
        seteartxt();
    }

    private void seteartxt()
    {

        TextoPuntos.text = "Puntos: " + contador.ToString();

        if (contador >= 5)
        {
            TextoVictoria.text = "Victoria";
        }

    }

    void FixedUpdate()
    {

        float movimientoHoriontal = Input.GetAxis("Horizontal");

        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 vectorMovimiento = new Vector3(movimientoHoriontal, 0, movimientoVertical);

        rb.AddForce(vectorMovimiento * Velocidad);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coleccionable") == true) {
            other.gameObject.SetActive(false);

            contador++;
            seteartxt();

        }
    }
}
