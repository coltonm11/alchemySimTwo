using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryCard : MonoBehaviour
{
    Solution solution;
    public GameObject textObject;

    private void Start()
    {
        solution = this.GetComponent<Solution>();
        SetText();
    }

    void SetText()
    {
        print("INVENTORY CARD: solution stuff is " + solution.solutionMolecules);

        TextMeshProUGUI text = textObject.GetComponent<TextMeshProUGUI>();
        foreach (KeyValuePair<string, Molecule> entry in solution.solutionMolecules)
        {
            text.text += entry.Value.GetName();
        }
    }

    public void SendSolution(GameObject gob)
    {
        Solution targetSolution = gob.GetComponent<Solution>();
        foreach (KeyValuePair<string, Molecule> entry in solution.solutionMolecules)
        {
            targetSolution.solutionMolecules.Add(entry.Key, entry.Value);
        }
        print("TARGET SOLUTION SAYS: " + targetSolution.solutionMolecules);
    }

}
