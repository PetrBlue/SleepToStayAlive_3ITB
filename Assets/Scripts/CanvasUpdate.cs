using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasUpdate : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI woodText;
    [SerializeField]
    private TextMeshProUGUI stoneText;
    private void Update()
    {
        woodText.text = "Wood: " + ResourceManager.wood;
        stoneText.text = "Stone: " + ResourceManager.stone;
    }
}
