using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTerreno : MonoBehaviour
{
  public GameObject terreno;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {      
  }

  // Update is called once per frame
  void Update()
  {
    if (terreno == null) {
      terreno = GameObject.FindWithTag("Terreno");
    }
    Debug.Log("ID: 6," + " Nombre del objeto: " + terreno.name + ", Tag: " + terreno.tag + ", Contador: " + contador);
    contador++;
  }
}
