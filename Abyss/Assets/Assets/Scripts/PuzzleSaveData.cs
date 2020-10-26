
using System;
using UnityEngine;

//This class is used by the SavePuzzleData class to save the PuzzleScript information that is needed for a save file

[System.Serializable]
public class PuzzleSaveData
{
    public int puzzleItemProgress;
    public Boolean[] unlocks;

    public PuzzleSaveData(PuzzleScript puzzle)
    {
        this.puzzleItemProgress = puzzle.GetPuzzleItemValue();
        this.unlocks = puzzle.GetUnlock();
    }
}
