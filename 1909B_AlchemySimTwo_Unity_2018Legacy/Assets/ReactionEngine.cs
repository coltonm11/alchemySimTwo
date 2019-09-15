using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactionEngine : MonoBehaviour
{
    MoleculeTable moleculicon;

    string firstMol;
    string secondMol;

    private void Start()
    {
        moleculicon = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<MoleculeTable>();
    }

    public Solution React(Solution sol)
    {
        firstMol = FindFewestElectrons(sol);
        secondMol = FindLargestCompatable(sol);

        if (secondMol == "null")
        {
            sol.reacting = false;
            return sol;
        }

        sol.RemoveMolecule(firstMol);
        sol.RemoveMolecule(secondMol);

        Molecule newMolecule = Bond(firstMol, secondMol);
        sol.AddMolecule(newMolecule);

        firstMol = null;

        print("||RE|| combined " + firstMol + " and " + secondMol);

        return sol;
    }

    string FindFewestElectrons(Solution sol)
    {
        int electrons = 9;
        string molecule = "null";

        foreach (KeyValuePair<string, int> entry in sol.solutionMolecules)
        {
            print("ping");
            if (moleculicon.GetMol(entry.Key).GetElectrons() < electrons)
            {
                print("pong");
                molecule = entry.Key;
            }

        }
        print(molecule);
        return molecule;
    }

    string FindLargestCompatable(Solution sol)
    {
        int firstElectrons = moleculicon.GetMol(firstMol).GetElectrons();
        int secondElectrons = 0;
        string molecule = "null";
        bool hasMultiples = false;

        foreach (KeyValuePair<string, int> entry in sol.solutionMolecules)
        {
            int theseElectrons = moleculicon.GetMol(entry.Key).GetElectrons();

            if (sol.solutionMolecules[firstMol] > 1)
                hasMultiples = true;

            switch (hasMultiples)
            {
                case true:
                    if (theseElectrons > secondElectrons && firstElectrons + theseElectrons < 9)
                    {
                        molecule = entry.Key;
                    }
                    break;

                case false:
                    if (entry.Key != firstMol && theseElectrons > secondElectrons && firstElectrons + theseElectrons < 9)
                    {
                        molecule = entry.Key;
                    }
                    break;
            }
        }

        return molecule;
    }

    Molecule Bond(string adam, string eve)
    {
        Molecule sendingMol = moleculicon.GetMol(adam);
        Molecule recievingMol = moleculicon.GetMol(eve);


        foreach (KeyValuePair<Atom, int> entry in sendingMol.moleculeAtoms)
        {
            int i = entry.Value;
            recievingMol.moleculeAtoms[entry.Key] += i;
        }

        recievingMol.SetValues();
        moleculicon.SetMol(recievingMol.GetName(), recievingMol);

        return recievingMol;
    }
}
