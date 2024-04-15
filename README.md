# Animal-game
 2-D card based game on animals for kids to learn various categories in animal through drag and drop

Step 1: Create the Unity Project and Scene Setup
 Open Unity Hub and create a new Unity project (2D recommended for card games).
 Set Up the Scene:
  Add a Canvas to your scene for UI components.
 Create UI elements:
  18 cards as UI Image objects.
  The sprites for each card have been provided and saved in Images (Assets -> Images) folder.
  Two buckets (Image objects) and set their color or image property.
  A Text object for displaying scores and messages.
 Place the cards and buckets according to your design requirements.

Step 2: Script Implementation
  Overview of Scripts
   GameManager: Manages the game state, including randomizing categories, determining correct placement, and scoring.
   Card: Manages individual card data and interactions.
   Bucket: Manages bucket interactions, such as detecting dropped cards.
   UIManager: Manages UI elements like pop-up descriptions and finish screen.
   CardPopupManager: Manages the pop up description of each card triggered on click
   AnimalData: Manages the data of all the animals and the information about them based on its categories

Step 3: Mapping(Adding) of these scripts
 GameManager is attached to an empty GameObject in the scene.
 Card is attached to each card GameObject.
 Bucket is attached to each bucket GameObject.
 UIManager is attached to a UI Canvas.
 AnimalData is an empty GameObject saved in Assets folder mapped to GameManager


Detailed Setup Steps: (OVERALL)
 - Prepare Your GameObjects: Make sure that you have all your GameObjects for cards, buckets, and UI elements in your scene.
 - Attach GameManager Script:
   Create a new GameObject named "GameManager" in your scene (you can do this by right-clicking in the Hierarchy panel and selecting Create Empty).
   With the GameManager GameObject selected, click Add Component in the Inspector panel and search for GameManager. Click on it to add it to the GameObject.
 - Link Cards:
   Click on the GameManager GameObject in the Hierarchy to view its properties in the Inspector.
   You will see a field in the GameManager script labeled something like Cards with a size property. Set the size to the number of card GameObjects you have.
   Drag each card GameObject from the Hierarchy and drop it into each element slot that appears under the Cards list in the GameManager component.
 - Link Buckets:
   Find your red bucket and blue bucket GameObjects in the Hierarchy.
   Drag the red bucket GameObject to the Red Bucket field in the GameManager component.
   Drag the blue bucket GameObject to the Blue Bucket field in the GameManager component.
 - Link UIManager:
  If the UIManager script is not already added, create a UI GameObject (e.g., a Canvas if not already present), add the UIManager script to it by clicking Add Component, and   search for UIManager.
  Drag this UI GameObject with the UIManager component to the UIManager field in the GameManager component.


Step-by-Step Setup (CARD PREFAB)
 - First, ensure you have a GameObject to represent each card. Typically, this would be a prefab with components like an Image for the sprite and a script component (like   Card.cs).
 - To create a card prefab:
   Create an empty GameObject in the Hierarchy (right-click > Create Empty).
   Add an Image component (Add Component > UI > Image). This is where you'll set your sprite.
   Assign the sprite to the Image component in the Inspector by dragging the sprite from your assets into the Source Image field of the Image component.
   Add the Card script (Add Component > Scripts > Card) to the same GameObject.
 - Configure Your Card GameObject:
   Set up the necessary properties in the Card script (like attributes, if any).
   Adjust transform settings (position, rotation, scale) as needed.
   Make It a Prefab:
 - Drag the configured GameObject from the Hierarchy into your project Assets folder. This turns it into a prefab.
   You can now delete the GameObject from the Hierarchy if you like, as the prefab is what you'll use in the scene.
   Place Card Prefabs in the Scene or Instantiate Them Dynamically:
 - Drag the prefab from your Assets into the scene for static placement or prepare to instantiate them via script if they need to be dynamic.
 - Linking to GameManager:
   Select the GameManager GameObject in the Hierarchy.
   In the Inspector, find the Cards list in the GameManager script component. Adjust the size to match the number of cards.
   Drag each card GameObject from the Hierarchy (not the sprite) into each slot of the Cards array in the GameManager script.

<img width="551" alt="1" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/44d43479-bd7c-4258-b348-d559aebdf2d7">

<img width="557" alt="2" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/1104c80a-7227-45fc-bd58-690777b52c5b">

(The categories are changed with every new game)

<img width="556" alt="3" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/0a031089-3d44-41fa-8f86-da90f5d94652">

(The cards will disappear as you select them)

<img width="391" alt="4" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/2fd3ef7d-b120-49bc-b733-86b85ca60a51">

(AnimalData asset)

<img width="344" alt="5" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/0c589e5f-66e0-4c53-b415-b4e7288037b3">

(Card script inputs)

<img width="365" alt="7" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/413811de-91c6-424e-804b-3fc27fc8c60c">

(CardPopupManager)

<img width="359" alt="8" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/28cb3dd8-e4f3-48e5-ba5a-f9431531db32">

(UIManager object created for display purposes)

<img width="295" alt="9" src="https://github.com/SVaishnaviVasa/Animal-game/assets/120392585/c96cf0f9-0be5-423c-957c-ea45cd36667e">

(Create a new empty GameObject and assign GameManager which takes the above inputs)

For the codes please follow the steps: 
 Go to Assets -> Scripts
 You will see a variety of scripts. But out of them the names of custom scripts are as follows:
  - CardPopupManager.cs
  - GameManager.cs
  - Card.cs
  - UIManager.cs
  - AnimalData.cs
  - Bucket.cs
 These handle all the events in the game.


