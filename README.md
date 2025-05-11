CPR VR Trainer

Project Overview

CPR VR Trainer is a Virtual Reality (VR) application developed using Unity to train users on performing Cardiopulmonary Resuscitation (CPR). The project aims to provide an immersive, interactive experience that simulates real-life CPR scenarios, allowing users to practice and refine their CPR skills in a controlled virtual environment. The application includes multiple scenes, such as a landing page, training mode, and practice mode, with features like voice instructions, animations, and interactive UI elements.

Features





Landing Scene: A main menu with buttons for "Training" and "Practice" to navigate to respective modes.



Training Mode: Guides users through CPR steps with visual and audio instructions, including animated hand movements and an instruction box.



Practice Mode: Allows users to perform CPR without guidance to test their skills.



Interactive UI: Buttons like "Continue" and "Back" for seamless navigation between scenes.



Audio Integration: Voice instructions (e.g., "CPCR" or "source1.wav") to guide users during training.



VR Compatibility: Designed for VR headsets, with interactive elements like hand models for realistic CPR simulation.

Project Structure





Scenes:





Landing Scene: Entry point with navigation buttons.



Training Scene: Includes CPR training with animations and audio.



Practice Scene: Free practice mode for users to apply learned skills.



Scripts:





TrainingScript.cs: Manages training logic, animations, and audio playback.



Other scripts for UI navigation, scene transitions, and interaction handling.



Assets:





3D Models: Hand models and CPR dummy for realistic visuals.



Audio Files: Voice instructions (e.g., "source1.wav").



UI Elements: Buttons and instruction boxes.

Challenges and Solutions

During development, several challenges were encountered and resolved:





UI Navigation Issues:





Problem: "Training" and "Practice" buttons were not transitioning to the correct scenes, and the "Continue" button occasionally redirected to the Landing Scene instead of proceeding.



Solution: Updated button event handlers in Unity's UI system and corrected scene management logic using SceneManager.LoadScene(). Ensured correct scene names and build indices in the Build Settings.



Audio Playback:





Problem: Audio files (e.g., "CPCR" or "source1.wav") were not playing as expected in the training scene.



Solution: Added an AudioSource component to the relevant GameObject, linked the audio clip in the Unity Inspector, and triggered playback via Play() in the TrainingScript.cs. Ensured audio files were in a compatible format (e.g., WAV).



Lighting and Normals:





Problem: Encountered a "Mesh does not have normals for Global Illumination" error, causing incorrect lighting on 3D models.



Solution: Recalculated normals in the 3D modeling software (e.g., Blender) or enabled "Calculate Normals" in Unity's Model Import Settings. Adjusted lighting settings to use Baked Global Illumination for better performance.



Animation Integration:





Problem: Hand animations and instruction box animations were not syncing correctly with the CPR steps.



Solution: Used Unity's Animator Controller to manage animation states. Linked animation triggers to the TrainingScript.cs to synchronize with CPR steps. Ensured the "Hands" GameObject had the correct Animator component.



Scene Management:





Problem: Incorrect scene transitions caused users to get stuck or return to the wrong scene.



Solution: Implemented a robust scene management system using SceneManager. Added debug logs to trace scene transitions and fixed button mappings in the Unity Inspector.

Setup and Installation





Prerequisites:





Unity Editor (version [specify version, e.g., 2021.3 LTS])



VR headset (e.g., Oculus Quest, compatible with Unity XR)



Audio and 3D model assets (included in the repository or sourced externally)



Steps:





Clone the repository: git clone [repository-url]



Open the project in Unity Editor.



Ensure all scenes are added to Build Settings in the correct order (Landing Scene at index 0).



Import required assets (e.g., audio files, 3D models).



Configure VR settings in Unity (e.g., enable XR Plugin Management).



Build and run the project on your VR headset or Unity Editor for testing.

Usage





Launch the application and start at the Landing Scene.



Click "Training" to begin guided CPR training with instructions and animations.



Click "Practice" to test your CPR skills without guidance.



Use the "Continue" button to progress through training steps or return to the main menu.

Future Improvements





Add multiplayer support for collaborative CPR training.



Enhance audio instructions with multi-language support.



Optimize performance for lower-end VR devices.



Introduce a scoring system to evaluate user performance in Practice Mode.

Contributing

Contributions are welcome! Please fork the repository, create a new branch, and submit a pull request with your changes. Ensure your code follows Unity best practices and includes relevant documentation.
