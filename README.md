# in-class-activities
## Devlogs
### W1
Hello World!
### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.
### W3
Table #4 - We would make the return type boolean because whether or not the player hit the beat can be described with true if they hit the beat and false if they did not. For the parameters we would make them floats, float x and float y and float x would be the time it took the player to press the button and the float y would be the time the key should be pressed within. 1. The metaphor we came up with is that Classes are like the instructions for lego building blocks and components are the possible builds you can make with the blocks. Additionally, we said that variables are the bricks and methods are the different ways you can use the bricks to make something. 2.  
### W4
Table #9 - Line 5 is intitializing a float variable for movement speed, setting it's value as 1 and making it be able to be changed in the inspector in Unity. Line 22 is using an algoritim to calculate how much the cat is going to move verticially by mutiplying the speed by the amount of time that the player has pressed the button for. Line 25 seems to be moving the object to the position based on the amount calculated in line 22. I chose to add rigid body for the Cat object and for the Soccer Ball object. I checked the Is Trigger box for the Goal object. My game did not work properly at first because the cat would keep falling through the floor so I had to get rid of having the Is Trigger box checked but after that it worked. 
### W5
My question was how to call a method on a component, which one of the member in my group answered that we had to create a variable that is an instance of the get component method and then simply call the method with it. Notes: The variable we are going to need will include a target variable that is a transform component which will need to be serialized. We are thinking that one of the methods in this class should be Update() since the Cat class has it and also because the deer needs to be updated every frame. We also think there should be a Start() method because the AI needs to know when it should start moving. 
### W6
[Resource Guide](https://docs.google.com/document/d/1e2mN0AU-swOXlUWgrUAqoCe8Foq_KrDtrJpCDu_aOx4/edit?tab=t.0) . Notes: The member variable that this class needs is the speed variable which will be an int and be serialized. It will also need a target variable which which store the position of the player object. The methods that this class will need is startChase() and stopChase which are not going to be methods already built into Unity but methods that we will have to code and call. The startChase() method will make the bats start moving toward the player as well as enable the component if it is previously disabled and the stopChase() will make the bats stop moving towards the player by disabling the component. 
### W7
[Game Idea](https://docs.google.com/document/d/13nVwuWGt47ZJIsqeRlTBOlD78hPmrMBLpVFdvgc_doA/edit?usp=sharing) . My role in the group was game Physics. The code in Step 2 was wrong because it was usiing a vector component to try and move the object, which would cause it to move forward along the world space, not forward in it's own direction, which could be done by using transform. 
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 