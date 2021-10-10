using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPalmera : MonoBehaviour
{
  public GameObject palmera;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (palmera == null) {
      palmera = GameObject.FindWithTag("Palmera");
    }
    Debug.Log("ID: 5," + " Nombre del objeto: " + palmera.name + ", Tag: " + palmera.tag + ", Contador: " + contador);
    contador++;
  }
}
