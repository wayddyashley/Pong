using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Audio Source
    AudioSource fuenteDeAudio;
    //Clips de audio
    public AudioClip audioInicio;

    void Start(){
        //Recupero el componente audio source;
        fuenteDeAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si pulsa la tecla P o hace clic izquierdo empieza el juego
        if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
            //Cargo la escena de Juego
            // Nombre de la scene del juego, en mi caso es Juego
            SceneManager.LoadScene("Juego");
            //Reproduzco el sonido de la raqueta
            fuenteDeAudio.clip = audioInicio;
            fuenteDeAudio.Play();
        }
    }
}