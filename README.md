Substance Map Combiner
======================
A small program for combining multiple substance output sets into one map per channel. It's 64 bit only and has been tested on map sizes up to 8k. 8192x8192 maps will need around 6GB of RAM to combine safely due to their sheer size.

# Demo

![](images/Substance-Map-Combiner-Overview.gif)

# How To Use
The application is fairly straight forward to use.


### Selecting Files
First of all, to load maps, you have to select a source folder using the _Source Folder_ button or **Ctrl+S**. Then navigate to the folder which contains your texture sets for each of your channels. For instance a folder like this:

![](images/Texture-Sets-Example.png)

Then the application will tick the relevent maps that it finds based on their channel suffix. You can edit what suffixes the program will look for in the preferences menu.

### Selecting Output Folder
With your maps pre-selected we now need to pick a destination to place the images when combined using the _Destination Folder_ button or **Ctrl+D**. 

### Naming Final Maps

Now, you can decide the material name to give each output channel, in this case mine will be: _Giant Mech Body_. Then, using the drop down, you can select which map type to export them as once combined.

### Editing Preferences

After this, you can decide what type of suffix you want the files to be output as. In my case, I prefer my channels to be a simple acronym such as A for Albedo, R for roughness etc.

Navigate to the Preferences Menu either through _Edit->Preferences_ or **Ctrl+P**. In this window, we can select which channel to edit from a drop-down. In each channel we can decide 2 things.

- _Map Suffixes_ - What suffix types to look for when importing files.
- _Output Suffixes_ - What suffix to append once an image is combined.

Once you've decided what channels should output or look for. Hit the _Close_ button or press **Escape**. Hitting _Reset_ will cause all of the preference changes to be set back to their defaults.

### Editing Overlay Order

With our preferences now set we're almost ready to combine our maps but there's one more thing we can do if we need/want to. And that's to change the order in which some sets can be overlayed for each channel.

Some sets exported from Painter may have a higher dilation/bleed than others and so it makes sense to put them in first and then overlay smaller bleeds on top. To do this, simply open the map order window using the _Map Order_ button or **Ctrl+M**.

Inside this window you can see each texture set for each channel and flip between them using the drop-down. To re-order which maps are overlayed, simply drag and drop them ontop of each other to decide where in the order they will be overlayed.

The overlay order of the application goes from Top->Bottom. So texture sets at the top are combined first with each subsequent set being placed on top of the ones before. Once done, hit the _Accept_ button or **Escape** to close the window.

### Editing Colours/Choosing Channels

With our set orders done we can now decide which channels to combine by ticking them on or off. (Ticking a channel which doesn't have any sets on won't do anything.) We can also change the base colour of each image by clicking the colour box above the check-box and picking a colour. You can **Right-Click** a colour box to set it back to it's defaults if you mess it up.

### Combining Images

With all of that done we can now hit the _Combine_ button or **Ctrl+C** to start combining our maps. The bottom of the application will display details of the current maps being combined and how long they took. After they're all done a small window should pop-up announcing it's finished. Simply click ok and you should find your maps.

Hey presto, it's done!

# Shortcuts  
**Ctrl + S** - Open Source Folder Selection  
**Ctrl + D** - Open Destination Folder Selection  
**Ctrl + C** - Start Combining Images Into Map  
**Ctrl + M** - Open Map Order Settings  
**Ctrl + P** - Open Preferences Menu  
**Ctrl + K** - Clear All Map Settings

# Requirements

6GB RAM+ is recommended to do map sizes above 4096x4096 resolution.
---

# Libraries Used

[ImageProcessor](https://github.com/JimBobSquarePants/ImageProcessor) by [JimBobSquarePants](https://github.com/JimBobSquarePants)  
https://imageprocessor.org

[Newtonsoft Json.NET](https://github.com/JamesNK/Newtonsoft.Json) by [JamesNK](https://github.com/JamesNK)  
https://www.newtonsoft.com/json