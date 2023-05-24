using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class JsonReadSystem : MonoBehaviour
{
    public InputField usuarioCampo;
    public InputField nombreCampo;

    public void SaveToJson()
    {
        LoginMainButton info = new LoginMainButton();
        info.usuario = usuarioCampo.text;
        info.nombre = nombreCampo.text;
        string Json = JsonUtility.ToJson(info, true);
        File.WriteAllText(Application.dataPath + "/LoginMainButtonFile.json", Json);
    }


}
