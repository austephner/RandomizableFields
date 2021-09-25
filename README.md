# Randomizable Fields
Simple collection of attributes for allowing randomizable fields within the Unity Editor.

```c#
[Randomizable(0.0f, 1.0f)] [SerializeField] 
private float _randomFloat; 

[Randomizable(0, 100)] [SerializeField] 
private int _randomInt;
```

![Example](https://i.imgur.com/0KWpXFm.gif)

#### Testimonial

I use a lot of IMGUI `Window` functions for rapid prototyping. The IMGUI system requires a window to have a unique ID. This attribute allowed me to easily set a new ID to a random value with one click. I'm just too lazy to remember the last ID I used, but not too lazy to write an entire attribute system. ;)

#### Goes Well With...
- [ProtoGUI](https://github.com/austephner/ProtoGUI)
- 