using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadMovimiento = 5f;
    public float velocidadRotacion = 100f;
    public float fuerzaSalto = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float movimientoVertical = Input.GetAxis("Vertical");
        float rotacionHorizontal = Input.GetAxis("Horizontal");

        
        Vector3 movimiento = transform.forward * movimientoVertical * velocidadMovimiento;
        rb.AddForce(movimiento);

      
        transform.Rotate(Vector3.up * rotacionHorizontal * velocidadRotacion * Time.deltaTime);

    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }

    void Saltar()
    {
        rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
    }
}
