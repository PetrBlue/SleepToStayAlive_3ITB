using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "NewBuildingData", menuName = "Building Data", order = 1)]
public class BuildiingScriptable : ScriptableObject
{
    public string buildingName;
    public int wood;
    public int stone;
    [SerializeField]
    public List<BuildiingScriptable> buildingDataList; // List of BuildingScriptable objects
    public GameObject buildingPrefab;
    public GameObject buttonPrefab; // Reference to the button prefab
    public Transform buttonContainer; // Parent transform for instantiated buttons

    void Start()
    {
        foreach (BuildiingScriptable buildingData in buildingDataList)
        {
            GameObject buttonGO = Instantiate(buttonPrefab, buttonContainer);
            Button button = buttonGO.GetComponent<Button>();
            button.GetComponentInChildren<Text>().text = buildingData.buildingName;
            button.onClick.AddListener(() => OnBuildingButtonClick(buildingData));
        }
    }
    void OnBuildingButtonClick(BuildiingScriptable buildingData)
    {
        Debug.Log("Button clicked for building: " + buildingData.buildingName);

        // Instantiate the building prefab or perform any other action
        Instantiate(buildingData.buildingPrefab, Vector3.zero, Quaternion.identity);
    }
}
