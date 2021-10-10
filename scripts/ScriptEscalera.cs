using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEscalera : MonoBehaviour
{
  public GameObject escalera;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {     
  }

  // Update is called once per frame
  void Update()
  {
    if (escalera == null) {
      escalera = GameObject.FindWithTag("Escalera");
    }
    Debug.Log("ID: 3," + " Nombre del objeto: " + escalera.name + ", Tag: " + escalera.tag + ", Contador: " + contador);
    contador++;
  }
}
