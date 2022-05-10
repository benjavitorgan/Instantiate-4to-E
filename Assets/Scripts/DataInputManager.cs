using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInputManager : MonoBehaviour
{
    public Text txtUserName;

    //Elimino funciones default

    public void ShowGreetings ()
    {
        Debug.Log("Hola " + txtUserName.text);
    }
}
