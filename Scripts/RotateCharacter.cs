using UnityEngine;
using CnControls;


[AddComponentMenu("Camera/Simple Smooth Mouse Look ")]
public class RotateCharacter : MonoBehaviour
{
	Vector2 mouseAbsolute;
	Vector2 smoothMouse;
	
	public Vector2 clampInDegrees = new Vector2(360, 180);
	public bool lockCursor;
	public Vector2 sensitivity = new Vector2(2, 2);
	public Vector2 smoothing = new Vector2(3, 3);
	
	
	
	
	
	
	void Start()
	{
		
		
		
		
		
	}
	
	void Update()
	{
		
		
		// Clamps the rotation
		
		
		
		// Gets input from screen
		var mouseDelta = new Vector2(CnInputManager.GetAxisRaw("HorizontalLook"), -CnInputManager.GetAxisRaw("VerticalLook"));
		
		// makes the mouse slower/less sensitive
		mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity.x * smoothing.x, sensitivity.y * smoothing.y));
		
		// makes the mouse smooth
		smoothMouse.x = Mathf.Lerp(smoothMouse.x, mouseDelta.x, 1f / smoothing.x);
		smoothMouse.y = Mathf.Lerp(smoothMouse.y, mouseDelta.y, 1f / smoothing.y);
		
		// Finds mouse movement
		mouseAbsolute += smoothMouse;
		
		// Clams the mouse
		if (clampInDegrees.x < 360)
			mouseAbsolute.x = Mathf.Clamp(mouseAbsolute.x, -clampInDegrees.x * 0.5f, clampInDegrees.x * 0.5f);
		
		var xRotation = Quaternion.AngleAxis(-mouseAbsolute.y, 1 * Vector3.right);
		transform.localRotation = xRotation;
		
		// Then clamp and apply the global y value.
		if (clampInDegrees.y < 360)
			mouseAbsolute.y = Mathf.Clamp(mouseAbsolute.y, -clampInDegrees.y * 0.5f, clampInDegrees.y * 0.5f);
		
		
		
		
	}
}

