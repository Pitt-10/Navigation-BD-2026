using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPT : MonoBehaviour
{
    private string[] jugadas = {"Roca", "Papel", "Tijera"};

    private void Start() { 
        
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            CheckResult("Roca");
        } else if (Input.GetKeyDown(KeyCode.P)) {
            CheckResult("Papel");
        } else if (Input.GetKeyDown(KeyCode.T)) {
            CheckResult("Tijera");
        }
    }

    private void CheckResult(string jugada) {
        string jugadaContrincante = jugadas[Random.Range(0, 3)];
        Debug.Log("Jugaste " + jugada + ", el contrinancte jugó " + jugadaContrincante);

        if (jugada == "Roca") {
            if (jugadaContrincante == "Roca") {
                Debug.Log("Empate");
            } else if (jugadaContrincante == "Tijera") {
                Debug.Log("Ganaste");
            } else {
                Debug.Log("Perdiste");
            }
        } else if (jugada == "Papel") {
            if (jugadaContrincante == "Papel") {
                Debug.Log("Empate");
            } else if (jugadaContrincante == "Roca") {
                Debug.Log("Ganaste");
            } else {
                Debug.Log("Perdiste");
            }
        } else if (jugada == "Tijera") {
            if (jugadaContrincante == "Tijera") {
                Debug.Log("Empate");
            } else if (jugadaContrincante == "Papel") {
                Debug.Log("Ganaste");
            } else {
                Debug.Log("Perdiste");
            }
        }
    }
}
