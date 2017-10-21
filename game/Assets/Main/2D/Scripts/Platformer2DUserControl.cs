using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
	[RequireComponent(typeof (PlatformerCharacter2D))]
	public class Platformer2DUserControl : MonoBehaviour
	{
		private PlatformerCharacter2D m_Character;
		private bool m_Jump;
		private float touchinput=0;
		private bool touchjump=false;
		private float h;


		private void Awake()
		{
			m_Character = GetComponent<PlatformerCharacter2D>();
		}


		private void Update()
		{
			Scene currentScene = SceneManager.GetActiveScene ();
			string sceneName= currentScene.name;

			if (!m_Jump)
			{
				// Read the jump input in Update so button presses aren't missed.
				if (sceneName == "21st Level") {
					m_Jump = CrossPlatformInputManager.GetButtonDown ("Fire3");	
				} 
				else {
					
					m_Jump = CrossPlatformInputManager.GetButtonDown ("Jump");
				}
			}
		}


		private void FixedUpdate()
		{
			Scene currentScene = SceneManager.GetActiveScene ();
			string sceneName= currentScene.name;

			// Read the inputs
			#if !UNITY_ANDROID
			if(sceneName == "21st Level")
			{
				h = CrossPlatformInputManager.GetAxis("Vertical");
			}
			else
			{
				h = CrossPlatformInputManager.GetAxis("Horizontal");
			}

			m_Character.Move(h, false, m_Jump);
			m_Jump = false;
			#else
			m_Character.Move(touchinput,false,touchjump);
			m_Jump = false;
			#endif


		}

		public void StartMoving(float horizontalinput)
		{
			touchinput = horizontalinput;
		}
		public void StartJumping(bool isjump)
		{
			touchjump = isjump;
		}
	}
}
