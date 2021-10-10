using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptParking : MonoBehaviour
{
  public GameObject parking;
  int contador = 0;
  // Start is called before the first frame update
  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    if (parking == null) {
      parking = GameObject.FindWithTag("BarreraParking");
    }
    Debug.Log("ID: 1," + " Nombre del objeto: " + parking.name + ", Tag: " + parking.tag + ", Contador: " + contador);
    contador++;
  }
}
