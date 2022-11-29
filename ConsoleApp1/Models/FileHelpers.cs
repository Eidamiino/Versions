using System.Runtime.Serialization.Formatters.Binary;

namespace Versions.Models;

public class FileHelpers
{
	public static void SaveFileToBinary(string pathToSave, object obj)
	{
		using (FileStream fs = new FileStream(pathToSave, FileMode.Create))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.Serialize(fs, obj);
		}
	}
}