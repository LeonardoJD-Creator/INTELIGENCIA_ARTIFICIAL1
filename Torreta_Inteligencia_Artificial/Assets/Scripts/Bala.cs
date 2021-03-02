using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    //Variable Creada Para la Velocidad de la Bala
    //Public es para que el codigo sea visible
    //Float es la marca de que es una Variable
    //5.0F Es la velocidad de la Bala
    public float speed = 1.0f;
    //Start is called before the firts frame update
    //Los Codigos de aqui se comenzaran a cargar desde el primer Frame
    void Start()
    {

    }

    //Los codigos de aqui se estaran ejecutando continuamente con cada Frame
    // Update is called once per frame
    void Update()
    {
        //Transform es para llamar la accion de transformar x objeto que se situa en el inspector de Unity
        //Lo de las Coordenadas, Tamaño, Rotacion
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider obj)
    {
        //If es un condicionante, si sucede x cosa va a pasar x reaccion, en caso contrario sucedera otra x cosa
        if (obj.CompareTag("Player"))
        {
            Debug.Log("Impacto con el jugador");
            Destroy(this.gameObject);
        }
    }
}