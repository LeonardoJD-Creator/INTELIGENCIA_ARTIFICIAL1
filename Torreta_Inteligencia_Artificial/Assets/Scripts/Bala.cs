using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
   //Variable Creada Para la Velocidad de la Bala 
   //Public es para que el código sea visible
   //Float es la marca de que es una Variable  
   //5.0F Es la Velocidad de la Bala
   public float speed = 1.0f;  
   // Start is called before the first frame update
   //Los Códigos de aquí se comenzaran a cargar desde el primer Frame 
   void Start()
   {
        
   }

   //Los Códigos de aquí se estarán ejecutando continuamente con cada Frame 
   // Update is called once per frame
   void Update()
   {   
        //Transform es para llamar la acción de transformar x objeto que se sitúa en el inspector de Unity
        //Lo de las Coordenadas, Tamaño y Rotación
        transform.Translate(Vector3.forward * Time.deltaTime * speed); 
   }
    
   private void OnTriggerEnter(Collider Obj)
   { 
       //If es un condicionante, si sucede x cosa va a pasar x reacción, en caso contrario sucederá otra x cosa
       if (Obj.CompareTag("Player")) 
       {
           Debug.Log("Impacto con el Jugador");
           Destroy(this.gameObject);
       }
    }
}