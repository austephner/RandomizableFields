# Randomizable Fields
#### Summary
Collection of attributes for allowing randomizable fields within the Unity Editor.

#### Example
![Example](https://i.imgur.com/rGrWbsc.gif)

# Usage
1. Import the `RandomizableFields` namespace. 
2. Add `[Randomizable(MIN, MAX)]` or `[Randomizable(MAX)]` attributes to `int` and `float` fields.
3. Add `[RandomizableGuid]` to string-based `GUID` fields.
```c#
[Randomizable(0.0f, 1.0f)] [SerializeField] 
private float _randomFloat; 

[Randomizable(100)] [SerializeField] 
private int _randomInt;

[RandomizableGuid] [SerializeField] 
private string _randomGuid = Guid.NewGuid().ToString();
```

# Notes
#### Usage Cont. 
- The "MIN" value can be omitted, for numeric fields it'll default to `0`. 
- If you accidentally click the "R" button, just undo your changes and the previous value will appear.

#### Todo
- Randomizable vector fields
- Randomizable string fields

#### Testimonial
I use a lot of IMGUI `Window` functions for rapid prototyping. The IMGUI system requires a window to have a unique ID. This attribute allowed me to easily set a new ID to a random value with one click. I'm just too lazy to remember the last ID I used, but not too lazy to write an entire attribute system. ;)

#### Goes Well With...
- [ProtoGUI](https://github.com/austephner/ProtoGUI)