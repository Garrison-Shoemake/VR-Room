# VR Room
###### developed by [Garrison Shoemake](https://github.com/Garrison-Shoemake) -[LinkedIn](https://www.linkedin.com/in/garrison-shoemake/) -[Twitter](Coming Soon!)

## Development
This project had us tackle some common Unity concepts. We were given assets and a premade scene and had to script and implement various interactions to the scene. The user would spawn in a room with interactable objects and a door that leads into another room with even more interactables.  

<p align="center">
  <img src="https://cdn.discordapp.com/attachments/276959475737296896/953368482605588500/unknown.png" width="">
</p>

Movement is done via point and click teleportation. The red raycasts extending from both hands will turn white when pointing at an interactable, and either the bumper or trigger buttons will interact. Objects can be held and thrown and controls allow for holding objects in both hands as well as holding in one and teleporting in the other. 

<p align="center">
  <img src="https://cdn.discordapp.com/attachments/276959475737296896/953369465221963896/unknown.png" width="">
</p>

A few of the hurdles were getting tracking on holding objects to work and using provided animations. Initially I had a sphere collider so that things could be grabbed easily, but, when the raycasts were added the hands started grabbing multiple objects at once. For the door to animate, we were given premade animations. None of which worked. I ended up making my own animation, but this causes the door to jiggle when it is first selected and looks unrealistic.

This project was also constricted by time, so I want to work on it more, from a game development perspective. I want to make an interactable puzzle room, giving incentive to the player for trying different things in different areas. 

## To-Do List:
- [x] Implement Teleportation Movement
- [ ] Introduce minimzation of motion sickness 
- [x] Script interactable objects in scene
- [x] Activate Animation on Interaction
- [ ] Re-angle Raycasts on Hand
