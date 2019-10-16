using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solution : MonoBehaviour
{
    MoleculeTable moleculicon;
    public bool reacting;
    public Dictionary<string, int> solutionMolecules = new Dictionary<string, int>();
    List<string> sortedMoleculesByBoilingPoint = new List<string>();

    private void Start()
    {
        reacting = true;
        moleculicon = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<MoleculeTable>();
    }

    public void AddMolecule(Molecule molecule)
    {
        if (solutionMolecules.ContainsKey(molecule.GetName()))
        {
            solutionMolecules[molecule.GetName()] += 1;
        }
        if (!solutionMolecules.ContainsKey(molecule.GetName()))
        {
            solutionMolecules.Add(molecule.GetName(), 1);
            moleculicon.SetMol(molecule.GetName(), molecule);
        }

        SortMoleculesByBoilingPoint();
    }

    public void RemoveMolecule(string mol)
    {
        if (!solutionMolecules.ContainsKey(mol))
            return;

        solutionMolecules[mol] -= 1;
        if (solutionMolecules[mol] < 1)
            solutionMolecules.Remove(mol);
    }

    void SortMoleculesByBoilingPoint()
    {
        sortedMoleculesByBoilingPoint.Clear();

        foreach(KeyValuePair<string, int> firstMol in solutionMolecules)
        {
            float firstMolValue = moleculicon.GetMol(firstMol.Key).GetDensity();
            float secondMolValue;
            bool foundSpot = false;

            foreach (string secondMol in sortedMoleculesByBoilingPoint.ToArray())
            {
                secondMolValue = moleculicon.GetMol(secondMol).GetDensity();

                if (firstMolValue < secondMolValue)
                {
                    sortedMoleculesByBoilingPoint.Insert(sortedMoleculesByBoilingPoint.IndexOf(secondMol), firstMol.Key);
                    foundSpot = true;
                    break;
                }
            }

            if (!foundSpot)
                sortedMoleculesByBoilingPoint.Add(firstMol.Key);
        }

        //debug
        foreach(string item in sortedMoleculesByBoilingPoint)
        {
            print("SOLUTION: sorted molecules item: " + item);
        }
    }
}
