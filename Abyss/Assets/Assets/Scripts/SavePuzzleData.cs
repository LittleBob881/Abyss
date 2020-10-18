using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavePuzzleData
{
    public static void SavePuzzle(PuzzleScript puzzle)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/puzzle.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        PuzzleSaveData data = new PuzzleSaveData(puzzle);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PuzzleSaveData LoadPuzzleData()
    {
        string path = Application.persistentDataPath + "/puzzle.save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

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
