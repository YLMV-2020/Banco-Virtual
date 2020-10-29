using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    public static SceneManagerScript sharedInstance;
    private void Awake()
    {
        sharedInstance = this;
    }
    public void cambioEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }



    IEnumerator activoFade(string escena)
    {
        yield return new WaitForSeconds(1);      
    }


}
