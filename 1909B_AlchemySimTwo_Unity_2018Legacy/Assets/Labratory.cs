using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Labratory : MonoBehaviour
{
    public MoleculeTable moleculicon;
    public ReactionEngine reactionEngine;
    public Solution sol;
    public TextMeshProUGUI textNotation;
    public TextMeshProUGUI textAmount;
    public TextMeshProUGUI textElectrons;
    public TextMeshProUGUI textEL;
    public TextMeshProUGUI textBond;
    public TextMeshProUGUI textDensity;
    public TextMeshProUGUI textPolarity;

    private void Start()
    {
        sol.reacting = false;
    }

    private void Update()
    {
        while (sol.reacting == true)
        {
            sol = reactionEngine.React(sol);
            UpdateGUI();
        }

    }

    public void AddSolution(Solution addedSolution)
    {
        foreach (KeyValuePair<string, int> entry in addedSolution.solutionMolecules)
        {
            if (sol.solutionMolecules.ContainsKey(entry.Key))
            {
                sol.solutionMolecules[entry.Key] += 1;
            }
            if (!sol.solutionMolecules.ContainsKey(entry.Key))
            {
                sol.solutionMolecules.Add(entry.Key, entry.Value);
            }
        }
        sol.reacting = true;
    }

    public void UpdateGUI()
    {
        textNotation.text = "";
        textAmount.text = "";
        textElectrons.text = "";
        textEL.text = "";
        textBond.text = "";
        textDensity.text = "";
        textPolarity.text = "";

        foreach (KeyValuePair<string, int> entry in sol.solutionMolecules)
        {
            Molecule mol = moleculicon.GetMol(entry.Key);
            textNotation.text += mol.GetName() + "\n";
            textAmount.text += entry.Value + "\n";
            textElectrons.text += mol.GetElectrons() + "\n";
            textEL.text += mol.GetElectronegativity() + "\n";
            textBond.text += mol.GetBondStrength() + "\n";
            textDensity.text += mol.GetDensity() + "\n";
            textPolarity.text += mol.GetPolarity() + "\n";
        }
    }
}
