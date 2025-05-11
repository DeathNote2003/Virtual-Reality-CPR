# CPR VR Trainer

## Project Overview

**CPR VR Trainer** is a Virtual Reality (VR) application developed using Unity to train users on performing Cardiopulmonary Resuscitation (CPR). The project aims to provide an immersive, interactive experience that simulates real-life CPR scenarios, allowing users to practice and refine their CPR skills in a controlled virtual environment.

The application includes multiple scenes such as a landing page, training mode, and practice mode, with features like voice instructions, animations, and interactive UI elements.

---

## Features

- **Landing Scene**  
  A main menu with buttons for "Training" and "Practice" to navigate to respective modes.

- **Training Mode**  
  Guides users through CPR steps with visual and audio instructions, including animated hand movements and an instruction box.

- **Practice Mode**  
  Allows users to perform CPR without guidance to test their skills.

- **Interactive UI**  
  Buttons like "Continue" and "Back" for seamless navigation between scenes.

- **Audio Integration**  
  Voice instructions (e.g., `"CPCR"` or `"source1.wav"`) to guide users during training.

- **VR Compatibility**  
  Designed for VR headsets, with interactive elements like hand models for realistic CPR simulation.

---

## Project Structure

### Scenes
- **Landing Scene**: Entry point with navigation buttons.  
- **Training Scene**: Includes CPR training with animations and audio.  
- **Practice Scene**: Free practice mode for users to apply learned skills.

### Scripts
- `TrainingScript.cs`: Manages training logic, animations, and audio playback.  
- Other scripts handle UI navigation, scene transitions, and interactions.

### Assets
- **3D Models**: Hand models and CPR dummy for realistic visuals.  
- **Audio Files**: Voice instructions (e.g., `source1.wav`).  
- **UI Elements**: Buttons and instruction boxes.

---

## Challenges and Solutions

### UI Navigation Issues
- **Problem**: "Training" and "Practice" buttons did not transition to correct scenes; "Continue" sometimes redirected to the Landing Scene.
- **Solution**: Updated button event handlers and corrected scene management using `SceneManager.LoadScene()`. Verified scene names and build indices in Build Settings.

### Audio Playback
- **Problem**: Audio files were not playing in the training scene.
- **Solution**: Added an `AudioSource` component, assigned clips in the Inspector, and triggered playback via `Play()` in `TrainingScript.cs`. Ensured audio files were in a supported format (WAV).

### Lighting and Normals
- **Problem**: Error "Mesh does not have normals for Global Illumination" led to incorrect lighting.
- **Solution**: Recalculated normals in Blender or enabled "Calculate Normals" in Unity. Used Baked Global Illumination for better lighting performance.

### Animation Integration
- **Problem**: Hand and instruction box animations were not syncing with CPR steps.
- **Solution**: Used Unity's Animator Controller and linked triggers to `TrainingScript.cs` for synchronization. Ensured Animator component was correctly set on the "Hands" GameObject.

### Scene Management
- **Problem**: Incorrect transitions caused users to get stuck or redirected incorrectly.
- **Solution**: Implemented robust scene management with debug logs and fixed button mappings in the Unity Inspector.

---

## Setup and Installation

### Prerequisites
- Unity Editor (e.g., **2021.3 LTS**)
- VR headset (e.g., **Oculus Quest**, compatible with Unity XR)
- Audio and 3D model assets (included in repo or added externally)

### Steps
1. Clone the repository:  
   `git clone [repository-url]`
2. Open the project in Unity Editor.
3. Ensure all scenes are added to Build Settings (Landing Scene at index 0).
4. Import necessary assets (audio files, 3D models).
5. Configure VR settings (e.g., enable XR Plugin Management).
6. Build and run the project on your VR headset or test in Unity Editor.

---

## Usage

- Launch the app; you’ll start on the **Landing Scene**.
- Click **"Training"** for guided CPR steps with audio and animations.
- Click **"Practice"** to test CPR skills without help.
- Use **"Continue"** to progress or return to the main menu.

---

## Future Improvements

- Add **multiplayer support** for collaborative CPR training.
- Add **multi-language support** for voice instructions.
- Optimize for **low-end VR devices**.
- Add a **scoring system** to evaluate performance in Practice Mode.

---

## Contributing

Contributions are welcome!  
Please fork the repo, create a new branch, and submit a pull request.  
Make sure your code follows Unity best practices and includes proper documentation.
