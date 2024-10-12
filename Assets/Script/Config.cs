using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Config : MonoBehaviour
{

    public static float newSpeed = 10;

    [SerializeField]
    private TMP_Text valueText;


    public void changeValue(float value)
    {
        newSpeed += value;
        valueText.text = newSpeed.ToString();
    }

    private void Start()
    {
        Debug.Log(newSpeed);
        changeValue(0);
        gameObject.SetActive(false);
    }


    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }

}
