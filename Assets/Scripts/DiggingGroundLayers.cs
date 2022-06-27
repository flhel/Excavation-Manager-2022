using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CursorBehavior
{
    public class DiggingGroundLayers : MonoBehaviour
    {
        //Collider und Positon des Objekts relativ zur Kamera ist für OnMouse...() wichtig
        public void OnMouseEnter()
        {
            GameObject.Find("Tools").GetComponent<DiggingToolBehaviour>().setCursor();
        }

        public void OnMouseExit()
        {
            GameObject.Find("Tools").GetComponent<DiggingToolBehaviour>().setCursorDefault();
        }
    }
}