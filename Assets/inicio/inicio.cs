using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System;
using static UnityEngine.Debug;
using static UnityEditor.PlayerSettings;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class inicio : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click () {
        UnityEngine.Debug.Log("Funciona");
        try {
            Process myProcess = new Process();
            myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            myProcess.StartInfo.CreateNoWindow = true;
            myProcess.StartInfo.UseShellExecute = false;
            myProcess.StartInfo.FileName = "C:\\Users\\admin-dam2b\\Sebas\\WPF_launcher\\abstergo_v3\\bin\\Debug\\abstergo_v3.exe";
            myProcess.EnableRaisingEvents = true;
            myProcess.Start();
            myProcess.WaitForExit();
            int ExitCode = myProcess.ExitCode;
            //print(ExitCode);
            } catch (Exception e){
                print(e);        
            }
    }

}
