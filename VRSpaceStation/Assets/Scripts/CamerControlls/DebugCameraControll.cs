using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCameraControll : MonoBehaviour
{
    //Mouse
    private Transform m_CameraTransform;
    private Transform m_Parent;

    private Vector3 m_LocalRotation;
    private float m_CamDistance =1.5f;

    public float m_MouseSensitivity =4f;
    public float m_ScrollSensitivity =2f;
    public float m_OrbitDamp =10f;
    public float m_ScrollDamp =6f;

    private bool m_Panning =false;

    // Use this for initialization
    void Start()
    {
        m_CameraTransform = this.transform;
        m_Parent = this.transform.parent;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //right click was pressed    
            m_Panning = true;
           // Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButtonUp(1))
        {
            //right click was released    
            m_Panning = false;
           // Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if (m_Panning)
        {
            if (Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                m_LocalRotation.x += Input.GetAxis("Mouse X") * m_MouseSensitivity;
                m_LocalRotation.y -= Input.GetAxis("Mouse Y") * m_MouseSensitivity;

                m_LocalRotation.y = Mathf.Clamp(m_LocalRotation.y, -90f, 90f);
            }  
        }
        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
            {
                float m_ScrollAmount = Input.GetAxis("Mouse ScrollWheel") * m_ScrollSensitivity;

                m_ScrollAmount *= (m_CamDistance * 0.3f);
                m_CamDistance += m_ScrollAmount * -1f;
                m_CamDistance = Mathf.Clamp(m_CamDistance, 0.5f, 3f);
            }
       
        Quaternion m_Qt = Quaternion.Euler(m_LocalRotation.y, m_LocalRotation.x, 0);
        m_Parent.rotation = Quaternion.Lerp(m_Parent.rotation, m_Qt, Time.deltaTime * m_OrbitDamp);

        if (m_CameraTransform.localPosition.z != m_CamDistance * -1f)
        {
            m_CameraTransform.localPosition = new Vector3(0f, 0f, Mathf.Lerp(m_CameraTransform.localPosition.z, m_CamDistance * -1f, Time.deltaTime * m_ScrollDamp));
        }
    }
}
