using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavePuzzleData
{
    //This method is used to save the puzzle progress of the player to a binary save file
    public static void SavePuzzle(PuzzleScript puzzle)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/puzzle.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        //Saves data in the format of the PuzzleSaveData class from the passed in PuzzleScript
        PuzzleSaveData data = new PuzzleSaveData(puzzle);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    //Tries to load in a save binary file from the set loaction
    public static PuzzleSaveData LoadPuzzleData()
    {
        string path = Application.persistentDataPath + "/puzzle.save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            //Reads in binary file and formats it according to the PuzzleSaveData class
            PuzzleSaveData data = formatter.Deserialize(stream) as PuzzleSaveData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
