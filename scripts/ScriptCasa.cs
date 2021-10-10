using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCasa : MonoBehaviour
{
  public GameObject casa;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (casa == null) {
      casa = GameObject.FindWithTag("Casa");
    }
    Debug.Log("ID: 4," + " Nombre del objeto: " + casa.name + ", Tag: " + casa.tag + ", Contador: " + contador);
    contador++;
  }
}