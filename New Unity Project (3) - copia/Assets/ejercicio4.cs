using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ejercicio4 : MonoBehaviour {
	public Text respuesta;
	public Slider SlA;
	int A,resultadoParcial;


	public void tablaMultiplicar(){
		A = (int)SlA.value;
		respuesta.text = "resultado";
		for(int indice=0;indice<=10;indice++){
			resultadoParcial = A * indice;
			respuesta.text += "" + "\n" + A + "*" + indice + "=" + resultadoParcial;

		}
	}




			// Use this for initialization
			void Start () {

			}

			// Update is called once per frame
			void Update () {

			}
		}
