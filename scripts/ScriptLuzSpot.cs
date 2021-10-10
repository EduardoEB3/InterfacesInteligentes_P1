using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLuzSpot : MonoBehaviour
{
  public GameObject luz;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (luz == null) {
      luz = GameObject.FindWithTag("LuzSpot");
    }
    Debug.Log("ID: 14," + " Nombre del objeto: " + luz.name + ", Tag: " + luz.tag + ", Contador: " + contador);
    contador++;
  }

}
