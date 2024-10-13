using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class NameInputManager : MonoBehaviour
{
    [SerializeField] private InputField nameInput;
    [SerializeField] private GameObject nameInputCanvas;
    [SerializeField] private Text playerName;

    private int minValue = 1;
    private int maxValue = 9;

    private void Awake()
    {
        nameInput.onValueChanged.AddListener((word) => nameInput.text = Regex.Replace(word, @"[^0-9a-zA-Z°¡-ÆR]", ""));
    }

    public void StartGame()
    {
        if (nameInput.text.Length > minValue && nameInput.text.Length < maxValue)
        {
            playerName.text = nameInput.text;

            nameInputCanvas.SetActive(false);
        }
        else
        {
            return;
        }
    }
}
