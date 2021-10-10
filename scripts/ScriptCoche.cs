using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCoche : MonoBehaviour
{
  public GameObject coche;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {     
  }

  // Update is called once per frame
  void Update()
  {
    if (coche == null) {
      coche = GameObject.FindWithTag("Coche");
    }
    Debug.Log("ID: 2," + " Nombre del objeto: " + coche.name + ", Tag: " + coche.tag + ", Contador: " + contador);
    contador++;
  }
}
