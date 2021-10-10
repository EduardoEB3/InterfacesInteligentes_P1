using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptCamara : MonoBehaviour
{
  public GameObject camara;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (camara == null) {
      camara = GameObject.FindWithTag("MainCamera");
    }
    Debug.Log("ID: 12," + " Nombre del objeto: " + camara.name + ", Tag: " + camara.tag + ", Contador: " + contador);
    contador++;
  }
}
