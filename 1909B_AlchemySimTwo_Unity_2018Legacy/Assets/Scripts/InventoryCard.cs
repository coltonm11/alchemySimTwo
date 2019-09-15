using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryCard : MonoBehaviour
{
    Solution solution;
    MoleculeTable molTable;
    public GameObject textObject;

    private void Start()
    {
        solution = this.GetComponent<Solution>();
        molTable = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<MoleculeTable>();
        SetText();
    }

    void SetText()
    {
        print("INVENTORY CARD: solution stuff is " + solution.solutionMolecules);

        TextMeshProUGUI text = textObject.GetComponent<TextMeshProUGUI>();
        foreach (KeyValuePair<string, int> entry in solution.solutionMolecules)
        {
            text.text += entry.Key;
        }
    }

    public void SendSolution(GameObject gob)
    {
        gob.GetComponent<Labratory>().AddSolution(solution);
    }

}
