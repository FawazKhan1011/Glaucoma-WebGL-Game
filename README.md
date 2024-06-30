#  Glaucoma (WebGL Game):-

Glaucoma is an endless 2D runner game made with Unity2D as the Game engine. This game
is made for Web browsers using WebGL (Web Graphics Library) which is a JavaScript API
for rendering high-performance interactive 3D and 2D graphics within any compatible web
browser without the use of plugins.<br/><br/> This game is created with the sole purpose of spreading
awareness about the disease ‘Glaucoma’ which is a group of eye diseases that can cause
vision loss and blindness by damaging a nerve in the back of your eye called the optic nerve.
The game can run on mobile browsers and is hosted on AWS (Amazon Web Services).
50<br/><br/>
In this game the player is constantly jogging in 3 lanes and there is a timer that is decreasing.
To increase the timer, you have to collect the eye drops that will be spawning across these 3
lanes. When the timer is less than 10s, there’s a blindness effect applied to the player. The
game ends with an Important regarding the regular intake of medication to prevent such
diseases<br/><br/>
This Web Game will be present outside of clinics in waiting areas/lobbies in the form of a
QR code poster so that the people can scan it and gain awareness about the disease while
having a little entertainment as they wait.<br/> 

Game Link:<br/> https://digilateral.com/patientawareness/glaucoma/ (mobile browsers)
<br/><br/>
Backup Link:<br/> https://glaucoma-game.netlify.app/ (mobile browsers)
<br/><br/>
1. Game Start Screen&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;2. Instructions Screen<br/><br/>
<img src="https://github.com/FawazKhan1011/Glaucoma-WebGL-Game/assets/138883345/2ef343f7-3633-4de9-b5a7-7c6a9435472c" width="200" style="margin: 20px;" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://github.com/FawazKhan1011/Glaucoma-WebGL-Game/assets/138883345/4cbc80f8-a922-42a0-bf7d-6d93581d2a60" width="200" style="margin: 20px;" /><br/><br/>3. Game Screen&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;4. End Screen<br/><br/>
4. <img src="https://github.com/FawazKhan1011/Glaucoma-WebGL-Game/assets/138883345/55963a04-2230-41c5-83da-53bf55be5567" width="200" style="margin: 20px;" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img src="https://github.com/FawazKhan1011/Glaucoma-WebGL-Game/assets/138883345/744129db-2d59-4447-a413-47c4986dd170" width="200" style="margin: 20px;" /><br/><br/>

• This project was made in Unity2D suite which is a 2d Unity game engine for
developing 2 – dimensional games, Graphics and Animation<br/><br/>
• The Coding language Used for this project was C#, which was used to give behaviour
to the 2d objects in the game through scripting.<br/><br/>
• For the random Spawning logic of the eye drops, I used Prefabs and 3 spawn locations
across the lanes to randomly spawn the item.<br/><br/>
• I used ASCT texture compression on all the images for compression so that it runs
smoothly in browsers and the build size is reduced.<br/><br/>
• For the collection of eye drops, I used onCollision method to track collisions between
the game objects and destroy it.<br/><br/>
• The movement of the bottles were all done using Unity’s animation component by
animating the bottle and its collider.<br/><br/>
• The blindness effect was done using Unity’s post processing component by using the
vignette effect
