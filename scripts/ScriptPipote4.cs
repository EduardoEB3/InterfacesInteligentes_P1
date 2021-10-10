using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPipote4 : MonoBehaviour
{
  public GameObject pipote;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (pipote == null) {
      pipote = GameObject.FindWithTag("Pipote3");
    }
    Debug.Log("ID: 10," + " Nombre del objeto: " + pipote.name + ", Tag: " + pipote.tag + ", Contador: " + contador);
    contador++;
  }
}
