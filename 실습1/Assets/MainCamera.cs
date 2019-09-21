using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using System.IO.Ports;



public class MainCamera : MonoBehaviour
{



    SerialPort sp = new SerialPort("COM3", 115200);



    // Use this for initialization

    void Start()
    {

        sp.Open();

        sp.ReadTimeout = 1;



    }



    // Update is called once per frame

    void Update()
    {

        if (sp.IsOpen)

        {

            try

            {

                string value = sp.ReadLine();

                print(value);

                sp.BaseStream.Flush();

            }

            catch (System.Exception)

            {



            }

        }



    }

}