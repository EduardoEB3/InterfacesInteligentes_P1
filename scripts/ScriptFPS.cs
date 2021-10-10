using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptFPS : MonoBehaviour
{
  public GameObject fps;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (fps == null) {
      fps = GameObject.FindWithTag("FPS");
    }
    Debug.Log("ID: 15," + " Nombre del objeto: " + fps.name + ", Tag: " + fps.tag + ", Contador: " + contador);
    contador++;
  }
}
